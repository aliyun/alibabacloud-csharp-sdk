// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListVpcResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VpcList")]
        [Validation(Required=false)]
        public ListVpcResponseBodyVpcList VpcList { get; set; }
        public class ListVpcResponseBodyVpcList : TeaModel {
            [NameInMap("VpcEntity")]
            [Validation(Required=false)]
            public List<ListVpcResponseBodyVpcListVpcEntity> VpcEntity { get; set; }
            public class ListVpcResponseBodyVpcListVpcEntity : TeaModel {
                public int? EcsNum { get; set; }
                public bool? Expired { get; set; }
                public string RegionId { get; set; }
                public string UserId { get; set; }
                public string VpcId { get; set; }
                public string VpcName { get; set; }
            }
        };

    }

}
