// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDictInformationRequest : TeaModel {
        [NameInMap("analyzerType")]
        [Validation(Required=false)]
        public string AnalyzerType { get; set; }

        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

    }

}
