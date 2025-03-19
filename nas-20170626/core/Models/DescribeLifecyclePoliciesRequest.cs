// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeLifecyclePoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        [NameInMap("FsetId")]
        [Validation(Required=false)]
        public string FsetId { get; set; }

        /// <summary>
        /// <para>The name of the lifecycle policy. The name must meet the following conventions:</para>
        /// <para>The name must be 3 to 64 characters in length and must start with a letter. It can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>lifecyclepolicy_01</para>
        /// </summary>
        [NameInMap("LifecyclePolicyName")]
        [Validation(Required=false)]
        public string LifecyclePolicyName { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The storage class.</para>
        /// <list type="bullet">
        /// <item><description>InfrequentAccess: the Infrequent Access (IA) storage class.</description></item>
        /// <item><description>Archive: the Archive storage class.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the StorageType parameter is not specified, data retrieval tasks of all types are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>InfrequentAccess</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
