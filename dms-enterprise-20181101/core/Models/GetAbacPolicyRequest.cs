// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetAbacPolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("AbacPolicyId")]
        [Validation(Required=false)]
        public long? AbacPolicyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>policy_test</para>
        /// </summary>
        [NameInMap("AbacPolicyName")]
        [Validation(Required=false)]
        public string AbacPolicyName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
