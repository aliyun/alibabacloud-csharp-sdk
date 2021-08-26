// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// 项目名称
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 项目描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 服务角色
        /// </summary>
        [NameInMap("ServiceRole")]
        [Validation(Required=false)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// 工作流
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 项目创建时间
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 项目修改时间
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
        /// 最大媒体集数量
        /// </summary>
        [NameInMap("ProjectMaxDatasetCount")]
        [Validation(Required=false)]
        public long? ProjectMaxDatasetCount { get; set; }

        /// <summary>
        /// 当前项目每个媒体集最大绑定数
        /// </summary>
        [NameInMap("DatasetMaxOSSBindCount")]
        [Validation(Required=false)]
        public long? DatasetMaxOSSBindCount { get; set; }

        /// <summary>
        /// 当前项目每个媒体集最大文件数
        /// </summary>
        [NameInMap("DatasetMaxFileCount")]
        [Validation(Required=false)]
        public long? DatasetMaxFileCount { get; set; }

        /// <summary>
        /// 当前项目每个媒体集最大实体数
        /// </summary>
        [NameInMap("DatasetMaxEntityCount")]
        [Validation(Required=false)]
        public long? DatasetMaxEntityCount { get; set; }

        /// <summary>
        /// 当前项目每个媒体集最大关系数
        /// </summary>
        [NameInMap("DatasetMaxRelationCount")]
        [Validation(Required=false)]
        public long? DatasetMaxRelationCount { get; set; }

        /// <summary>
        /// 当前项目每个媒体集最大文件总大小
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

        /// <summary>
        /// 项目当前文件数量
        /// </summary>
        [NameInMap("FileCount")]
        [Validation(Required=false)]
        public long? FileCount { get; set; }

        /// <summary>
        /// 项目当前文件总大小
        /// </summary>
        [NameInMap("TotalFileSize")]
        [Validation(Required=false)]
        public long? TotalFileSize { get; set; }

        /// <summary>
        /// 本次请求的唯一 ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
