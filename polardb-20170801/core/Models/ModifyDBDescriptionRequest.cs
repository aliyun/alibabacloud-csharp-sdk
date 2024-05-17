// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBDescriptionRequest : TeaModel {
        /// <summary>
        /// The ID of cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The description of the database. The description must meet the following requirements:
        /// 
        /// *   It cannot start with `http://` or `https://`.
        /// *   It must be 2 to 256 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBDescription")]
        [Validation(Required=false)]
        public string DBDescription { get; set; }

        /// <summary>
        /// The name of the database.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
