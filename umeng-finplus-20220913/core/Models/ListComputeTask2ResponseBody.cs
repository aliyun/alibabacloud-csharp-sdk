// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class ListComputeTask2ResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListComputeTask2ResponseBodyData Data { get; set; }
        public class ListComputeTask2ResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<ListComputeTask2ResponseBodyDataData> Data { get; set; }
            public class ListComputeTask2ResponseBodyDataData : TeaModel {
                [NameInMap("appId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                [NameInMap("bcId")]
                [Validation(Required=false)]
                public long? BcId { get; set; }

                [NameInMap("computeOssFileTitle")]
                [Validation(Required=false)]
                public string ComputeOssFileTitle { get; set; }

                [NameInMap("datasetIds")]
                [Validation(Required=false)]
                public string DatasetIds { get; set; }

                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public string ExtInfo { get; set; }

                [NameInMap("fileNum")]
                [Validation(Required=false)]
                public long? FileNum { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("remarks")]
                [Validation(Required=false)]
                public string Remarks { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("taskResultList")]
                [Validation(Required=false)]
                public List<ListComputeTask2ResponseBodyDataDataTaskResultList> TaskResultList { get; set; }
                public class ListComputeTask2ResponseBodyDataDataTaskResultList : TeaModel {
                    [NameInMap("bcId")]
                    [Validation(Required=false)]
                    public long? BcId { get; set; }

                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    [NameInMap("lineNum")]
                    [Validation(Required=false)]
                    public long? LineNum { get; set; }

                }

            }

            [NameInMap("totalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

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
