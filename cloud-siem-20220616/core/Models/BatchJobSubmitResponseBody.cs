// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class BatchJobSubmitResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchJobSubmitResponseBodyData Data { get; set; }
        public class BatchJobSubmitResponseBodyData : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            [NameInMap("ConfigList")]
            [Validation(Required=false)]
            public List<BatchJobSubmitResponseBodyDataConfigList> ConfigList { get; set; }
            public class BatchJobSubmitResponseBodyDataConfigList : TeaModel {
                [NameInMap("ProductList")]
                [Validation(Required=false)]
                public List<BatchJobSubmitResponseBodyDataConfigListProductList> ProductList { get; set; }
                public class BatchJobSubmitResponseBodyDataConfigListProductList : TeaModel {
                    [NameInMap("LogList")]
                    [Validation(Required=false)]
                    public List<BatchJobSubmitResponseBodyDataConfigListProductListLogList> LogList { get; set; }
                    public class BatchJobSubmitResponseBodyDataConfigListProductListLogList : TeaModel {
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        [NameInMap("LogCode")]
                        [Validation(Required=false)]
                        public string LogCode { get; set; }

                        [NameInMap("LogStoreNamePattern")]
                        [Validation(Required=false)]
                        public string LogStoreNamePattern { get; set; }

                        [NameInMap("ProductCode")]
                        [Validation(Required=false)]
                        public string ProductCode { get; set; }

                        [NameInMap("ProjectNamePattern")]
                        [Validation(Required=false)]
                        public string ProjectNamePattern { get; set; }

                        [NameInMap("RegionCode")]
                        [Validation(Required=false)]
                        public string RegionCode { get; set; }

                    }

                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

            }

            [NameInMap("SubmitId")]
            [Validation(Required=false)]
            public string SubmitId { get; set; }

            [NameInMap("TaskCount")]
            [Validation(Required=false)]
            public int? TaskCount { get; set; }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
