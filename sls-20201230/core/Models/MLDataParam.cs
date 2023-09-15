// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MLDataParam : TeaModel {
        [NameInMap("annotationdataId")]
        [Validation(Required=false)]
        public string AnnotationdataId { get; set; }

        [NameInMap("annotations")]
        [Validation(Required=false)]
        public Dictionary<string, MLDataParamAnnotationsValue> Annotations { get; set; }

        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, string> Config { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("dataHash")]
        [Validation(Required=false)]
        public string DataHash { get; set; }

        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        [NameInMap("predictions")]
        [Validation(Required=false)]
        public Dictionary<string, MLDataParamPredictionsValue> Predictions { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("valueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

    }

}
