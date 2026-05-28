// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PolicyConfiguration : TeaModel {
        /// <summary>
        /// <para>The action policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example_action_policy</para>
        /// </summary>
        [NameInMap("actionPolicyId")]
        [Validation(Required=false)]
        public string ActionPolicyId { get; set; }

        /// <summary>
        /// <para>The alert policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls.builtin.dynamic</para>
        /// </summary>
        [NameInMap("alertPolicyId")]
        [Validation(Required=false)]
        public string AlertPolicyId { get; set; }

        /// <summary>
        /// <para>The repeat interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10m</para>
        /// </summary>
        [NameInMap("repeatInterval")]
        [Validation(Required=false)]
        public string RepeatInterval { get; set; }

    }

}
