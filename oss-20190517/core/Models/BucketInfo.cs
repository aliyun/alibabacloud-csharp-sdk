// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class BucketInfo : TeaModel {
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public BucketInfoBucket Bucket { get; set; }
        public class BucketInfoBucket : TeaModel {
            [NameInMap("AccessControlList")]
            [Validation(Required=false)]
            public AccessControlList AccessControlList { get; set; }

            [NameInMap("AccessMonitor")]
            [Validation(Required=false)]
            public string AccessMonitor { get; set; }

            [NameInMap("BucketPolicy")]
            [Validation(Required=false)]
            public LoggingEnabled BucketPolicy { get; set; }

            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }

            [NameInMap("CrossRegionReplication")]
            [Validation(Required=false)]
            public string CrossRegionReplication { get; set; }

            [NameInMap("DataRedundancyType")]
            [Validation(Required=false)]
            public string DataRedundancyType { get; set; }

            [NameInMap("ExtranetEndpoint")]
            [Validation(Required=false)]
            public string ExtranetEndpoint { get; set; }

            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public Owner Owner { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ServerSideEncryptionRule")]
            [Validation(Required=false)]
            public BucketInfoBucketServerSideEncryptionRule ServerSideEncryptionRule { get; set; }
            public class BucketInfoBucketServerSideEncryptionRule : TeaModel {
                [NameInMap("KMSDataEncryption")]
                [Validation(Required=false)]
                public string KMSDataEncryption { get; set; }

                [NameInMap("KMSMasterKeyID")]
                [Validation(Required=false)]
                public string KMSMasterKeyID { get; set; }

                [NameInMap("SSEAlgorithm")]
                [Validation(Required=false)]
                public string SSEAlgorithm { get; set; }

            }

            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            [NameInMap("TransferAcceleration")]
            [Validation(Required=false)]
            public string TransferAcceleration { get; set; }

            [NameInMap("Versioning")]
            [Validation(Required=false)]
            public string Versioning { get; set; }

        }

    }

}
