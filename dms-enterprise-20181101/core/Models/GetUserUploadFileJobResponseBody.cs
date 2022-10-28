// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetUserUploadFileJobResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("UploadFileJobDetail")]
        [Validation(Required=false)]
        public GetUserUploadFileJobResponseBodyUploadFileJobDetail UploadFileJobDetail { get; set; }
        public class GetUserUploadFileJobResponseBodyUploadFileJobDetail : TeaModel {
            [NameInMap("AttachmentKey")]
            [Validation(Required=false)]
            public string AttachmentKey { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("FileSource")]
            [Validation(Required=false)]
            public string FileSource { get; set; }

            [NameInMap("JobKey")]
            [Validation(Required=false)]
            public string JobKey { get; set; }

            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            [NameInMap("JobStatusDesc")]
            [Validation(Required=false)]
            public string JobStatusDesc { get; set; }

            [NameInMap("UploadOSSParam")]
            [Validation(Required=false)]
            public GetUserUploadFileJobResponseBodyUploadFileJobDetailUploadOSSParam UploadOSSParam { get; set; }
            public class GetUserUploadFileJobResponseBodyUploadFileJobDetailUploadOSSParam : TeaModel {
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

            }

            [NameInMap("UploadType")]
            [Validation(Required=false)]
            public string UploadType { get; set; }

            [NameInMap("UploadURL")]
            [Validation(Required=false)]
            public string UploadURL { get; set; }

            [NameInMap("UploadedSize")]
            [Validation(Required=false)]
            public long? UploadedSize { get; set; }

        }

    }

}
