// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormV2StreamEngineInfoResponseBody : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupList")]
        [Validation(Required=false)]
        public List<GetLindormV2StreamEngineInfoResponseBodyResourceGroupList> ResourceGroupList { get; set; }
        public class GetLindormV2StreamEngineInfoResponseBodyResourceGroupList : TeaModel {
            [NameInMap("JmIpList")]
            [Validation(Required=false)]
            public List<string> JmIpList { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            [NameInMap("SgIpList")]
            [Validation(Required=false)]
            public List<string> SgIpList { get; set; }

            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            [NameInMap("SpecId")]
            [Validation(Required=false)]
            public string SpecId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
