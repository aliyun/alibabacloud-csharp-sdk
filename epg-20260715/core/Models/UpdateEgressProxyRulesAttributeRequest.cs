// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class UpdateEgressProxyRulesAttributeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eprg-gw80bb6a95380edb****</para>
        /// </summary>
        [NameInMap("EgressProxyRuleGroupId")]
        [Validation(Required=false)]
        public string EgressProxyRuleGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EgressProxyRules")]
        [Validation(Required=false)]
        public List<UpdateEgressProxyRulesAttributeRequestEgressProxyRules> EgressProxyRules { get; set; }
        public class UpdateEgressProxyRulesAttributeRequestEgressProxyRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("AddConditions")]
            [Validation(Required=false)]
            public List<UpdateEgressProxyRulesAttributeRequestEgressProxyRulesAddConditions> AddConditions { get; set; }
            public class UpdateEgressProxyRulesAttributeRequestEgressProxyRulesAddConditions : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>request:DestinationDomain</para>
                /// </summary>
                [NameInMap("ConditionKey")]
                [Validation(Required=false)]
                public string ConditionKey { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StringEquals</para>
                /// </summary>
                [NameInMap("ConditionOperator")]
                [Validation(Required=false)]
                public string ConditionOperator { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ConditionValues")]
                [Validation(Required=false)]
                public List<string> ConditionValues { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testEpg</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epr-gw80bb6a91dbb775****</para>
            /// </summary>
            [NameInMap("EgressProxyRuleId")]
            [Validation(Required=false)]
            public string EgressProxyRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testEpg</para>
            /// </summary>
            [NameInMap("EgressProxyRuleName")]
            [Validation(Required=false)]
            public string EgressProxyRuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("RemoveConditions")]
            [Validation(Required=false)]
            public List<UpdateEgressProxyRulesAttributeRequestEgressProxyRulesRemoveConditions> RemoveConditions { get; set; }
            public class UpdateEgressProxyRulesAttributeRequestEgressProxyRulesRemoveConditions : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>request:DestinationDomain</para>
                /// </summary>
                [NameInMap("ConditionKey")]
                [Validation(Required=false)]
                public string ConditionKey { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StringEquals</para>
                /// </summary>
                [NameInMap("ConditionOperator")]
                [Validation(Required=false)]
                public string ConditionOperator { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ConditionValues")]
                [Validation(Required=false)]
                public List<string> ConditionValues { get; set; }

            }

        }

    }

}
