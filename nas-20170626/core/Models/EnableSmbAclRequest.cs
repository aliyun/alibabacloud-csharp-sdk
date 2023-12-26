// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class EnableSmbAclRequest : TeaModel {
        /// <summary>
        /// The ID of the file system.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The string that is generated after the system encodes the keytab file by using Base64.
        /// </summary>
        [NameInMap("Keytab")]
        [Validation(Required=false)]
        public string Keytab { get; set; }

        /// <summary>
        /// The string that is generated after the system encodes the keytab file by using MD5.
        /// </summary>
        [NameInMap("KeytabMd5")]
        [Validation(Required=false)]
        public string KeytabMd5 { get; set; }

    }

}
