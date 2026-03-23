// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeKmsAssociateResourcesResponseBody : TeaModel {
        [NameInMap("AssociateDBInstances")]
        [Validation(Required=false)]
        public List<DescribeKmsAssociateResourcesResponseBodyAssociateDBInstances> AssociateDBInstances { get; set; }
        public class DescribeKmsAssociateResourcesResponseBodyAssociateDBInstances : TeaModel {
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("KeyUsedBy")]
            [Validation(Required=false)]
            public string KeyUsedBy { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("AssociateStatus")]
        [Validation(Required=false)]
        public bool? AssociateStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
