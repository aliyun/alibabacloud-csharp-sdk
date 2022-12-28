// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20220822.Models
{
    public class GetAppResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAppResponseBodyResult Result { get; set; }
        public class GetAppResponseBodyResult : TeaModel {
            /// <summary>
            /// 代表资源名称的资源属性字段
            /// </summary>
            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// 代表创建时间的资源属性字段
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 应用备注
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 流量限流额
            /// </summary>
            [NameInMap("flowQuota")]
            [Validation(Required=false)]
            public string FlowQuota { get; set; }

            /// <summary>
            /// OwnerID账号ID
            /// </summary>
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// 代表region的资源属性字段
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// 代表资源状态的资源属性字段
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 存储限流额
            /// </summary>
            [NameInMap("storageQuota")]
            [Validation(Required=false)]
            public string StorageQuota { get; set; }

        }

    }

}
