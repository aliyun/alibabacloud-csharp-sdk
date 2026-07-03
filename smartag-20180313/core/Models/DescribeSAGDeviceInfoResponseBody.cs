// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSAGDeviceInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The control status of the Smart Access Gateway device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Normal.</description></item>
        /// <item><description><b>Abnormal</b>: Abnormal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("ControllerState")]
        [Validation(Required=false)]
        public string ControllerState { get; set; }

        /// <summary>
        /// <para>The most recent time when the Smart Access Gateway device connected to the controller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-14 00:27:48</para>
        /// </summary>
        [NameInMap("LastConnectedControllerTime")]
        [Validation(Required=false)]
        public string LastConnectedControllerTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6A991F4-F533-1627-8144-B64E01C5EE85</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the reset button of the Smart Access Gateway device is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("ResettableStatus")]
        [Validation(Required=false)]
        public string ResettableStatus { get; set; }

        /// <summary>
        /// <para>The service IP address of the Smart Access Gateway device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42.XX.XX.151</para>
        /// </summary>
        [NameInMap("ServiceIP")]
        [Validation(Required=false)]
        public string ServiceIP { get; set; }

        /// <summary>
        /// <para>The type of the Smart Access Gateway device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sag-100wm</b>.</description></item>
        /// <item><description><b>sag-1000</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sag-100wm</para>
        /// </summary>
        [NameInMap("SmartAGType")]
        [Validation(Required=false)]
        public string SmartAGType { get; set; }

        /// <summary>
        /// <para>The startup time of the Smart Access Gateway device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-15 17:33:43</para>
        /// </summary>
        [NameInMap("StartupTime")]
        [Validation(Required=false)]
        public string StartupTime { get; set; }

        /// <summary>
        /// <para>The synchronization status between the local Smart Access Gateway device and the cloud. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Synchronized</b>: Synchronization is complete.</description></item>
        /// <item><description><b>Unsynchronized</b>: Not synchronized.</description></item>
        /// <item><description><b>Synchronizing</b>: Synchronization is in progress.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unsynchronized</para>
        /// </summary>
        [NameInMap("SynStatus")]
        [Validation(Required=false)]
        public string SynStatus { get; set; }

        /// <summary>
        /// <para>The software version that runs on the Smart Access Gateway device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.3.1.1</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The VPN connection status of the Smart Access Gateway device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Normal.</description></item>
        /// <item><description><b>Abnormal</b>: Abnormal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Abnormal</para>
        /// </summary>
        [NameInMap("VpnState")]
        [Validation(Required=false)]
        public string VpnState { get; set; }

    }

}
