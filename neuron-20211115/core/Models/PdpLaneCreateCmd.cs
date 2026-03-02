// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PdpLaneCreateCmd : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>灰度</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>252333049301505383</para>
        /// </summary>
        [NameInMap("creatorUid")]
        [Validation(Required=false)]
        public string CreatorUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rules:
        ///     - vars:
        ///         - name: userId
        ///           position: header
        ///           key: x-linkedmall-user-id
        ///         - name: userType
        ///           position: query
        ///           key: userType
        ///       expression: &quot;userId % 10 == 0 &amp;&amp; userType == A&quot;
        ///       tag: &quot;gray&quot;
        ///       scope: &quot;pbc1,pbc2&quot;</para>
        /// </summary>
        [NameInMap("customeMarkingRules")]
        [Validation(Required=false)]
        public string CustomeMarkingRules { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>泳道描述信息</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("initGroupFlag")]
        [Validation(Required=false)]
        public bool? InitGroupFlag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("inletServiceIds")]
        [Validation(Required=false)]
        public string InletServiceIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEMPLATE</para>
        /// </summary>
        [NameInMap("markingRuleType")]
        [Validation(Required=false)]
        public string MarkingRuleType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gray</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("ruleConditions")]
        [Validation(Required=false)]
        public List<RuleCondition> RuleConditions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("ruleConnectType")]
        [Validation(Required=false)]
        public string RuleConnectType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("serviceGroupIds")]
        [Validation(Required=false)]
        public string ServiceGroupIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>灰度</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
