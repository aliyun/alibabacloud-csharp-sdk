// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class SelectComputeTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SelectComputeTaskResponseBodyData Data { get; set; }
        public class SelectComputeTaskResponseBodyData : TeaModel {
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

            [NameInMap("exportOssFileList")]
            [Validation(Required=false)]
            public List<SelectComputeTaskResponseBodyDataExportOssFileList> ExportOssFileList { get; set; }
            public class SelectComputeTaskResponseBodyDataExportOssFileList : TeaModel {
                [NameInMap("downLoadUrl")]
                [Validation(Required=false)]
                public string DownLoadUrl { get; set; }

                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

            }

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
            public List<SelectComputeTaskResponseBodyDataTaskResultList> TaskResultList { get; set; }
            public class SelectComputeTaskResponseBodyDataTaskResultList : TeaModel {
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
