// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeMongoDBLogConfigResponseBody : TeaModel {
        [NameInMap("EnableAudit")]
        [Validation(Required=false)]
        public bool? EnableAudit { get; set; }

        [NameInMap("IsEtlMetaExist")]
        [Validation(Required=false)]
        public int? IsEtlMetaExist { get; set; }

        [NameInMap("IsUserProjectLogstoreExist")]
        [Validation(Required=false)]
        public int? IsUserProjectLogstoreExist { get; set; }

        [NameInMap("PreserveStorageForStandard")]
        [Validation(Required=false)]
        public long? PreserveStorageForStandard { get; set; }

        [NameInMap("PreserveStorageForTrail")]
        [Validation(Required=false)]
        public long? PreserveStorageForTrail { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("TtlForStandard")]
        [Validation(Required=false)]
        public long? TtlForStandard { get; set; }

        [NameInMap("TtlForTrail")]
        [Validation(Required=false)]
        public long? TtlForTrail { get; set; }

        [NameInMap("UsedStorageForStandard")]
        [Validation(Required=false)]
        public long? UsedStorageForStandard { get; set; }

        [NameInMap("UsedStorageForTrail")]
        [Validation(Required=false)]
        public long? UsedStorageForTrail { get; set; }

        [NameInMap("UserProjectName")]
        [Validation(Required=false)]
        public string UserProjectName { get; set; }

    }

}
