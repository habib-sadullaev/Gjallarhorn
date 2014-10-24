﻿namespace Gjallarhorn

/// Manages creation of mutable variables
module Mutable =
    
    [<CompiledName("Create")>]
    /// Create a mutable variable wrapping an initial value
    let create (value : 'a) = 
        Mutable(value) :> IMutatable<'a>   

    [<CompiledName("Get")>]
    /// Gets the value associated with the mutatable object
    let get (mutatable : IMutatable<'a>) = 
        mutatable.Value

    [<CompiledName("Set")>]
    /// Sets the value associated with the mutatable object
    let set (mutatable : IMutatable<'a>) value = 
        mutatable.Value <- value
