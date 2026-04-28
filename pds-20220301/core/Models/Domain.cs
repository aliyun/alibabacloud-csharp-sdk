// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Domain : TeaModel {
        /// <summary>
        /// <para>The time when the domain was created. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The method used to calculate the hash value of the data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha1</para>
        /// </summary>
        [NameInMap("data_hash_name")]
        [Validation(Required=false)]
        public string DataHashName { get; set; }

        /// <summary>
        /// <para>The description of the domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my domain</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>domain ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj2</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The name of the domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdsdomain</para>
        /// </summary>
        [NameInMap("domain_name")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the default drive feature. Valid values: true and false. A value of true specifies that all users are assigned a drive by default on the first logon. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("init_drive_enable")]
        [Validation(Required=false)]
        public bool? InitDriveEnable { get; set; }

        /// <summary>
        /// <para>The size of the default drive. Unit: bytes. This parameter is required if you set init_drive_enable to true. Default value: 0. A value of 0 indicates that the size of the default drive is 0 byte and you cannot upload files to the drive. To initialize the default drive, set init_drive_size to a positive number or -1. A value of -1 indicates that the size is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1073741824</para>
        /// </summary>
        [NameInMap("init_drive_size")]
        [Validation(Required=false)]
        public long? InitDriveSize { get; set; }

        /// <summary>
        /// <para>The ID of the parent domain. If the parent domain exists, the current domain is a child domain. Otherwise, the current domain is a common domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("parent_domain_id")]
        [Validation(Required=false)]
        public string ParentDomainId { get; set; }

        /// <summary>
        /// <para>The access policy of the application.</para>
        /// </summary>
        [NameInMap("published_app_access_strategy")]
        [Validation(Required=false)]
        public AppAccessStrategy PublishedAppAccessStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable sharing.</para>
        /// </summary>
        [NameInMap("sharable")]
        [Validation(Required=false)]
        public bool? Sharable { get; set; }

        /// <summary>
        /// <para>The total storage quota for all drives in the domain. A value of 0 indicates that the quota is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1099511627776</para>
        /// </summary>
        [NameInMap("size_quota")]
        [Validation(Required=false)]
        public long? SizeQuota { get; set; }

        /// <summary>
        /// <para>The used storage quota of all drives in the domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1099511627776</para>
        /// </summary>
        [NameInMap("size_quota_used")]
        [Validation(Required=false)]
        public long? SizeQuotaUsed { get; set; }

        /// <summary>
        /// <para>The status of the domain. 1: The domain runs normally. 2: The domain is being created. 6: The domain has expired.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LRS</para>
        /// </summary>
        [NameInMap("store_redundancy_type")]
        [Validation(Required=false)]
        public string StoreRedundancyType { get; set; }

        /// <summary>
        /// <para>The time when the domain was last modified. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The usage of the logic space. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1099511627776</para>
        /// </summary>
        [NameInMap("used_size")]
        [Validation(Required=false)]
        public long? UsedSize { get; set; }

        /// <summary>
        /// <para>The maximum allowed number of users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("user_count_quota")]
        [Validation(Required=false)]
        public long? UserCountQuota { get; set; }

    }

}
