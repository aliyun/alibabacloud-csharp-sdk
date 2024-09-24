// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The intrusion events.</para>
        /// </summary>
        [NameInMap("HoneypotEvents")]
        [Validation(Required=false)]
        public List<ListHoneypotEventsResponseBodyHoneypotEvents> HoneypotEvents { get; set; }
        public class ListHoneypotEventsResponseBodyHoneypotEvents : TeaModel {
            /// <summary>
            /// <para>The probe ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27d44bd5815d401992ea672874d9****</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The name of the probe.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1193474_test_****</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The ID of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1900752</para>
            /// </summary>
            [NameInMap("AlarmEventId")]
            [Validation(Required=false)]
            public long? AlarmEventId { get; set; }

            /// <summary>
            /// <para>The destination IP address of the attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112.126.205.***</para>
            /// </summary>
            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            /// <summary>
            /// <para>The timestamp at which the event was first detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1692670297</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>The name of the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>honeypot-2</para>
            /// </summary>
            [NameInMap("HoneypotName")]
            [Validation(Required=false)]
            public string HoneypotName { get; set; }

            /// <summary>
            /// <para>The timestamp at which the event was last detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1676558664</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>The region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China Beijing</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The extended values that correspond to the field key.</para>
            /// </summary>
            [NameInMap("MergeFieldList")]
            [Validation(Required=false)]
            public List<ListHoneypotEventsResponseBodyHoneypotEventsMergeFieldList> MergeFieldList { get; set; }
            public class ListHoneypotEventsResponseBodyHoneypotEventsMergeFieldList : TeaModel {
                /// <summary>
                /// <para>The supplementary information about the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data</para>
                /// </summary>
                [NameInMap("FieldExtInfo")]
                [Validation(Required=false)]
                public string FieldExtInfo { get; set; }

                /// <summary>
                /// <para>The key of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>type</para>
                /// </summary>
                [NameInMap("FieldKey")]
                [Validation(Required=false)]
                public string FieldKey { get; set; }

                /// <summary>
                /// <para>The type of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>level2_item1</para>
                /// </summary>
                [NameInMap("FieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The value of the field key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>web_access</para>
                /// </summary>
                [NameInMap("FieldValue")]
                [Validation(Required=false)]
                public string FieldValue { get; set; }

            }

            /// <summary>
            /// <para>The protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b></description></item>
            /// <item><description><b>udp</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: low</description></item>
            /// <item><description><b>3</b>: medium</description></item>
            /// <item><description><b>4</b>: high</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The ID of the intrusion event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70427821</para>
            /// </summary>
            [NameInMap("SecurityEventId")]
            [Validation(Required=false)]
            public long? SecurityEventId { get; set; }

            /// <summary>
            /// <para>The source IP address of the attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.62.***</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotEventsResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotEventsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The key of the last data entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESGgoSChAKDGNvbXBsZXRlVGltZRABCgQiAggAGAAiQAoJAGYXFWIAAAAACjMDLgAAADFTNzMyZDMwMzAzMDM1Mzc3Njc4MzA2ODY5NmI2YTY*********</para>
            /// </summary>
            [NameInMap("LastRowKey")]
            [Validation(Required=false)]
            public string LastRowKey { get; set; }

            /// <summary>
            /// <para>The value of the NextToken parameter that is returned by using the NextToken method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B604532DEF982B875E8360A6EFA3B***</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

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
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FBD28009-6096-5E90-BFE6-62CCD67*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
