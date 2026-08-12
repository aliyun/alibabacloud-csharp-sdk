// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class ListAIAgentEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of event information returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAIAgentEventResponseBodyData> Data { get; set; }
        public class ListAIAgentEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5zuzvcfe</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-chagee-bc-activity-elespin</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The asset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25.2.2.83</para>
            /// </summary>
            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            /// <summary>
            /// <para>The type of the risky asset. Valid values:</para>
            /// <ol>
            /// <item><description>rag</description></item>
            /// <item><description>internet</description></item>
            /// <item><description>datasets</description></item>
            /// <item><description>tool</description></item>
            /// <item><description>model</description></item>
            /// <item><description>skill</description></item>
            /// <item><description>app</description></item>
            /// <item><description>identity</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>tool</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The check time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1763949968</para>
            /// </summary>
            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            /// <summary>
            /// <para>The event handling time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1763949968</para>
            /// </summary>
            [NameInMap("HandleTime")]
            [Validation(Required=false)]
            public string HandleTime { get; set; }

            /// <summary>
            /// <para>The primary key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17616</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The infrastructure instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-test</para>
            /// </summary>
            [NameInMap("InfraInstanceId")]
            [Validation(Required=false)]
            public string InfraInstanceId { get; set; }

            /// <summary>
            /// <para>The public IP address of the infrastructure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.3.4</para>
            /// </summary>
            [NameInMap("InfraInternetIp")]
            [Validation(Required=false)]
            public string InfraInternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the infrastructure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.3</para>
            /// </summary>
            [NameInMap("InfraIntranetIp")]
            [Validation(Required=false)]
            public string InfraIntranetIp { get; set; }

            /// <summary>
            /// <para>The infrastructure name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InfraName")]
            [Validation(Required=false)]
            public string InfraName { get; set; }

            /// <summary>
            /// <para>The infrastructure region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("InfraRegionId")]
            [Validation(Required=false)]
            public string InfraRegionId { get; set; }

            /// <summary>
            /// <para>The infrastructure type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("InfraType")]
            [Validation(Required=false)]
            public string InfraType { get; set; }

            /// <summary>
            /// <para>The risk description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The workflow does not have AI security guardrails enabled, which may lead to compliance violations, prompt injection and bypass, sensitive data leaks, and other risks</para>
            /// </summary>
            [NameInMap("RiskDesc")]
            [Validation(Required=false)]
            public string RiskDesc { get; set; }

            /// <summary>
            /// <para>The risk level of the detected alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b>: High.</description></item>
            /// <item><description><b>medium</b>: Medium.</description></item>
            /// <item><description><b>low</b>: Low.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The risk name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weak password</para>
            /// </summary>
            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            [NameInMap("SkillId")]
            [Validation(Required=false)]
            public long? SkillId { get; set; }

            /// <summary>
            /// <para>The event source. Valid values:</para>
            /// <ol>
            /// <item><description>cspm</description></item>
            /// <item><description>aiguard</description></item>
            /// <item><description>SASE</description></item>
            /// <item><description>SAS </description></item>
            /// <item><description>Agent-Runtime-Guard</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>SASE</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <ol>
            /// <item><description>unhandled: Pending.</description></item>
            /// <item><description>handling: Being processed.</description></item>
            /// <item><description>fixed: Fixed.</description></item>
            /// <item><description>ignored: Ignored.</description></item>
            /// <item><description>rescanned: Rescanned.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>unhandled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The cloud asset vendor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DIFY</b>: DIFY.</description></item>
            /// <item><description><b>BAILIAN</b>: BAILIAN.</description></item>
            /// <item><description><b>VOLCAI</b>: VOLCAI.</description></item>
            /// <item><description><b>AGENTRUN</b>: AGENTRUN.</description></item>
            /// <item><description><b>PAI</b>: PAI.</description></item>
            /// <item><description><b>OpenClaw</b>: OpenClaw.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DIFY</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListAIAgentEventResponseBodyPageInfo PageInfo { get; set; }
        public class ListAIAgentEventResponseBodyPageInfo : TeaModel {
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
            /// <para>The NextToken value returned when the NextToken-based pagination method is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d6yVpGGP9cH8f9AWtqEXqOawJdolFvFeqJJSIPnYLoGc7/XPd5nbDfZcn1mJCj66Ep3Gbr55tl4NuBtNwsc0A0qvqC2Onfm9h2QmtG8HhaulnPkGmBnhntKqJmpRptTU</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records in the query result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FDE3D6F-26BD-5937-B0E5-8F47962B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
