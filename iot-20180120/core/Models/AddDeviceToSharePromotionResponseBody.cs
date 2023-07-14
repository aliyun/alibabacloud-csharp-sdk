// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class AddDeviceToSharePromotionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddDeviceToSharePromotionResponseBodyData Data { get; set; }
        public class AddDeviceToSharePromotionResponseBodyData : TeaModel {
            [NameInMap("FailDeviceSimpleInfoList")]
            [Validation(Required=false)]
            public AddDeviceToSharePromotionResponseBodyDataFailDeviceSimpleInfoList FailDeviceSimpleInfoList { get; set; }
            public class AddDeviceToSharePromotionResponseBodyDataFailDeviceSimpleInfoList : TeaModel {
                [NameInMap("item")]
                [Validation(Required=false)]
                public List<AddDeviceToSharePromotionResponseBodyDataFailDeviceSimpleInfoListItem> Item { get; set; }
                public class AddDeviceToSharePromotionResponseBodyDataFailDeviceSimpleInfoListItem : TeaModel {
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("FailCode")]
                    [Validation(Required=false)]
                    public int? FailCode { get; set; }

                    [NameInMap("FailReason")]
                    [Validation(Required=false)]
                    public string FailReason { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
