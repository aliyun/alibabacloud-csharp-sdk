// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PdpLane : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>灰度</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>252333049301505383</para>
        /// </summary>
        [NameInMap("creatorUid")]
        [Validation(Required=false)]
        public string CreatorUid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
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

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("initGroupFlag")]
        [Validation(Required=false)]
        public bool? InitGroupFlag { get; set; }

        [NameInMap("inletServices")]
        [Validation(Required=false)]
        public List<PdpServiceInfo> InletServices { get; set; }

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
        /// <b>Example:</b>
        /// <para>gray</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>linkemall</para>
        /// </summary>
        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3239281273464326823</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

        [NameInMap("serviceGroups")]
        [Validation(Required=false)]
        public List<ServiceGroupInfo> ServiceGroups { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
