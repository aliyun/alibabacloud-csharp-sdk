// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ModifyTrafficMatchRuleToTrafficMarkingPolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tm-u9nxup5kww5po8****</para>
        /// </summary>
        [NameInMap("TrafficMarkingPolicyId")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>descriptiontest</para>
        /// </summary>
        [NameInMap("TrafficMatchRuleDescription")]
        [Validation(Required=false)]
        public string TrafficMatchRuleDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tm-rule-fa9kgq1e90rmhc****</para>
        /// </summary>
        [NameInMap("TrafficMatchRuleId")]
        [Validation(Required=false)]
        public string TrafficMatchRuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("TrafficMatchRuleName")]
        [Validation(Required=false)]
        public string TrafficMatchRuleName { get; set; }

    }

}
