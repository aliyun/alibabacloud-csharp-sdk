// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ots20160620.Models
{
    public class ListVpcInfoByVpcResponseBody : TeaModel {
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("VpcInfos")]
        [Validation(Required=false)]
        public ListVpcInfoByVpcResponseBodyVpcInfos VpcInfos { get; set; }
        public class ListVpcInfoByVpcResponseBodyVpcInfos : TeaModel {
            [NameInMap("VpcInfo")]
            [Validation(Required=false)]
            public List<ListVpcInfoByVpcResponseBodyVpcInfosVpcInfo> VpcInfo { get; set; }
            public class ListVpcInfoByVpcResponseBodyVpcInfosVpcInfo : TeaModel {
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstanceVpcName")]
                [Validation(Required=false)]
                public string InstanceVpcName { get; set; }

                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

        }

    }

}
