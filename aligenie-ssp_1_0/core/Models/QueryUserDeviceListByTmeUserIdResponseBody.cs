// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class QueryUserDeviceListByTmeUserIdResponseBody : TeaModel {
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
        public QueryUserDeviceListByTmeUserIdResponseBodyResult Result { get; set; }
        public class QueryUserDeviceListByTmeUserIdResponseBodyResult : TeaModel {
            [NameInMap("AligenieUserInfoList")]
            [Validation(Required=false)]
            public List<QueryUserDeviceListByTmeUserIdResponseBodyResultAligenieUserInfoList> AligenieUserInfoList { get; set; }
            public class QueryUserDeviceListByTmeUserIdResponseBodyResultAligenieUserInfoList : TeaModel {
                [NameInMap("AuthorizedDeviceList")]
                [Validation(Required=false)]
                public List<QueryUserDeviceListByTmeUserIdResponseBodyResultAligenieUserInfoListAuthorizedDeviceList> AuthorizedDeviceList { get; set; }
                public class QueryUserDeviceListByTmeUserIdResponseBodyResultAligenieUserInfoListAuthorizedDeviceList : TeaModel {
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Online")]
                    [Validation(Required=false)]
                    public bool? Online { get; set; }

                    [NameInMap("OpenDeviceId")]
                    [Validation(Required=false)]
                    public string OpenDeviceId { get; set; }

                    [NameInMap("TmeDeviceId")]
                    [Validation(Required=false)]
                    public string TmeDeviceId { get; set; }

                    [NameInMap("TmeProductId")]
                    [Validation(Required=false)]
                    public string TmeProductId { get; set; }

                }

                [NameInMap("OpenUserId")]
                [Validation(Required=false)]
                public string OpenUserId { get; set; }

                [NameInMap("UserNickname")]
                [Validation(Required=false)]
                public string UserNickname { get; set; }

            }

            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Sp")]
            [Validation(Required=false)]
            public string Sp { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
