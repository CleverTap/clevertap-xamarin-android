using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='InboxMessageButtonListener']"
	[Register ("com/clevertap/android/sdk/InboxMessageButtonListener", "", "Com.Clevertap.Android.Sdk.IInboxMessageButtonListenerInvoker")]
	public partial interface IInboxMessageButtonListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='InboxMessageButtonListener']/method[@name='onInboxButtonClick' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onInboxButtonClick", "(Ljava/util/HashMap;)V", "GetOnInboxButtonClick_Ljava_util_HashMap_Handler:Com.Clevertap.Android.Sdk.IInboxMessageButtonListenerInvoker, CleverTapBindings")]
		void OnInboxButtonClick (global::System.Collections.Generic.IDictionary<string, string> p0);

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/InboxMessageButtonListener", DoNotGenerateAcw=true)]
	internal class IInboxMessageButtonListenerInvoker : global::Java.Lang.Object, IInboxMessageButtonListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/clevertap/android/sdk/InboxMessageButtonListener", typeof (IInboxMessageButtonListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IInboxMessageButtonListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInboxMessageButtonListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.InboxMessageButtonListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInboxMessageButtonListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInboxButtonClick_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetOnInboxButtonClick_Ljava_util_HashMap_Handler ()
		{
			if (cb_onInboxButtonClick_Ljava_util_HashMap_ == null)
				cb_onInboxButtonClick_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInboxButtonClick_Ljava_util_HashMap_);
			return cb_onInboxButtonClick_Ljava_util_HashMap_;
		}

		static void n_OnInboxButtonClick_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.IInboxMessageButtonListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.IInboxMessageButtonListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInboxButtonClick (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInboxButtonClick_Ljava_util_HashMap_;
		public unsafe void OnInboxButtonClick (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_onInboxButtonClick_Ljava_util_HashMap_ == IntPtr.Zero)
				id_onInboxButtonClick_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "onInboxButtonClick", "(Ljava/util/HashMap;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInboxButtonClick_Ljava_util_HashMap_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.clevertap.android.sdk.InboxMessageButtonListener.onInboxButtonClick
	public partial class InboxMessageButtonEventArgs : global::System.EventArgs {

		public InboxMessageButtonEventArgs (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			this.p0 = p0;
		}

		global::System.Collections.Generic.IDictionary<string, string> p0;
		public global::System.Collections.Generic.IDictionary<string, string> P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/clevertap/android/sdk/InboxMessageButtonListenerImplementor")]
	internal sealed partial class IInboxMessageButtonListenerImplementor : global::Java.Lang.Object, IInboxMessageButtonListener {

		object sender;

		public IInboxMessageButtonListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/clevertap/android/sdk/InboxMessageButtonListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<InboxMessageButtonEventArgs> Handler;
#pragma warning restore 0649

		public void OnInboxButtonClick (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new InboxMessageButtonEventArgs (p0));
		}

		internal static bool __IsEmpty (IInboxMessageButtonListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
