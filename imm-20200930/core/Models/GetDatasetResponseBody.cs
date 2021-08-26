// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetDatasetResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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

        [NameInMap("BindCount")]
        [Validation(Required=false)]
        public long? BindCount { get; set; }

        [NameInMap("FileCount")]
        [Validation(Required=false)]
        public long? FileCount { get; set; }

        [NameInMap("TotalFileSize")]
        [Validation(Required=false)]
        public long? TotalFileSize { get; set; }

    }

}
