// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateContactGroupForAlertRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert contact group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sample</para>
        /// </summary>
        [NameInMap("alert_rule_group_name")]
        [Validation(Required=false)]
        public string AlertRuleGroupName { get; set; }

        /// <summary>
        /// <para>The list of contact group IDs.</para>
        /// </summary>
        [NameInMap("contact_group_ids")]
        [Validation(Required=false)]
        public List<long?> ContactGroupIds { get; set; }

        /// <summary>
        /// <para>The name of the container registry instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sample</para>
        /// </summary>
        [NameInMap("cr_name")]
        [Validation(Required=false)]
        public string CrName { get; set; }

        /// <summary>
        /// <para>The namespace in which the resource resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
