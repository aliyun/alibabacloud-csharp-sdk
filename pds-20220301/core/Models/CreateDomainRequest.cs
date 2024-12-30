// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateDomainRequest : TeaModel {
        /// <summary>
        /// <para>domain 描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>你好企业网盘开发环境</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>If you want to perform secondary operations based on Drive and Photo Service and perform fine-grained control on your tenants, you can use the parent-child domain feature of Drive and Photo Service. For more information, join the DingTalk group whose ID is 23146118.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>你好企业网盘</para>
        /// </summary>
        [NameInMap("domain_name")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>https</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("init_drive_enable")]
        [Validation(Required=false)]
        public bool? InitDriveEnable { get; set; }

        /// <summary>
        /// <para>http</para>
        /// 
        /// <b>Example:</b>
        /// <para>1073741824</para>
        /// </summary>
        [NameInMap("init_drive_size")]
        [Validation(Required=false)]
        public long? InitDriveSize { get; set; }

        /// <summary>
        /// <para>Create domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("parent_domain_id")]
        [Validation(Required=false)]
        public string ParentDomainId { get; set; }

        /// <summary>
        /// <para>The ID of the parent domain. If you want to create a child domain, specify parent_domain_id. In most cases, you do not need to create a child domain. If you want to perform secondary operations based on Drive and Photo Service, contact the customer service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1099511627776</para>
        /// </summary>
        [NameInMap("size_quota")]
        [Validation(Required=false)]
        public long? SizeQuota { get; set; }

        /// <summary>
        /// <para>The information about the domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("user_count_quota")]
        [Validation(Required=false)]
        public long? UserCountQuota { get; set; }

    }

}
