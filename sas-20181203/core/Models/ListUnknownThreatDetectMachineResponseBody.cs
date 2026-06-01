// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnknownThreatDetectMachineResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUnknownThreatDetectMachineResponseBodyData> Data { get; set; }
        public class ListUnknownThreatDetectMachineResponseBodyData : TeaModel {
            [NameInMap("EffectDays")]
            [Validation(Required=false)]
            public long? EffectDays { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProcessCount")]
            [Validation(Required=false)]
            public int? ProcessCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>studying</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>1766988192</para>
            /// </summary>
            [NameInMap("StudyStartTime")]
            [Validation(Required=false)]
            public long? StudyStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6690a46c-0edb-4663-a641-3629d1a9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListUnknownThreatDetectMachineResponseBodyPageInfo PageInfo { get; set; }
        public class ListUnknownThreatDetectMachineResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-XXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
