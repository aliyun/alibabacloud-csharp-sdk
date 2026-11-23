// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class MosQueryRegistrationInfoResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public MosQueryRegistrationInfoResponseBodyData Data { get; set; }
        public class MosQueryRegistrationInfoResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<MosQueryRegistrationInfoResponseBodyDataList> List { get; set; }
            public class MosQueryRegistrationInfoResponseBodyDataList : TeaModel {
                [NameInMap("ActivityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                [NameInMap("ChannelName")]
                [Validation(Required=false)]
                public string ChannelName { get; set; }

                [NameInMap("CheckinStatus")]
                [Validation(Required=false)]
                public string CheckinStatus { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("QrCode")]
                [Validation(Required=false)]
                public string QrCode { get; set; }

                [NameInMap("TagInfos")]
                [Validation(Required=false)]
                public List<MosQueryRegistrationInfoResponseBodyDataListTagInfos> TagInfos { get; set; }
                public class MosQueryRegistrationInfoResponseBodyDataListTagInfos : TeaModel {
                    [NameInMap("TagCode")]
                    [Validation(Required=false)]
                    public string TagCode { get; set; }

                    [NameInMap("TagName")]
                    [Validation(Required=false)]
                    public string TagName { get; set; }

                }

                [NameInMap("UserCompany")]
                [Validation(Required=false)]
                public string UserCompany { get; set; }

                [NameInMap("UserEmail")]
                [Validation(Required=false)]
                public string UserEmail { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                [NameInMap("UserPhone")]
                [Validation(Required=false)]
                public string UserPhone { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
