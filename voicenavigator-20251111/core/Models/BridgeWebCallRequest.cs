// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class BridgeWebCallRequest : TeaModel {
        /// <summary>
        /// <para>The channel ID.</para>
        /// <remarks>
        /// <para>This parameter is valid only when AccessChannelType is set to Web or Trial.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>33606503-c22c-4547-a51c-dda5e8d87962</para>
        /// </summary>
        [NameInMap("AccessChannelId")]
        [Validation(Required=false)]
        public string AccessChannelId { get; set; }

        /// <summary>
        /// <para>The channel type.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Text: text test window</description></item>
        /// <item><description>Test: test window</description></item>
        /// <item><description>Trial: trial link</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Text</para>
        /// </summary>
        [NameInMap("AccessChannelType")]
        [Validation(Required=false)]
        public string AccessChannelType { get; set; }

        /// <summary>
        /// <para>The caller number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>010123*****</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <para>The device ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d4c38420-<b><b>-43bc-b001-56bfc274</b></b></para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the test environment is used.</para>
        /// <remarks>
        /// <para>Default value: false.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DraftVersion")]
        [Validation(Required=false)]
        public bool? DraftVersion { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36e9a4cd-a821-4f78-86fa-a9a4aefeea2e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The sampling rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000</para>
        /// </summary>
        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public int? SampleRate { get; set; }

        /// <summary>
        /// <para>The script ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a88e269-01f5-49ac-97af-5830f0ccb271</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The attached data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The timeout period.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the call is not connected within the time specified by this parameter, the system actively hangs up the call. Unit: seconds. Default value: 60.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
