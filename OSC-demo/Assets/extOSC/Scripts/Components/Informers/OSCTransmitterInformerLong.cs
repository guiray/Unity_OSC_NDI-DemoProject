﻿/* Copyright (c) 2021 dr. ext (Vladimir Sigalkin) */

using UnityEngine;

namespace extOSC.Components.Informers
{
	[AddComponentMenu("extOSC/Components/Transmitter/Long Informer")]
	public class OSCTransmitterInformerLong : OSCTransmitterInformer<long>
	{
		#region Protected Methods

		protected override void FillMessage(OSCMessage message, long value) => message.AddValue(OSCValue.Long(value));

		#endregion
	}
}