// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateLDAPConfigRequest : TeaModel {
        /// <summary>
        /// An LDAP entry.
        /// </summary>
        [NameInMap("BindDN")]
        [Validation(Required=false)]
        public string BindDN { get; set; }

        /// <summary>
        /// The ID of the file system.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// An LDAP search base.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SearchBase")]
        [Validation(Required=false)]
        public string SearchBase { get; set; }

        /// <summary>
        /// An LDAP URI.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}
