// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetMultiRateConfigListResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("GroupInfo")]
        [Validation(Required=false)]
        public GetMultiRateConfigListResponseBodyGroupInfo GroupInfo { get; set; }
        public class GetMultiRateConfigListResponseBodyGroupInfo : TeaModel {
            [NameInMap("Info")]
            [Validation(Required=false)]
            public List<GetMultiRateConfigListResponseBodyGroupInfoInfo> Info { get; set; }
            public class GetMultiRateConfigListResponseBodyGroupInfoInfo : TeaModel {
                public string GroupId { get; set; }
                public string App { get; set; }
                public string AvFormat { get; set; }
                public int? Count { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
