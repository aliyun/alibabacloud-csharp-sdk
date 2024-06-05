// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyLDAPConfigRequest : TeaModel {
        [NameInMap("BindDN")]
        [Validation(Required=false)]
        public string BindDN { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SearchBase")]
        [Validation(Required=false)]
        public string SearchBase { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}
