// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class RemoveIpControlPolicyItemRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ACL. The ID is unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ea91319a34d48a09b5c9c871d9768b1</para>
        /// </summary>
        [NameInMap("IpControlId")]
        [Validation(Required=false)]
        public string IpControlId { get; set; }

        /// <summary>
        /// <para>The ID of a policy. Separate multiple IDs with semicolons (;). A maximum of 100 IDs can be entered.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P151533572852362;P151533557750260</para>
        /// </summary>
        [NameInMap("PolicyItemIds")]
        [Validation(Required=false)]
        public string PolicyItemIds { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
