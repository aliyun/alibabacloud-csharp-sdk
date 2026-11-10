// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationProvisioningScopeResponseBody : TeaModel {
        /// <summary>
        /// <para>The account synchronization scope.</para>
        /// </summary>
        [NameInMap("ApplicationProvisioningScope")]
        [Validation(Required=false)]
        public GetApplicationProvisioningScopeResponseBodyApplicationProvisioningScope ApplicationProvisioningScope { get; set; }
        public class GetApplicationProvisioningScopeResponseBodyApplicationProvisioningScope : TeaModel {
            /// <summary>
            /// <para>The list of groups authorized for synchronization.</para>
            /// </summary>
            [NameInMap("GroupIds")]
            [Validation(Required=false)]
            public List<string> GroupIds { get; set; }

            /// <summary>
            /// <para>The maximum quota of authorized principals for the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxQuota")]
            [Validation(Required=false)]
            public int? MaxQuota { get; set; }

            /// <summary>
            /// <para>The list of organizational unit scopes authorized for account synchronization.</para>
            /// </summary>
            [NameInMap("OrganizationalUnitIds")]
            [Validation(Required=false)]
            public List<string> OrganizationalUnitIds { get; set; }

            /// <summary>
            /// <para>The used quota of authorized principals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedQuota")]
            [Validation(Required=false)]
            public int? UsedQuota { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
