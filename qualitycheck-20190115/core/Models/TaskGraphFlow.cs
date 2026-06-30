// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class TaskGraphFlow : TeaModel {
        /// <summary>
        /// <para>Flow scoring logic settings</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FlowRuleScoreType")]
        [Validation(Required=false)]
        public int? FlowRuleScoreType { get; set; }

        /// <summary>
        /// <para>Canvas ID of the flow</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>All nodes in the flow</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<GraphFlowNode> Nodes { get; set; }

        /// <summary>
        /// <para>Rule ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Rid")]
        [Validation(Required=false)]
        public long? Rid { get; set; }

        /// <summary>
        /// <para>Rule Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>违规</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Used for frontend display</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ShowProperties")]
        [Validation(Required=false)]
        public string ShowProperties { get; set; }

        /// <summary>
        /// <para>Skip if the first session node is not hit</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SkipWhenFirstSessionNodeMiss")]
        [Validation(Required=false)]
        public bool? SkipWhenFirstSessionNodeMiss { get; set; }

    }

}
