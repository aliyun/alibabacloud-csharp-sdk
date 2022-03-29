/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class BucketInfo : TeaModel {
        /// <summary>
        /// Bucket读写权限类型： public-read-write：公共读写 public-read：公共读 private：私有（默认值）
        /// </summary>
        [NameInMap("BucketAcl")]
        [Validation(Required=false)]
        public string BucketAcl { get; set; }

        /// <summary>
        /// Bucket名称。 3~50 个字符，只允许小写字母、数字、短横线（-），且不能以短横线开头或结尾。
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// 备注。 1-128个字符或汉字，UTF-8编码。
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Bucket创建时间。 （格式：yyyy-mm-ddThh:mm:ss.timezone, 例如 2011-12-01T12:27:13.000Z）
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 指定Bucket的数据容灾类型。 取值范围： LRS（默认值）。本地冗余LRS ZRS 同城冗余ZRS采用多可用区（AZ）机制。
        /// </summary>
        [NameInMap("DataRedundancyType")]
        [Validation(Required=false)]
        public string DataRedundancyType { get; set; }

        /// <summary>
        /// Bucket的调度类型： node：节点(同城) area：区域(多城市) global：全局(全国)
        /// </summary>
        [NameInMap("DispatcherType")]
        [Validation(Required=false)]
        public string DispatcherType { get; set; }

        /// <summary>
        /// 访问域名，边缘存储取值： eos.aliyuncs.com
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// 节点区域id，如果为空表示全局
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// Bucket修改时间。 （格式：yyyy-mm-ddThh:mm:ss.timezone, 例如 2011-12-01T12:27:13.000Z）
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 指定Bucket的资源类型。 取值范围： general：通用 national-network：国网
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Bucket存储类型，支持Standard
        /// </summary>
        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

    }

}
