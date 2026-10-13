// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateDeveloperStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the portal to which the developer belongs, which is the primary ID of the portal resource. You can obtain this ID from the portalId field in the CreatePortal response or from the portalId field of an item in the ListPortals response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>portal-xxxxxxxx</para>
        /// </summary>
        [NameInMap("portalId")]
        [Validation(Required=false)]
        public string PortalId { get; set; }

        /// <summary>
        /// <para>The target status of the developer. Valid values: PENDING, APPROVED, and REJECTED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APPROVED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
