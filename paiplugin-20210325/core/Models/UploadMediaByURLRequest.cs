// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20210325.Models
{
    public class UploadMediaByURLRequest : TeaModel {
        [NameInMap("UploadMetadatas")]
        [Validation(Required=false)]
        public List<UploadMediaByURLRequestUploadMetadatas> UploadMetadatas { get; set; }
        public class UploadMediaByURLRequestUploadMetadatas : TeaModel {
            [NameInMap("FileExtension")]
            [Validation(Required=false)]
            public string FileExtension { get; set; }

            [NameInMap("S3UploadInfo")]
            [Validation(Required=false)]
            public UploadMediaByURLRequestUploadMetadatasS3UploadInfo S3UploadInfo { get; set; }
            public class UploadMediaByURLRequestUploadMetadatasS3UploadInfo : TeaModel {
                [NameInMap("S3AccessKey")]
                [Validation(Required=false)]
                public string S3AccessKey { get; set; }
                [NameInMap("S3Bucket")]
                [Validation(Required=false)]
                public string S3Bucket { get; set; }
                [NameInMap("S3Endpoint")]
                [Validation(Required=false)]
                public string S3Endpoint { get; set; }
                [NameInMap("S3FileKey")]
                [Validation(Required=false)]
                public string S3FileKey { get; set; }
                [NameInMap("S3Provider")]
                [Validation(Required=false)]
                public string S3Provider { get; set; }
                [NameInMap("S3SecretKey")]
                [Validation(Required=false)]
                public string S3SecretKey { get; set; }
                [NameInMap("S3Token")]
                [Validation(Required=false)]
                public string S3Token { get; set; }
                [NameInMap("id")]
                [Validation(Required=false)]
                public int? Id { get; set; }
                [NameInMap("jobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }
            };

            [NameInMap("SourceURL")]
            [Validation(Required=false)]
            public string SourceURL { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("UploadURLs")]
        [Validation(Required=false)]
        public string UploadURLs { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public UploadMediaByURLRequestUserData UserData { get; set; }
        public class UploadMediaByURLRequestUserData : TeaModel {
            [NameInMap("Extend")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extend { get; set; }
            [NameInMap("MessageCallback")]
            [Validation(Required=false)]
            public string MessageCallback { get; set; }
        };

    }

}
