// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Image_detect20211221.Models
{
    public class CreateTaskRequest : TeaModel {
        [NameInMap("Level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        [NameInMap("MqConfigName")]
        [Validation(Required=false)]
        public string MqConfigName { get; set; }

        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        [NameInMap("OssConfigName")]
        [Validation(Required=false)]
        public string OssConfigName { get; set; }

        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        [NameInMap("OssInputPath")]
        [Validation(Required=false)]
        public string OssInputPath { get; set; }

        [NameInMap("OssOutputPath")]
        [Validation(Required=false)]
        public string OssOutputPath { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("TaskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
