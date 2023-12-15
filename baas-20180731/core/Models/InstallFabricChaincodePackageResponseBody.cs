// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class InstallFabricChaincodePackageResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public InstallFabricChaincodePackageResponseBodyResult Result { get; set; }
        public class InstallFabricChaincodePackageResponseBodyResult : TeaModel {
            [NameInMap("ChaincodePackageId")]
            [Validation(Required=false)]
            public string ChaincodePackageId { get; set; }

            [NameInMap("Checksum")]
            [Validation(Required=false)]
            public string Checksum { get; set; }

            [NameInMap("DeleteTime")]
            [Validation(Required=false)]
            public long? DeleteTime { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("InstallTime")]
            [Validation(Required=false)]
            public long? InstallTime { get; set; }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("Md5sum")]
            [Validation(Required=false)]
            public string Md5sum { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            [NameInMap("OssURL")]
            [Validation(Required=false)]
            public string OssURL { get; set; }

            [NameInMap("ProviderBid")]
            [Validation(Required=false)]
            public string ProviderBid { get; set; }

            [NameInMap("ProviderUid")]
            [Validation(Required=false)]
            public long? ProviderUid { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public long? UploadTime { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
