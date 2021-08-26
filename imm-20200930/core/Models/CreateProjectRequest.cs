// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateProjectRequest : TeaModel {
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

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("ProjectQPS")]
        [Validation(Required=false)]
        public long? ProjectQPS { get; set; }

        [NameInMap("ProjectTPS")]
        [Validation(Required=false)]
        public long? ProjectTPS { get; set; }

        [NameInMap("ProjectMaxDatasetCount")]
        [Validation(Required=false)]
        public long? ProjectMaxDatasetCount { get; set; }

        [NameInMap("DatasetMaxOSSBindCount")]
        [Validation(Required=false)]
        public long? DatasetMaxOSSBindCount { get; set; }

        [NameInMap("DatasetMaxFileCount")]
        [Validation(Required=false)]
        public long? DatasetMaxFileCount { get; set; }

        [NameInMap("DatasetMaxEntityCount")]
        [Validation(Required=false)]
        public long? DatasetMaxEntityCount { get; set; }

        [NameInMap("DatasetMaxRelationCount")]
        [Validation(Required=false)]
        public long? DatasetMaxRelationCount { get; set; }

        [NameInMap("DatasetMaxTotalFileSize")]
        [Validation(Required=false)]
        public long? DatasetMaxTotalFileSize { get; set; }

    }

}
