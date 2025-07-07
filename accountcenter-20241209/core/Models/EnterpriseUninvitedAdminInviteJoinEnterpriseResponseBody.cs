// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseUninvitedAdminInviteJoinEnterpriseResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<EnterpriseUninvitedAdminInviteJoinEnterpriseResponseBodyData> Data { get; set; }
        public class EnterpriseUninvitedAdminInviteJoinEnterpriseResponseBodyData : TeaModel {
            [NameInMap("ApplicantAliyunId")]
            [Validation(Required=false)]
            public string ApplicantAliyunId { get; set; }

            [NameInMap("ApplicantPk")]
            [Validation(Required=false)]
            public string ApplicantPk { get; set; }

            [NameInMap("ApplyRemark")]
            [Validation(Required=false)]
            public string ApplyRemark { get; set; }

            [NameInMap("ApplyTime")]
            [Validation(Required=false)]
            public long? ApplyTime { get; set; }

            [NameInMap("AuditorAliyunId")]
            [Validation(Required=false)]
            public string AuditorAliyunId { get; set; }

            [NameInMap("AuditorPk")]
            [Validation(Required=false)]
            public string AuditorPk { get; set; }

            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

            [NameInMap("LeId")]
            [Validation(Required=false)]
            public string LeId { get; set; }

            [NameInMap("LeLicenseNo")]
            [Validation(Required=false)]
            public string LeLicenseNo { get; set; }

            [NameInMap("LeName")]
            [Validation(Required=false)]
            public string LeName { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("NbId")]
            [Validation(Required=false)]
            public string NbId { get; set; }

            [NameInMap("OperatedAliyunId")]
            [Validation(Required=false)]
            public string OperatedAliyunId { get; set; }

            [NameInMap("OperatedPk")]
            [Validation(Required=false)]
            public string OperatedPk { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public string Success { get; set; }

            [NameInMap("TimeoutTime")]
            [Validation(Required=false)]
            public long? TimeoutTime { get; set; }

            [NameInMap("TodoId")]
            [Validation(Required=false)]
            public string TodoId { get; set; }

            [NameInMap("TodoType")]
            [Validation(Required=false)]
            public string TodoType { get; set; }

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
