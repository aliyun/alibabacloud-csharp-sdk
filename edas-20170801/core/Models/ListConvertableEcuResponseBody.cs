// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListConvertableEcuResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public ListConvertableEcuResponseBodyInstanceList InstanceList { get; set; }
        public class ListConvertableEcuResponseBodyInstanceList : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<ListConvertableEcuResponseBodyInstanceListInstance> Instance { get; set; }
            public class ListConvertableEcuResponseBodyInstanceListInstance : TeaModel {
                public int? Cpu { get; set; }
                public string EcuId { get; set; }
                public string Eip { get; set; }
                public bool? Expired { get; set; }
                public string InnerIp { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public int? Mem { get; set; }
                public string PrivateIp { get; set; }
                public string PublicIp { get; set; }
                public string RegionId { get; set; }
                public string Status { get; set; }
                public string VpcId { get; set; }
                public string VpcName { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
