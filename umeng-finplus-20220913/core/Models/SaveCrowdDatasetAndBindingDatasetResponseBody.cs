// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class SaveCrowdDatasetAndBindingDatasetResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SaveCrowdDatasetAndBindingDatasetResponseBodyData Data { get; set; }
        public class SaveCrowdDatasetAndBindingDatasetResponseBodyData : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("crowdDatasetId")]
            [Validation(Required=false)]
            public string CrowdDatasetId { get; set; }

            [NameInMap("datasetIds")]
            [Validation(Required=false)]
            public List<string> DatasetIds { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("uploadStatus")]
            [Validation(Required=false)]
            public string UploadStatus { get; set; }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
