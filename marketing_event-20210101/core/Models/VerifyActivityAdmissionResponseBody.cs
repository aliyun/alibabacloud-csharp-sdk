// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class VerifyActivityAdmissionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public VerifyActivityAdmissionResponseBodyData Data { get; set; }
        public class VerifyActivityAdmissionResponseBodyData : TeaModel {
            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public long? ActivityId { get; set; }

            [NameInMap("ActivityName")]
            [Validation(Required=false)]
            public string ActivityName { get; set; }

            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("AdmissionDate")]
            [Validation(Required=false)]
            public string AdmissionDate { get; set; }

            [NameInMap("AllowedDates")]
            [Validation(Required=false)]
            public List<string> AllowedDates { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>定邀-现场嘉宾</para>
            /// </summary>
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;VIP&quot;, &quot;思辨场&quot;]</para>
            /// </summary>
            [NameInMap("CustomerLabels")]
            [Validation(Required=false)]
            public List<string> CustomerLabels { get; set; }

            [NameInMap("Decision")]
            [Validation(Required=false)]
            public string Decision { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("MaskedIdCardNo")]
            [Validation(Required=false)]
            public string MaskedIdCardNo { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegistrationStatus")]
            [Validation(Required=false)]
            public int? RegistrationStatus { get; set; }

            [NameInMap("SignedIn")]
            [Validation(Required=false)]
            public bool? SignedIn { get; set; }

            [NameInMap("SigninTime")]
            [Validation(Required=false)]
            public string SigninTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

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
