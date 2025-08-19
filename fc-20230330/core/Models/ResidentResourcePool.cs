// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ResidentResourcePool : TeaModel {
        /// <summary>
        /// <para>资源池实时分配情况，包含每个函数的具体分配情况</para>
        /// </summary>
        [NameInMap("allocationStatus")]
        [Validation(Required=false)]
        public ResidentResourceAllocationStatus AllocationStatus { get; set; }

        /// <summary>
        /// <para>代表创建时间的资源属性字段</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>资源池过期时间</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>上次修改时间，包含扩容、续费、更名等操作</para>
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("residentResourcePoolId")]
        [Validation(Required=false)]
        public string ResidentResourcePoolId { get; set; }

        /// <summary>
        /// <para>代表资源名称的资源属性字段</para>
        /// </summary>
        [NameInMap("residentResourcePoolName")]
        [Validation(Required=false)]
        public string ResidentResourcePoolName { get; set; }

        /// <summary>
        /// <para>资源池总体规格</para>
        /// </summary>
        [NameInMap("resourcePoolCapacity")]
        [Validation(Required=false)]
        public ResidentResourceCapacity ResourcePoolCapacity { get; set; }

        [NameInMap("resourcePoolConfig")]
        [Validation(Required=false)]
        public ResidentResourceCapacity ResourcePoolConfig { get; set; }

    }

}
