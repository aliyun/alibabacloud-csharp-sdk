// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GrantPermissionRequest : TeaModel {
        /// <summary>
        /// Specifies whether to grant the permissions with the GRANT option. Valid values: -**true** -**false**
        /// </summary>
        [NameInMap("GrantOption")]
        [Validation(Required=false)]
        public bool? GrantOption { get; set; }

        /// <summary>
        /// The application group ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The namespace ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The source of the namespace. This parameter is required only for a special third party.
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The user ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// The username.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
