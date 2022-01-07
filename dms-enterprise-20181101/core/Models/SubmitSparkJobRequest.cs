// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SubmitSparkJobRequest : TeaModel {
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        [NameInMap("Arguments")]
        [Validation(Required=false)]
        public List<string> Arguments { get; set; }

        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public Dictionary<string, object> Configuration { get; set; }

        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<string> Files { get; set; }

        [NameInMap("MainClass")]
        [Validation(Required=false)]
        public string MainClass { get; set; }

        [NameInMap("MainFile")]
        [Validation(Required=false)]
        public string MainFile { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OssInfo")]
        [Validation(Required=false)]
        public SubmitSparkJobRequestOssInfo OssInfo { get; set; }
        public class SubmitSparkJobRequestOssInfo : TeaModel {
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }
        };

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
