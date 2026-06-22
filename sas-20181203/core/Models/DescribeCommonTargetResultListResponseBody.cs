// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonTargetResultListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6673D49C-A9AB-40DD-B4A2-B92306701AE7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configuration information.</para>
        /// </summary>
        [NameInMap("TargetConfig")]
        [Validation(Required=false)]
        public DescribeCommonTargetResultListResponseBodyTargetConfig TargetConfig { get; set; }
        public class DescribeCommonTargetResultListResponseBodyTargetConfig : TeaModel {
            /// <summary>
            /// <para>The asset configuration flag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>add</b>: The configuration takes effect on the asset.</description></item>
            /// <item><description><b>del</b>: The configuration does not take effect on the asset.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>del</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// <para>The default flag for asset configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("TargetDefault")]
            [Validation(Required=false)]
            public string TargetDefault { get; set; }

            /// <summary>
            /// <para>The group ID or asset UUID on which the configuration takes effect.</para>
            /// <remarks>
            /// <para>If <b>TargetType</b> returns <b>uuid</b>, this field indicates the <b>UUID</b> of the asset. If <b>TargetType</b> returns <b>groupId</b>, this field indicates the group ID.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<string> TargetList { get; set; }

            /// <summary>
            /// <para>The selection mode for the assets on which the configuration takes effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>uuid</b>: Added by individual asset.</description></item>
            /// <item><description><b>groupId</b>: Added by server group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>uuid</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

            /// <summary>
            /// <para>The configuration type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>webshell_timescan</b>: web shell scan.</description></item>
            /// <item><description><b>aliscriptengine</b>: deep detection engine.</description></item>
            /// <item><description><b>alidetect</b>: installation scope of the local file detection engine.</description></item>
            /// <item><description><b>alidetect-scan-enable</b>: detection scope of the local file detection engine.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>webshell_timescan</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
