// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class SipTrunkDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public SipTrunkDetailResponseBodyModel Model { get; set; }
        public class SipTrunkDetailResponseBodyModel : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<SipTrunkDetailResponseBodyModelList> List { get; set; }
            public class SipTrunkDetailResponseBodyModelList : TeaModel {
                [NameInMap("AnswerTime")]
                [Validation(Required=false)]
                public string AnswerTime { get; set; }

                [NameInMap("Answered")]
                [Validation(Required=false)]
                public long? Answered { get; set; }

                [NameInMap("BusiType")]
                [Validation(Required=false)]
                public string BusiType { get; set; }

                [NameInMap("CallEndTime")]
                [Validation(Required=false)]
                public string CallEndTime { get; set; }

                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                [NameInMap("CalledIp")]
                [Validation(Required=false)]
                public string CalledIp { get; set; }

                [NameInMap("CalledNum")]
                [Validation(Required=false)]
                public string CalledNum { get; set; }

                [NameInMap("CalledNumRegion")]
                [Validation(Required=false)]
                public string CalledNumRegion { get; set; }

                [NameInMap("CalledNumType")]
                [Validation(Required=false)]
                public string CalledNumType { get; set; }

                [NameInMap("CallerDisplay")]
                [Validation(Required=false)]
                public string CallerDisplay { get; set; }

                [NameInMap("CallerIp")]
                [Validation(Required=false)]
                public string CallerIp { get; set; }

                [NameInMap("CallerNum")]
                [Validation(Required=false)]
                public string CallerNum { get; set; }

                [NameInMap("CallerNumRegion")]
                [Validation(Required=false)]
                public string CallerNumRegion { get; set; }

                [NameInMap("CallerNumType")]
                [Validation(Required=false)]
                public string CallerNumType { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                [NameInMap("Hangup")]
                [Validation(Required=false)]
                public long? Hangup { get; set; }

                [NameInMap("HangupType")]
                [Validation(Required=false)]
                public long? HangupType { get; set; }

                [NameInMap("LvnCliType")]
                [Validation(Required=false)]
                public string LvnCliType { get; set; }

                [NameInMap("RecordUrl")]
                [Validation(Required=false)]
                public string RecordUrl { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("UserUuid")]
                [Validation(Required=false)]
                public string UserUuid { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
