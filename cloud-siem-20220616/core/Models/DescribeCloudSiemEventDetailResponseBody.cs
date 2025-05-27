// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCloudSiemEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCloudSiemEventDetailResponseBodyData Data { get; set; }
        public class DescribeCloudSiemEventDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of alerts that are associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("AlertNum")]
            [Validation(Required=false)]
            public int? AlertNum { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the event belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127608589417****</para>
            /// </summary>
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public long? Aliuid { get; set; }

            /// <summary>
            /// <para>The number of assets that are associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("AssetNum")]
            [Validation(Required=false)]
            public int? AssetNum { get; set; }

            /// <summary>
            /// <para>The tags of the ATT\&amp;CK attacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;T1595.002 Vulnerability Scanning&quot;]</para>
            /// </summary>
            [NameInMap("AttCkLabels")]
            [Validation(Required=false)]
            public List<string> AttCkLabels { get; set; }

            [NameInMap("AttckStages")]
            [Validation(Required=false)]
            public List<DescribeCloudSiemEventDetailResponseBodyDataAttckStages> AttckStages { get; set; }
            public class DescribeCloudSiemEventDetailResponseBodyDataAttckStages : TeaModel {
                [NameInMap("AlertNum")]
                [Validation(Required=false)]
                public int? AlertNum { get; set; }

                [NameInMap("TacticId")]
                [Validation(Required=false)]
                public string TacticId { get; set; }

                [NameInMap("TacticName")]
                [Validation(Required=false)]
                public string TacticName { get; set; }

            }

            /// <summary>
            /// <para>The source of the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[sas,waf]</para>
            /// </summary>
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<string> DataSources { get; set; }

            /// <summary>
            /// <para>The description of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The threat event contains 13 Miner Network,1 Execute suspicious encoded commands on Linux, etc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The description of the event in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The threat event contains 13 Miner Network,1 Execute suspicious encoded commands on Linux, etc</para>
            /// </summary>
            [NameInMap("DescriptionEn")]
            [Validation(Required=false)]
            public string DescriptionEn { get; set; }

            /// <summary>
            /// <para>The extended information of the event in the JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;event_transfer_type&quot;:&quot;customize_rule&quot;}</para>
            /// </summary>
            [NameInMap("ExtContent")]
            [Validation(Required=false)]
            public string ExtContent { get; set; }

            /// <summary>
            /// <para>The time when the event occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-06 16:37:29</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the event was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-06 16:37:29</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The name of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Multiple type of alerts, including Miner Network, Command line download and run malicious files, Backdoor Process, etc</para>
            /// </summary>
            [NameInMap("IncidentName")]
            [Validation(Required=false)]
            public string IncidentName { get; set; }

            /// <summary>
            /// <para>The name of the event in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Multiple type of alerts, including Miner Network, Command line download and run malicious files, Backdoor Process, etc</para>
            /// </summary>
            [NameInMap("IncidentNameEn")]
            [Validation(Required=false)]
            public string IncidentNameEn { get; set; }

            [NameInMap("IncidentType")]
            [Validation(Required=false)]
            public string IncidentType { get; set; }

            /// <summary>
            /// <para>The UUID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
            /// </summary>
            [NameInMap("IncidentUuid")]
            [Validation(Required=false)]
            public string IncidentUuid { get; set; }

            /// <summary>
            /// <para>Users associated with the event.</para>
            /// </summary>
            [NameInMap("ReferAccount")]
            [Validation(Required=false)]
            public string ReferAccount { get; set; }

            /// <summary>
            /// <para>The remarks of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dealed</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The status of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: not handled</description></item>
            /// <item><description>1: handing</description></item>
            /// <item><description>5: handling failed</description></item>
            /// <item><description>10: handled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>serious: high</description></item>
            /// <item><description>suspicious: medium</description></item>
            /// <item><description>remind: low</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>remind</para>
            /// </summary>
            [NameInMap("ThreatLevel")]
            [Validation(Required=false)]
            public string ThreatLevel { get; set; }

            /// <summary>
            /// <para>The risk score of the event. The score ranges from 0 to 100. A higher score indicates a higher risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90.2</para>
            /// </summary>
            [NameInMap("ThreatScore")]
            [Validation(Required=false)]
            public float? ThreatScore { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
