// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListHostGroupsResponseBody : TeaModel {
        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// true 接口调用成功，false 接口调用失败
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 主机组
        /// </summary>
        [NameInMap("hostGroups")]
        [Validation(Required=false)]
        public List<ListHostGroupsResponseBodyHostGroups> HostGroups { get; set; }
        public class ListHostGroupsResponseBodyHostGroups : TeaModel {
            /// <summary>
            /// 创建人阿里云账号id
            /// </summary>
            [NameInMap("creatorAccountId")]
            [Validation(Required=false)]
            public string CreatorAccountId { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// 主机个数
            /// </summary>
            [NameInMap("hostNum")]
            [Validation(Required=false)]
            public long? HostNum { get; set; }

            /// <summary>
            /// 修改人阿里云账号id
            /// </summary>
            [NameInMap("modifierAccountId")]
            [Validation(Required=false)]
            public string ModifierAccountId { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 类型
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 主机时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 主机类型
            /// </summary>
            [NameInMap("ecsType")]
            [Validation(Required=false)]
            public string EcsType { get; set; }

            /// <summary>
            /// 阿里云区域
            /// </summary>
            [NameInMap("aliyunRegion")]
            [Validation(Required=false)]
            public string AliyunRegion { get; set; }

            /// <summary>
            /// ecs标签Key
            /// </summary>
            [NameInMap("ecsLabelKey")]
            [Validation(Required=false)]
            public string EcsLabelKey { get; set; }

            /// <summary>
            /// 部署组名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 323232
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 服务连接Id
            /// </summary>
            [NameInMap("serviceConnectionId")]
            [Validation(Required=false)]
            public long? ServiceConnectionId { get; set; }

            /// <summary>
            /// Ecs标签值
            /// </summary>
            [NameInMap("ecsLabelValue")]
            [Validation(Required=false)]
            public string EcsLabelValue { get; set; }

        }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 分页token,空表示最后一页
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
