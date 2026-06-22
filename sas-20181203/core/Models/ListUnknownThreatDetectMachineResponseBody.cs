// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnknownThreatDetectMachineResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of instance details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUnknownThreatDetectMachineResponseBodyData> Data { get; set; }
        public class ListUnknownThreatDetectMachineResponseBodyData : TeaModel {
            [NameInMap("EffectDays")]
            [Validation(Required=false)]
            public long? EffectDays { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.42.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("PluginStatus")]
            [Validation(Required=false)]
            public string PluginStatus { get; set; }

            /// <summary>
            /// <para>The process count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProcessCount")]
            [Validation(Required=false)]
            public int? ProcessCount { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>monitoring</b>: The instance is being monitored for threats.</para>
            /// </description></item>
            /// <item><description><para><b>blocking</b>: The instance is blocking unauthorized processes.</para>
            /// </description></item>
            /// <item><description><para><b>studying</b>: The instance is in a learning phase.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>studying</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The whitelist mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>hash</b>: process hash</para>
            /// </description></item>
            /// <item><description><para><b>path</b>: process path</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hash</para>
            /// </summary>
            [NameInMap("StudyMode")]
            [Validation(Required=false)]
            public string StudyMode { get; set; }

            [NameInMap("StudyRemainDays")]
            [Validation(Required=false)]
            public long? StudyRemainDays { get; set; }

            /// <summary>
            /// <para>The timestamp when the learning phase started. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1766988192</para>
            /// </summary>
            [NameInMap("StudyStartTime")]
            [Validation(Required=false)]
            public long? StudyStartTime { get; set; }

            /// <summary>
            /// <para>The UUID of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6690a46c-0edb-4663-a641-3629d1a9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListUnknownThreatDetectMachineResponseBodyPageInfo PageInfo { get; set; }
        public class ListUnknownThreatDetectMachineResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-XXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
