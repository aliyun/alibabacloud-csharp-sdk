// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonTargetResultListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6673D49C-A9AB-40DD-B4A2-B92306701AE7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the configuration item.</para>
        /// </summary>
        [NameInMap("TargetConfig")]
        [Validation(Required=false)]
        public DescribeCommonTargetResultListResponseBodyTargetConfig TargetConfig { get; set; }
        public class DescribeCommonTargetResultListResponseBodyTargetConfig : TeaModel {
            /// <summary>
            /// <para>The identifier that indicates whether the configuration item is applied to the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>add</b>: applied</description></item>
            /// <item><description><b>del</b>: not applied</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>del</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// <para>The default identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("TargetDefault")]
            [Validation(Required=false)]
            public string TargetDefault { get; set; }

            /// <summary>
            /// <para>An array that consists of the IDs of the server groups or the UUIDs of the servers.</para>
            /// <remarks>
            /// <para> If <b>uuid</b> is returned for the <b>TargetType</b> parameter, <b>UUIDs</b> of the servers are returned. If <b>groupId</b> is returned for the <b>TargetType</b> parameter, IDs of the server groups are returned.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<string> TargetList { get; set; }

            /// <summary>
            /// <para>The type of the server to which the configuration item is applied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>uuid</b>: a server</description></item>
            /// <item><description><b>groupId</b>: a server group</description></item>
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
            /// <para>The type of the configuration item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>webshell_timescan</b>: webshell detection and removal</description></item>
            /// <item><description><b>aliscriptengine</b>: in-depth detection engine</description></item>
            /// <item><description><b>alidetect</b>: installation scope of local file detection</description></item>
            /// <item><description><b>alidetect-scan-enable</b>: detection scope of local file detection</description></item>
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
