// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateDomainRequest : TeaModel {
        /// <summary>
        /// <para>The description of the domain.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The domain ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The name of the domain.</para>
        /// </summary>
        [NameInMap("domain_name")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the default drive feature. A value of true specifies that all users are assigned a drive by default on the first logon. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("init_drive_enable")]
        [Validation(Required=false)]
        public bool? InitDriveEnable { get; set; }

        /// <summary>
        /// <para>The size of the default drive. Unit: bytes. You must specify init_drive_size if you set init_drive_enable to true. Default value: 0. A value of 0 specifies that the size of the default drive is 0 bytes and you cannot upload files to the drive. To initialize the default drive, set init_drive_size to 0. A value of -1 specifies that the size is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1073741824</para>
        /// </summary>
        [NameInMap("init_drive_size")]
        [Validation(Required=false)]
        public long? InitDriveSize { get; set; }

        /// <summary>
        /// <para>The access policy of the application.</para>
        /// </summary>
        [NameInMap("published_app_access_strategy")]
        [Validation(Required=false)]
        public AppAccessStrategy PublishedAppAccessStrategy { get; set; }

        /// <summary>
        /// <para>The total storage quota for all drives in the domain. A value of 0 specifies that the quota is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1099511627776</para>
        /// </summary>
        [NameInMap("size_quota")]
        [Validation(Required=false)]
        public long? SizeQuota { get; set; }

        /// <summary>
        /// <para>The maximum number of users that can be created in the domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("user_count_quota")]
        [Validation(Required=false)]
        public long? UserCountQuota { get; set; }

    }

}
