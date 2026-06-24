// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetRuntimeChannelResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetRuntimeChannelResponseBodyData> Data { get; set; }
        public class GetRuntimeChannelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The channel avatar URL.</para>
            /// </summary>
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            /// <summary>
            /// <para>The channel type. Valid values: System: a system-supported channel. Custom: a custom channel.</para>
            /// </summary>
            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// <para>The channel code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingtalk-connector</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The channel configuration JSON string.</para>
            /// <para>Currently, only the simple configuration mode is supported. You must pass in AppKey and AppSecret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;appKey&quot;: &quot;abc&quot;,
            ///     &quot;appSecret&quot;: &quot;efg&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The configuration mode. Valid values: Simple: simple configuration mode. Custom: custom configuration mode.</para>
            /// </summary>
            [NameInMap("ConfigMode")]
            [Validation(Required=false)]
            public string ConfigMode { get; set; }

            /// <summary>
            /// <para>The QR code configuration notification page URL. This parameter is returned only for the ENTERPRISE or ENTERPRISE_JVS platform.</para>
            /// </summary>
            [NameInMap("QrCodeNotifyUrl")]
            [Validation(Required=false)]
            public string QrCodeNotifyUrl { get; set; }

            /// <summary>
            /// <para>The QR code configuration status. This parameter is returned only when the status is not in a final state.</para>
            /// </summary>
            [NameInMap("QrCodeStatus")]
            [Validation(Required=false)]
            public string QrCodeStatus { get; set; }

            /// <summary>
            /// <para>The risk type. This parameter is returned only when <b>includeRiskInfo=true</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("RiskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

            /// <summary>
            /// <para>The configuration status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Configured</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
