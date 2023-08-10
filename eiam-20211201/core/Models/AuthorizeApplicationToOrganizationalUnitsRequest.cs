// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class AuthorizeApplicationToOrganizationalUnitsRequest : TeaModel {
        /// <summary>
        /// The ID of the application on which you want to grant permissions.
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The IDs of the organizations to which you want to grant permissions. You can grant permissions to a maximum of 100 organizations at a time.
        /// </summary>
        [NameInMap("OrganizationalUnitIds")]
        [Validation(Required=false)]
        public List<string> OrganizationalUnitIds { get; set; }

    }

}
