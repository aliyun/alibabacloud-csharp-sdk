// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSlbResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlbList")]
        [Validation(Required=false)]
        public ListSlbResponseBodySlbList SlbList { get; set; }
        public class ListSlbResponseBodySlbList : TeaModel {
            [NameInMap("SlbEntity")]
            [Validation(Required=false)]
            public List<ListSlbResponseBodySlbListSlbEntity> SlbEntity { get; set; }
            public class ListSlbResponseBodySlbListSlbEntity : TeaModel {
                public string Address { get; set; }
                public string AddressType { get; set; }
                public bool? Expired { get; set; }
                public int? GroupId { get; set; }
                public string NetworkType { get; set; }
                public string RegionId { get; set; }
                public string SlbId { get; set; }
                public string SlbName { get; set; }
                public string SlbStatus { get; set; }
                public string UserId { get; set; }
                public string VpcId { get; set; }
                public string VswitchId { get; set; }
            }
        };

    }

}
