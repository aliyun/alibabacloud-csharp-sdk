// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateDomainRequest : TeaModel {
        /// <summary>
        /// <para>The description of the domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud drive dev</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud drive</para>
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
        /// <para>This parameter is required when the init_drive_enable is set to true. The size of the default drive. Unit: bytes. The default is 0, meaning the created drive size is 0, and files cannot be uploaded. If you need to initialize the drive, set this value. A value of -1 indicates that the size is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1073741824</para>
        /// </summary>
        [NameInMap("init_drive_size")]
        [Validation(Required=false)]
        public long? InitDriveSize { get; set; }

        /// <summary>
        /// <para>The ID of the parent domain. If you want to create a child domain, specify parent_domain_id. In most cases, you do not need to create a child domain. If you want to perform secondary operations based on Drive and Photo Service, contact the customer service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("parent_domain_id")]
        [Validation(Required=false)]
        public string ParentDomainId { get; set; }

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
        /// <para>Specifies the storage redundancy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LRS: locally redundant storage</description></item>
        /// <item><description>ZRS: zone-redundant storage</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LRS</para>
        /// </summary>
        [NameInMap("store_redundancy_type")]
        [Validation(Required=false)]
        public string StoreRedundancyType { get; set; }

        /// <summary>
        /// <para>The largest number of users that can be created in the domain. A value of 0 specifies that the number is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("user_count_quota")]
        [Validation(Required=false)]
        public long? UserCountQuota { get; set; }

    }

}
