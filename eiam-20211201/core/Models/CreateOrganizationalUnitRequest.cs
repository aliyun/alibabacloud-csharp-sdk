// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateOrganizationalUnitRequest : TeaModel {
        /// <summary>
        /// The description of the organization. The value can be up to 256 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The external ID of the organization, which can be used to associate the organization with an external system. By default, the external ID is the organization ID. The value can be up to 64 characters in length.
        /// </summary>
        [NameInMap("OrganizationalUnitExternalId")]
        [Validation(Required=false)]
        public string OrganizationalUnitExternalId { get; set; }

        /// <summary>
        /// The name of the organization. The name can be up to 64 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrganizationalUnitName")]
        [Validation(Required=false)]
        public string OrganizationalUnitName { get; set; }

        /// <summary>
        /// The parent organization ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

    }

}
