// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Project : TeaModel {
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
        /// 创建时间
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 项目QPS
        /// </summary>
        [NameInMap("ProjectQueriesPerSecond")]
        [Validation(Required=false)]
        public long? ProjectQueriesPerSecond { get; set; }

        /// <summary>
        /// 项目最大并发数
        /// </summary>
        [NameInMap("EngineConcurrency")]
        [Validation(Required=false)]
        public long? EngineConcurrency { get; set; }

        /// <summary>
        /// 项目最多媒体集数量
        /// </summary>
        [NameInMap("ProjectMaxDatasetCount")]
        [Validation(Required=false)]
        public long? ProjectMaxDatasetCount { get; set; }

        /// <summary>
        /// 项目最多绑定数
        /// </summary>
        [NameInMap("DatasetMaxBindCount")]
        [Validation(Required=false)]
        public long? DatasetMaxBindCount { get; set; }

        /// <summary>
        /// 项目最多文件数
        /// </summary>
        [NameInMap("DatasetMaxFileCount")]
        [Validation(Required=false)]
        public long? DatasetMaxFileCount { get; set; }

        /// <summary>
        /// 项目最多实体数
        /// </summary>
        [NameInMap("DatasetMaxEntityCount")]
        [Validation(Required=false)]
        public long? DatasetMaxEntityCount { get; set; }

        /// <summary>
        /// 项目最多关系数
        /// </summary>
        [NameInMap("DatasetMaxRelationCount")]
        [Validation(Required=false)]
        public long? DatasetMaxRelationCount { get; set; }

        /// <summary>
        /// 项目最大文件总大小
        /// </summary>
        [NameInMap("DatasetMaxTotalFileSize")]
        [Validation(Required=false)]
        public long? DatasetMaxTotalFileSize { get; set; }

        /// <summary>
        /// 项目当前媒体集数
        /// </summary>
        [NameInMap("DatasetCount")]
        [Validation(Required=false)]
        public long? DatasetCount { get; set; }

        /// <summary>
        /// 项目当前文件数
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

    }

}
