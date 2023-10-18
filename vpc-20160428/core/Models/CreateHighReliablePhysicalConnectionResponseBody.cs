// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateHighReliablePhysicalConnectionResponseBody : TeaModel {
        [NameInMap("ErrorInfoList")]
        [Validation(Required=false)]
        public CreateHighReliablePhysicalConnectionResponseBodyErrorInfoList ErrorInfoList { get; set; }
        public class CreateHighReliablePhysicalConnectionResponseBodyErrorInfoList : TeaModel {
            [NameInMap("errorInfoList")]
            [Validation(Required=false)]
            public List<CreateHighReliablePhysicalConnectionResponseBodyErrorInfoListErrorInfoList> ErrorInfoList { get; set; }
            public class CreateHighReliablePhysicalConnectionResponseBodyErrorInfoListErrorInfoList : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        [NameInMap("PhysicalConnectionList")]
        [Validation(Required=false)]
        public CreateHighReliablePhysicalConnectionResponseBodyPhysicalConnectionList PhysicalConnectionList { get; set; }
        public class CreateHighReliablePhysicalConnectionResponseBodyPhysicalConnectionList : TeaModel {
            [NameInMap("physicalConnectionList")]
            [Validation(Required=false)]
            public List<CreateHighReliablePhysicalConnectionResponseBodyPhysicalConnectionListPhysicalConnectionList> PhysicalConnectionList { get; set; }
            public class CreateHighReliablePhysicalConnectionResponseBodyPhysicalConnectionListPhysicalConnectionList : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
