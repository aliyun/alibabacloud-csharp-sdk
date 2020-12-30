// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iqa20190813.Models
{
    public class DescribeProjectResponseBody : TeaModel {
        [NameInMap("QuestionCount")]
        [Validation(Required=false)]
        public int? QuestionCount { get; set; }

        [NameInMap("DeployAvailable")]
        [Validation(Required=false)]
        public string DeployAvailable { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("OnlineServiceStatus")]
        [Validation(Required=false)]
        public string OnlineServiceStatus { get; set; }

        [NameInMap("DeployTime")]
        [Validation(Required=false)]
        public long? DeployTime { get; set; }

        [NameInMap("ProjectType")]
        [Validation(Required=false)]
        public string ProjectType { get; set; }

        [NameInMap("DataStatus")]
        [Validation(Required=false)]
        public string DataStatus { get; set; }

        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("TestServiceStatus")]
        [Validation(Required=false)]
        public string TestServiceStatus { get; set; }

    }

}
