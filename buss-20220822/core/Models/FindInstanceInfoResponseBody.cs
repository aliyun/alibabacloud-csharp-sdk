// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class FindInstanceInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public FindInstanceInfoResponseBodyData Data { get; set; }
        public class FindInstanceInfoResponseBodyData : TeaModel {
            [NameInMap("PegInstanceInfoList")]
            [Validation(Required=false)]
            public List<FindInstanceInfoResponseBodyDataPegInstanceInfoList> PegInstanceInfoList { get; set; }
            public class FindInstanceInfoResponseBodyDataPegInstanceInfoList : TeaModel {
                [NameInMap("BussinessCode")]
                [Validation(Required=false)]
                public string BussinessCode { get; set; }

                [NameInMap("Coordinate")]
                [Validation(Required=false)]
                public Dictionary<string, object> Coordinate { get; set; }

                [NameInMap("IdType")]
                [Validation(Required=false)]
                public string IdType { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("ServiceCreatedTime")]
                [Validation(Required=false)]
                public string ServiceCreatedTime { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("UserInfo")]
                [Validation(Required=false)]
                public FindInstanceInfoResponseBodyDataPegInstanceInfoListUserInfo UserInfo { get; set; }
                public class FindInstanceInfoResponseBodyDataPegInstanceInfoListUserInfo : TeaModel {
                    [NameInMap("GcLevel")]
                    [Validation(Required=false)]
                    public string GcLevel { get; set; }

                    [NameInMap("HitWhiteReason")]
                    [Validation(Required=false)]
                    public string HitWhiteReason { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("UserSite")]
                    [Validation(Required=false)]
                    public string UserSite { get; set; }

                    [NameInMap("WhiteUser")]
                    [Validation(Required=false)]
                    public bool? WhiteUser { get; set; }

                }

            }

        }

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
