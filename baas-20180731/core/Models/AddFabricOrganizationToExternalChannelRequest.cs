// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class AddFabricOrganizationToExternalChannelRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("JoinResponse")]
        [Validation(Required=false)]
        public string JoinResponse { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
