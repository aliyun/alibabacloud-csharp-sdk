// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SetOwnersRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **SetOwners**.
        /// </summary>
        [NameInMap("OwnerIds")]
        [Validation(Required=false)]
        public string OwnerIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The ID of the user whom you want to specify as an owner. Separate multiple IDs with commas (,). You can call the [GetUser](~~147098~~) or [ListUsers](~~141938~~) operation to query the ID of the user.
        /// 
        /// >  The value of the OwnerIds parameter is that of the UserId parameter.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
