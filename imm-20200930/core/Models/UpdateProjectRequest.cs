// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class UpdateProjectRequest : TeaModel {
        /// <summary>
        /// 媒体集最多绑定数
        /// </summary>
        [NameInMap("DatasetMaxBindCount")]
        [Validation(Required=false)]
        public long? DatasetMaxBindCount { get; set; }

        /// <summary>
        /// 媒体集最多实体数
        /// </summary>
        [NameInMap("DatasetMaxEntityCount")]
        [Validation(Required=false)]
        public long? DatasetMaxEntityCount { get; set; }

        /// <summary>
        /// 媒体集最多文件数
        /// </summary>
        [NameInMap("DatasetMaxFileCount")]
        [Validation(Required=false)]
        public long? DatasetMaxFileCount { get; set; }

        /// <summary>
        /// 媒体集最多关系数
        /// </summary>
        [NameInMap("DatasetMaxRelationCount")]
        [Validation(Required=false)]
        public long? DatasetMaxRelationCount { get; set; }

        /// <summary>
        /// 媒体集最大文件总大小
        /// </summary>
        [NameInMap("DatasetMaxTotalFileSize")]
        [Validation(Required=false)]
        public long? DatasetMaxTotalFileSize { get; set; }

        /// <summary>
        /// 项目描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 项目并发数
        /// </summary>
        [NameInMap("EngineConcurrency")]
        [Validation(Required=false)]
        public long? EngineConcurrency { get; set; }

        /// <summary>
        /// 项目最多媒体集数
        /// </summary>
        [NameInMap("ProjectMaxDatasetCount")]
        [Validation(Required=false)]
        public long? ProjectMaxDatasetCount { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 项目QPS
        /// </summary>
        [NameInMap("ProjectQueriesPerSecond")]
        [Validation(Required=false)]
        public long? ProjectQueriesPerSecond { get; set; }

        /// <summary>
        /// 服务角色
        /// </summary>
        [NameInMap("ServiceRole")]
        [Validation(Required=false)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// 模板Id
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
