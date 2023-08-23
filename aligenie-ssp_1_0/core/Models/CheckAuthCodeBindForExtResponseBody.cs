// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CheckAuthCodeBindForExtResponseBody : TeaModel {
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
        public CheckAuthCodeBindForExtResponseBodyResult Result { get; set; }
        public class CheckAuthCodeBindForExtResponseBodyResult : TeaModel {
            [NameInMap("DeviceOpenInfo")]
            [Validation(Required=false)]
            public CheckAuthCodeBindForExtResponseBodyResultDeviceOpenInfo DeviceOpenInfo { get; set; }
            public class CheckAuthCodeBindForExtResponseBodyResultDeviceOpenInfo : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// DEVICE_ID
                /// </summary>
                [NameInMap("IdType")]
                [Validation(Required=false)]
                public string IdType { get; set; }

            }

            [NameInMap("UserOpenInfo")]
            [Validation(Required=false)]
            public CheckAuthCodeBindForExtResponseBodyResultUserOpenInfo UserOpenInfo { get; set; }
            public class CheckAuthCodeBindForExtResponseBodyResultUserOpenInfo : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// USER_ID
                /// </summary>
                [NameInMap("IdType")]
                [Validation(Required=false)]
                public string IdType { get; set; }

            }

        }

    }

}
