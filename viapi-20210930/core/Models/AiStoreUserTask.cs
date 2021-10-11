/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi20210930.Models
{
    public class AiStoreUserTask : TeaModel {
        /// <summary>
        /// ID
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// 地域描述
        /// </summary>
        [NameInMap("RegionDesc")]
        [Validation(Required=false)]
        public string RegionDesc { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        [NameInMap("ProductDesc")]
        [Validation(Required=false)]
        public string ProductDesc { get; set; }

        /// <summary>
        /// API名称
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// API描述
        /// </summary>
        [NameInMap("ApiDesc")]
        [Validation(Required=false)]
        public string ApiDesc { get; set; }

        /// <summary>
        /// API版本
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// 参数信息
        /// </summary>
        [NameInMap("ParamInfo")]
        [Validation(Required=false)]
        public string ParamInfo { get; set; }

        /// <summary>
        /// bucket名称
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// bucketKey前缀
        /// </summary>
        [NameInMap("BucketKeyPrefix")]
        [Validation(Required=false)]
        public string BucketKeyPrefix { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 接收消息配置
        /// </summary>
        [NameInMap("ReceiveConfig")]
        [Validation(Required=false)]
        public string ReceiveConfig { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 启用时间
        /// </summary>
        [NameInMap("EnableTime")]
        [Validation(Required=false)]
        public string EnableTime { get; set; }

        /// <summary>
        /// 停用时间
        /// </summary>
        [NameInMap("DisableTime")]
        [Validation(Required=false)]
        public string DisableTime { get; set; }

    }

}
