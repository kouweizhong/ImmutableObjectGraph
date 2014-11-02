﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ImmutableTree Version: 0.0.0.1
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace ImmutableObjectGraph.Tests {
	using System.Diagnostics;
	using System.Linq;
	using ImmutableObjectGraph;
	
	public partial class ReqAndHierL1 {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly ReqAndHierL1 DefaultInstance = GetDefaultTemplate();
		
		/// <summary>The last identity assigned to a created instance.</summary>
		private static int lastIdentityProduced;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String l1Field1;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String l1Field2;
	
		private readonly System.UInt32 identity;
	
		/// <summary>Initializes a new instance of the ReqAndHierL1 class.</summary>
		protected ReqAndHierL1(
			System.UInt32 identity,
			System.String l1Field1,
			System.String l1Field2,
			ImmutableObjectGraph.Optional<bool> skipValidation = default(ImmutableObjectGraph.Optional<bool>))
		{
			this.identity = identity;
			this.l1Field1 = l1Field1;
			this.l1Field2 = l1Field2;
			if (!skipValidation.Value) {
				this.Validate();
			}
		}
	
		public static ReqAndHierL1 Create(
			System.String l1Field2,
			ImmutableObjectGraph.Optional<System.String> l1Field1 = default(ImmutableObjectGraph.Optional<System.String>)) {
			var identity = Optional.For(NewIdentity());
			return DefaultInstance.WithFactory(
				l1Field1: Optional.For(l1Field1.GetValueOrDefault(DefaultInstance.L1Field1)),
				l1Field2: Optional.For(l1Field2),
				identity: Optional.For(identity.GetValueOrDefault(DefaultInstance.Identity)));
		}
	
		public System.String L1Field1 {
			get { return this.l1Field1; }
		}
	
		public System.String L1Field2 {
			get { return this.l1Field2; }
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public ReqAndHierL1 With(
			ImmutableObjectGraph.Optional<System.String> l1Field1 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l1Field2 = default(ImmutableObjectGraph.Optional<System.String>)) {
			return (ReqAndHierL1)this.WithCore(
				l1Field1: l1Field1,
				l1Field2: l1Field2);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		protected virtual ReqAndHierL1 WithCore(
			ImmutableObjectGraph.Optional<System.String> l1Field1 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l1Field2 = default(ImmutableObjectGraph.Optional<System.String>)) {
			var identity = default(ImmutableObjectGraph.Optional<System.UInt32>);
			return this.WithFactory(
				l1Field1: Optional.For(l1Field1.GetValueOrDefault(this.L1Field1)),
				l1Field2: Optional.For(l1Field2.GetValueOrDefault(this.L1Field2)),
				identity: Optional.For(identity.GetValueOrDefault(this.Identity)));
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		private ReqAndHierL1 WithFactory(
			ImmutableObjectGraph.Optional<System.String> l1Field1 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l1Field2 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.UInt32> identity = default(ImmutableObjectGraph.Optional<System.UInt32>)) {
			if (
				(identity.IsDefined && identity.Value != this.Identity) || 
				(l1Field1.IsDefined && l1Field1.Value != this.L1Field1) || 
				(l1Field2.IsDefined && l1Field2.Value != this.L1Field2)) {
				return new ReqAndHierL1(
					identity: identity.GetValueOrDefault(this.Identity),
					l1Field1: l1Field1.GetValueOrDefault(this.L1Field1),
					l1Field2: l1Field2.GetValueOrDefault(this.L1Field2));
			} else {
				return this;
			}
		}
	
		protected internal uint Identity {
			get { return (uint)this.identity; }
		}
	
		/// <summary>Returns a unique identity that may be assigned to a newly created instance.</summary>
		protected static System.UInt32 NewIdentity() {
			return (System.UInt32)System.Threading.Interlocked.Increment(ref lastIdentityProduced);
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated ReqAndHierL1 whose fields are initialized with default values.</summary>
		private static ReqAndHierL1 GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new ReqAndHierL1(
				default(System.UInt32),
				template.L1Field1,
				template.L1Field2,
				skipValidation: true);
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.String L1Field1 { get; set; }
	
			internal System.String L1Field2 { get; set; }
		}
		
		internal static ReqAndHierL1 CreateWithIdentity(
				System.String l1Field2,
				ImmutableObjectGraph.Optional<System.String> l1Field1 = default(ImmutableObjectGraph.Optional<System.String>),
				ImmutableObjectGraph.Optional<System.UInt32> identity = default(ImmutableObjectGraph.Optional<System.UInt32>)) {
			if (!identity.IsDefined) {
				identity = NewIdentity();
			}
		
			return DefaultInstance.WithFactory(
					l1Field1: Optional.For(l1Field1.GetValueOrDefault(DefaultInstance.L1Field1)),
					l1Field2: Optional.For(l1Field2),
					identity: Optional.For(identity.GetValueOrDefault(DefaultInstance.Identity)));
		}
		
		public virtual ReqAndHierL2 ToReqAndHierL2(
			System.String l2Field2,
			ImmutableObjectGraph.Optional<System.String> l2Field1 = default(ImmutableObjectGraph.Optional<System.String>)) {
			ReqAndHierL2 that = this as ReqAndHierL2;
			if (that != null && this.GetType().IsEquivalentTo(typeof(ReqAndHierL2))) {
				if ((!l2Field1.IsDefined || l2Field1.Value == that.L2Field1) && 
				    (l2Field2 == that.L2Field2)) {
					return that;
				}
			}
		
			return ReqAndHierL2.CreateWithIdentity(
				l1Field1: Optional.For(this.L1Field1),
				l1Field2: this.L1Field2,
				identity: this.Identity,
				l2Field1: l2Field1,
				l2Field2: l2Field2);
		}
	}
	
	public partial class ReqAndHierL2 : ReqAndHierL1 {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly ReqAndHierL2 DefaultInstance = GetDefaultTemplate();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String l2Field1;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String l2Field2;
	
		/// <summary>Initializes a new instance of the ReqAndHierL2 class.</summary>
		protected ReqAndHierL2(
			System.UInt32 identity,
			System.String l1Field1,
			System.String l1Field2,
			System.String l2Field1,
			System.String l2Field2,
			ImmutableObjectGraph.Optional<bool> skipValidation = default(ImmutableObjectGraph.Optional<bool>))
			: base(
				identity: identity,
				l1Field1: l1Field1,
				l1Field2: l1Field2)
		{
			this.l2Field1 = l2Field1;
			this.l2Field2 = l2Field2;
			if (!skipValidation.Value) {
				this.Validate();
			}
		}
	
		public static ReqAndHierL2 Create(
			System.String l1Field2,
			System.String l2Field2,
			ImmutableObjectGraph.Optional<System.String> l1Field1 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l2Field1 = default(ImmutableObjectGraph.Optional<System.String>)) {
			var identity = Optional.For(NewIdentity());
			return DefaultInstance.WithFactory(
				l1Field1: Optional.For(l1Field1.GetValueOrDefault(DefaultInstance.L1Field1)),
				l1Field2: Optional.For(l1Field2),
				l2Field1: Optional.For(l2Field1.GetValueOrDefault(DefaultInstance.L2Field1)),
				l2Field2: Optional.For(l2Field2),
				identity: Optional.For(identity.GetValueOrDefault(DefaultInstance.Identity)));
		}
	
		public System.String L2Field1 {
			get { return this.l2Field1; }
		}
	
		public System.String L2Field2 {
			get { return this.l2Field2; }
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		protected override ReqAndHierL1 WithCore(
			ImmutableObjectGraph.Optional<System.String> l1Field1 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l1Field2 = default(ImmutableObjectGraph.Optional<System.String>)) {
			return this.WithFactory(
				l1Field1: l1Field1,
				l1Field2: l1Field2);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public ReqAndHierL2 With(
			ImmutableObjectGraph.Optional<System.String> l1Field1 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l1Field2 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l2Field1 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l2Field2 = default(ImmutableObjectGraph.Optional<System.String>)) {
			return (ReqAndHierL2)this.WithCore(
				l1Field1: l1Field1,
				l1Field2: l1Field2,
				l2Field1: l2Field1,
				l2Field2: l2Field2);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		protected virtual ReqAndHierL2 WithCore(
			ImmutableObjectGraph.Optional<System.String> l1Field1 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l1Field2 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l2Field1 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l2Field2 = default(ImmutableObjectGraph.Optional<System.String>)) {
			var identity = default(ImmutableObjectGraph.Optional<System.UInt32>);
			return this.WithFactory(
				l1Field1: Optional.For(l1Field1.GetValueOrDefault(this.L1Field1)),
				l1Field2: Optional.For(l1Field2.GetValueOrDefault(this.L1Field2)),
				l2Field1: Optional.For(l2Field1.GetValueOrDefault(this.L2Field1)),
				l2Field2: Optional.For(l2Field2.GetValueOrDefault(this.L2Field2)),
				identity: Optional.For(identity.GetValueOrDefault(this.Identity)));
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		private ReqAndHierL2 WithFactory(
			ImmutableObjectGraph.Optional<System.String> l1Field1 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l1Field2 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l2Field1 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> l2Field2 = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.UInt32> identity = default(ImmutableObjectGraph.Optional<System.UInt32>)) {
			if (
				(identity.IsDefined && identity.Value != this.Identity) || 
				(l1Field1.IsDefined && l1Field1.Value != this.L1Field1) || 
				(l1Field2.IsDefined && l1Field2.Value != this.L1Field2) || 
				(l2Field1.IsDefined && l2Field1.Value != this.L2Field1) || 
				(l2Field2.IsDefined && l2Field2.Value != this.L2Field2)) {
				return new ReqAndHierL2(
					identity: identity.GetValueOrDefault(this.Identity),
					l1Field1: l1Field1.GetValueOrDefault(this.L1Field1),
					l1Field2: l1Field2.GetValueOrDefault(this.L1Field2),
					l2Field1: l2Field1.GetValueOrDefault(this.L2Field1),
					l2Field2: l2Field2.GetValueOrDefault(this.L2Field2));
			} else {
				return this;
			}
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated ReqAndHierL2 whose fields are initialized with default values.</summary>
		private static ReqAndHierL2 GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new ReqAndHierL2(
				default(System.UInt32),
				template.L1Field1,
				template.L1Field2,
				template.L2Field1,
				template.L2Field2,
				skipValidation: true);
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.String L1Field1 { get; set; }
	
			internal System.String L1Field2 { get; set; }
	
			internal System.String L2Field1 { get; set; }
	
			internal System.String L2Field2 { get; set; }
		}
		
		internal static ReqAndHierL2 CreateWithIdentity(
				System.String l1Field2,
				System.String l2Field2,
				ImmutableObjectGraph.Optional<System.String> l1Field1 = default(ImmutableObjectGraph.Optional<System.String>),
				ImmutableObjectGraph.Optional<System.String> l2Field1 = default(ImmutableObjectGraph.Optional<System.String>),
				ImmutableObjectGraph.Optional<System.UInt32> identity = default(ImmutableObjectGraph.Optional<System.UInt32>)) {
			if (!identity.IsDefined) {
				identity = NewIdentity();
			}
		
			return DefaultInstance.WithFactory(
					l1Field1: Optional.For(l1Field1.GetValueOrDefault(DefaultInstance.L1Field1)),
					l1Field2: Optional.For(l1Field2),
					l2Field1: Optional.For(l2Field1.GetValueOrDefault(DefaultInstance.L2Field1)),
					l2Field2: Optional.For(l2Field2),
					identity: Optional.For(identity.GetValueOrDefault(DefaultInstance.Identity)));
		}
		
		public ReqAndHierL1 ToReqAndHierL1() {
			return ReqAndHierL1.CreateWithIdentity(
				l1Field1: Optional.For(this.L1Field1),
				l1Field2: this.L1Field2,
				identity: this.Identity);
		}
	}
}


