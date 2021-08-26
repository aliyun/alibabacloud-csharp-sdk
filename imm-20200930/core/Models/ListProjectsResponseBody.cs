// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListProjectsResponseBody : TeaModel {
        /// <summary>
        /// 当总结果个数大于MaxResults时，用于翻页的token
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 由ProjectItem组成的数组
        /// </summary>
        [NameInMap("Projects")]
        [Validation(Required=false)]
        public List<ListProjectsResponseBodyProjects> Projects { get; set; }
        public class ListProjectsResponseBodyProjects : TeaModel {
            /// <summary>
            /// 项目名称
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// 服务角色
            /// </summary>
            [NameInMap("ServiceRole")]
            [Validation(Required=false)]
            public string ServiceRole { get; set; }

            /// <summary>
            /// 工作流
            /// </summary>
            [NameInMap("Workflow")]
            [Validation(Required=false)]
            public string Workflow { get; set; }

            /// <summary>
            /// 项目描述
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 项目创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 项目上次修改时间
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// 项目QPS
            /// </summary>
            [NameInMap("ProjectQPS")]
            [Validation(Required=false)]
            public long? ProjectQPS { get; set; }

            /// <summary>
            /// 项目TPS
            /// </summary>
            [NameInMap("ProjectTPS")]
            [Validation(Required=false)]
            public long? ProjectTPS { get; set; }

            /// <summary>
            /// 最大媒体集数
            /// </summary>
            [NameInMap("ProjectMaxDatasetCount")]
            [Validation(Required=false)]
            public long? ProjectMaxDatasetCount { get; set; }

            /// <summary>
            /// 项目下每个媒体集最多绑定数
            /// </summary>
            [NameInMap("DatasetMaxOSSBindCount")]
            [Validation(Required=false)]
            public long? DatasetMaxOSSBindCount { get; set; }

            /// <summary>
            /// 项目下每个媒体集最大文件数量
            /// </summary>
            [NameInMap("DatasetMaxFileCount")]
            [Validation(Required=false)]
            public long? DatasetMaxFileCount { get; set; }

            /// <summary>
            /// 项目下每个媒体集最大实体数
            /// </summary>
            [NameInMap("DatasetMaxEntityCount")]
            [Validation(Required=false)]
            public long? DatasetMaxEntityCount { get; set; }

            /// <summary>
            /// 项目下每个媒体集最大关系数
            /// </summary>
            [NameInMap("DatasetMaxRelationCount")]
            [Validation(Required=false)]
            public long? DatasetMaxRelationCount { get; set; }

            /// <summary>
            /// 项目下每个媒体集最大文件总大小
            /// </summary>
            [NameInMap("DatasetMaxTotalFileSize")]
            [Validation(Required=false)]
            public long? DatasetMaxTotalFileSize { get; set; }

            /// <summary>
            /// 媒体集数量
            /// </summary>
            [NameInMap("DatasetCount")]
            [Validation(Required=false)]
            public long? DatasetCount { get; set; }

        }

        /// <summary>
        /// 本次请求的唯一 ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
