// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetOrganizationalUnitRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the organizational unit.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrganizationalUnitId")]
        [Validation(Required=false)]
        public string OrganizationalUnitId { get; set; }

    }

}
