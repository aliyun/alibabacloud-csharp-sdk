// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryLocalFileUploadJobResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryLocalFileUploadJobResponseBodyData Data { get; set; }
        public class QueryLocalFileUploadJobResponseBodyData : TeaModel {
            [NameInMap("ResultList")]
            [Validation(Required=false)]
            public List<QueryLocalFileUploadJobResponseBodyDataResultList> ResultList { get; set; }
            public class QueryLocalFileUploadJobResponseBodyDataResultList : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("FileList")]
                [Validation(Required=false)]
                public List<QueryLocalFileUploadJobResponseBodyDataResultListFileList> FileList { get; set; }
                public class QueryLocalFileUploadJobResponseBodyDataResultListFileList : TeaModel {
                    [NameInMap("FileEndTime")]
                    [Validation(Required=false)]
                    public int? FileEndTime { get; set; }

                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("FileStartTime")]
                    [Validation(Required=false)]
                    public int? FileStartTime { get; set; }

                }

                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                [NameInMap("SlotEndTime")]
                [Validation(Required=false)]
                public int? SlotEndTime { get; set; }

                [NameInMap("SlotStartTime")]
                [Validation(Required=false)]
                public int? SlotStartTime { get; set; }

                [NameInMap("SlotStatus")]
                [Validation(Required=false)]
                public int? SlotStatus { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
