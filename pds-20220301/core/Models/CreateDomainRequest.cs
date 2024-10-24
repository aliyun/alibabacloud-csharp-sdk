// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateDomainRequest : TeaModel {
        /// <summary>
        /// The description of the domain.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the domain.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("domain_name")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies whether to enable the default drive feature. A value of true specifies that all users are assigned a drive by default on the first logon. Default value: false.
        /// </summary>
        [NameInMap("init_drive_enable")]
        [Validation(Required=false)]
        public bool? InitDriveEnable { get; set; }

        /// <summary>
        /// The size of the default drive. Unit: bytes. You must specify init_drive_size if you set init_drive_enable to true. Default value: 0. A value of 0 specifies that the size of the default drive is 0 bytes and you cannot upload files to the drive. To initialize the default drive, set init_drive_size to 0. A value of -1 specifies that the size is unlimited.
        /// </summary>
        [NameInMap("init_drive_size")]
        [Validation(Required=false)]
        public long? InitDriveSize { get; set; }

        /// <summary>
        /// The ID of the parent domain. If you want to create a child domain, specify parent_domain_id. In most cases, you do not need to create a child domain. If you want to perform secondary operations based on Drive and Photo Service, contact the customer service.
        /// </summary>
        [NameInMap("parent_domain_id")]
        [Validation(Required=false)]
        public string ParentDomainId { get; set; }

        /// <summary>
        /// The total storage quota for all drives in the domain. A value of 0 specifies that the quota is unlimited.
        /// </summary>
        [NameInMap("size_quota")]
        [Validation(Required=false)]
        public long? SizeQuota { get; set; }

        /// <summary>
        /// The largest number of users that can be created in the domain. A value of 0 specifies that the number is unlimited.
        /// </summary>
        [NameInMap("user_count_quota")]
        [Validation(Required=false)]
        public long? UserCountQuota { get; set; }

    }

}
