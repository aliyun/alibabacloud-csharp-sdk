// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class UpdateEgressProxyConfigurationAttributeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DefaultRulePhaseActions")]
        [Validation(Required=false)]
        public UpdateEgressProxyConfigurationAttributeRequestDefaultRulePhaseActions DefaultRulePhaseActions { get; set; }
        public class UpdateEgressProxyConfigurationAttributeRequestDefaultRulePhaseActions : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("PostResponse")]
            [Validation(Required=false)]
            public string PostResponse { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("PreDns")]
            [Validation(Required=false)]
            public string PreDns { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("PreRequest")]
            [Validation(Required=false)]
            public string PreRequest { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epc-gw80d16a969933e7****</para>
        /// </summary>
        [NameInMap("EgressProxyConfigurationId")]
        [Validation(Required=false)]
        public string EgressProxyConfigurationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("EgressProxyConfigurationName")]
        [Validation(Required=false)]
        public string EgressProxyConfigurationName { get; set; }

        [NameInMap("EgressProxyRuleGroups")]
        [Validation(Required=false)]
        public List<UpdateEgressProxyConfigurationAttributeRequestEgressProxyRuleGroups> EgressProxyRuleGroups { get; set; }
        public class UpdateEgressProxyConfigurationAttributeRequestEgressProxyRuleGroups : TeaModel {
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
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

    }

}
