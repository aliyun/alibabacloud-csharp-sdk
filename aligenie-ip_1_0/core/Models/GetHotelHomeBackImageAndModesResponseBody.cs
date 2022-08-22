// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetHotelHomeBackImageAndModesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetHotelHomeBackImageAndModesResponseBodyResult Result { get; set; }
        public class GetHotelHomeBackImageAndModesResponseBodyResult : TeaModel {
            [NameInMap("BackgroundImage")]
            [Validation(Required=false)]
            public string BackgroundImage { get; set; }
            [NameInMap("HotelName")]
            [Validation(Required=false)]
            public string HotelName { get; set; }
            [NameInMap("ModeList")]
            [Validation(Required=false)]
            public List<GetHotelHomeBackImageAndModesResponseBodyResultModeList> ModeList { get; set; }
            public class GetHotelHomeBackImageAndModesResponseBodyResultModeList : TeaModel {
                public string CnName { get; set; }
                public string Code { get; set; }
                public string Icon { get; set; }
            }
        };

    }

}
