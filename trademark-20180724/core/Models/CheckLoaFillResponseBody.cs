// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class CheckLoaFillResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckLoaFillResponseBodyData Data { get; set; }
        public class CheckLoaFillResponseBodyData : TeaModel {
            [NameInMap("AddressFill")]
            [Validation(Required=false)]
            public bool? AddressFill { get; set; }

            [NameInMap("CountryFill")]
            [Validation(Required=false)]
            public bool? CountryFill { get; set; }

            [NameInMap("ErrorMsgs")]
            [Validation(Required=false)]
            public CheckLoaFillResponseBodyDataErrorMsgs ErrorMsgs { get; set; }
            public class CheckLoaFillResponseBodyDataErrorMsgs : TeaModel {
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public List<string> ErrorMsg { get; set; }

            }

            [NameInMap("MaterialNameFill")]
            [Validation(Required=false)]
            public bool? MaterialNameFill { get; set; }

            [NameInMap("NationalityFill")]
            [Validation(Required=false)]
            public bool? NationalityFill { get; set; }

            [NameInMap("StampFill")]
            [Validation(Required=false)]
            public bool? StampFill { get; set; }

            [NameInMap("TemplateUrl")]
            [Validation(Required=false)]
            public string TemplateUrl { get; set; }

            [NameInMap("Tips")]
            [Validation(Required=false)]
            public string Tips { get; set; }

            [NameInMap("TradeMarkNameFill")]
            [Validation(Required=false)]
            public bool? TradeMarkNameFill { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
