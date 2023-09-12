// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class ListAppsResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAppsResponseBodyResult> Result { get; set; }
        public class ListAppsResponseBodyResult : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

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

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

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

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
