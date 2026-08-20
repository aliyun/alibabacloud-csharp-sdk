// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class ListAIAgentEventRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the agent application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99f30e6b-8374-4a45-8830-439f178c5463</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Filters the agent list by application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>erH</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The asset name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13.115.192.70</para>
        /// </summary>
        [NameInMap("AssetName")]
        [Validation(Required=false)]
        public string AssetName { get; set; }

        /// <summary>
        /// <para>The type of the agent asset. Valid values:</para>
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
        /// <para>identity</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

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
        /// <para>The infrastructure instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-test</para>
        /// </summary>
        [NameInMap("InfraInstanceId")]
        [Validation(Required=false)]
        public string InfraInstanceId { get; set; }

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
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Sort direction</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>Sort field, currently supports CheckTime</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

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
        /// <para>The risk level of the check item to query. Valid values:</para>
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
        /// <para>The risk name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defense</para>
        /// </summary>
        [NameInMap("RiskName")]
        [Validation(Required=false)]
        public string RiskName { get; set; }

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
        /// <para>CSPM</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <ol>
        /// <item><description>unhandled: Pending.</description></item>
        /// <item><description>handling: Being processed.</description></item>
        /// <item><description>fixed: Fixed.</description></item>
        /// <item><description>ignored: Ignored.</description></item>
        /// <item><description>rescanned: Rescanned.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>fixed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of statuses.</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

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

}
