// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeMongoDBLogConfigResponseBody : TeaModel {
        [NameInMap("UserProjectName")]
        [Validation(Required=false)]
        public string UserProjectName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IsUserProjectLogstoreExist")]
        [Validation(Required=false)]
        public int? IsUserProjectLogstoreExist { get; set; }

        [NameInMap("IsEtlMetaExist")]
        [Validation(Required=false)]
        public int? IsEtlMetaExist { get; set; }

    }

}
