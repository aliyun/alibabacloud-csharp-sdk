// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class MapFromHavanaBindIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<MapFromHavanaBindIdResponseBodyData> Data { get; set; }
        public class MapFromHavanaBindIdResponseBodyData : TeaModel {
            [NameInMap("BindHid")]
            [Validation(Required=false)]
            public string BindHid { get; set; }

            [NameInMap("HavanaBindId")]
            [Validation(Required=false)]
            public string HavanaBindId { get; set; }

            [NameInMap("HavanaBindStation")]
            [Validation(Required=false)]
            public string HavanaBindStation { get; set; }

            [NameInMap("Pk")]
            [Validation(Required=false)]
            public string Pk { get; set; }

        }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
