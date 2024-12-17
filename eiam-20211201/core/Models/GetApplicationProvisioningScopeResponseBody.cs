// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationProvisioningScopeResponseBody : TeaModel {
        /// <summary>
        /// <para>The scope of account synchronization.</para>
        /// </summary>
        [NameInMap("ApplicationProvisioningScope")]
        [Validation(Required=false)]
        public GetApplicationProvisioningScopeResponseBodyApplicationProvisioningScope ApplicationProvisioningScope { get; set; }
        public class GetApplicationProvisioningScopeResponseBodyApplicationProvisioningScope : TeaModel {
            /// <summary>
            /// <para>Synchronize the list of authorized groups</para>
            /// </summary>
            [NameInMap("GroupIds")]
            [Validation(Required=false)]
            public List<string> GroupIds { get; set; }

            /// <summary>
            /// <para>Instance Indicates the maximum quota number of authorized agents</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxQuota")]
            [Validation(Required=false)]
            public int? MaxQuota { get; set; }

            /// <summary>
            /// <para>The list of organizational units that are authorized for account synchronization.</para>
            /// </summary>
            [NameInMap("OrganizationalUnitIds")]
            [Validation(Required=false)]
            public List<string> OrganizationalUnitIds { get; set; }

            /// <summary>
            /// <para>Indicates the quota number of used authorized agents</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedQuota")]
            [Validation(Required=false)]
            public int? UsedQuota { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
