// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class StatisListSceneInfoResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// 是否请求成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 返回集合
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<StatisListSceneInfoResponseBodyList> List { get; set; }
        public class StatisListSceneInfoResponseBodyList : TeaModel {
            /// <summary>
            /// 0：默认类型(增加type字段时默认值) 1：3D模型 2：全景图片3：全景视频
            /// </summary>
            [NameInMap("SceneType")]
            [Validation(Required=false)]
            public int? SceneType { get; set; }

            /// <summary>
            /// 发布时间到秒
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// 主场景名称
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// 资源数量
            /// </summary>
            [NameInMap("ResCount")]
            [Validation(Required=false)]
            public int? ResCount { get; set; }

            /// <summary>
            /// 项目名称
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// 计费量
            /// </summary>
            [NameInMap("MeasureCount")]
            [Validation(Required=false)]
            public int? MeasureCount { get; set; }

            /// <summary>
            /// statustinyin是否已发布 0:未发布 1：已发布
            /// </summary>
            [NameInMap("PublishStatus")]
            [Validation(Required=false)]
            public long? PublishStatus { get; set; }

            /// <summary>
            /// 主场景创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 主场景id
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public long? SceneId { get; set; }

            /// <summary>
            /// 项目Id
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// 页码
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// 一页显示数量
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
