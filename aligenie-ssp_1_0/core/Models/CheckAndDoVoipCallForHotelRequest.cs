// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CheckAndDoVoipCallForHotelRequest : TeaModel {
        [NameInMap("BizData")]
        [Validation(Required=false)]
        public string BizData { get; set; }

        [NameInMap("CalleeNick")]
        [Validation(Required=false)]
        public string CalleeNick { get; set; }

        [NameInMap("CalleePhoneNum")]
        [Validation(Required=false)]
        public string CalleePhoneNum { get; set; }

        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public CheckAndDoVoipCallForHotelRequestDeviceInfo DeviceInfo { get; set; }
        public class CheckAndDoVoipCallForHotelRequestDeviceInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CheckAndDoVoipCallForHotelRequestUserInfo UserInfo { get; set; }
        public class CheckAndDoVoipCallForHotelRequestUserInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
