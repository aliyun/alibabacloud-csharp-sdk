// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDirRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OwnerGroupId")]
        [Validation(Required=false)]
        public int? OwnerGroupId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public int? OwnerUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        [NameInMap("Recursion")]
        [Validation(Required=false)]
        public bool? Recursion { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RootDirectory")]
        [Validation(Required=false)]
        public string RootDirectory { get; set; }

    }

}
