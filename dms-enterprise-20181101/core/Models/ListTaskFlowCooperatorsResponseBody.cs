// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowCooperatorsResponseBody : TeaModel {
        [NameInMap("CooperatorList")]
        [Validation(Required=false)]
        public ListTaskFlowCooperatorsResponseBodyCooperatorList CooperatorList { get; set; }
        public class ListTaskFlowCooperatorsResponseBodyCooperatorList : TeaModel {
            [NameInMap("Cooperator")]
            [Validation(Required=false)]
            public List<ListTaskFlowCooperatorsResponseBodyCooperatorListCooperator> Cooperator { get; set; }
            public class ListTaskFlowCooperatorsResponseBodyCooperatorListCooperator : TeaModel {
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("LoginName")]
                [Validation(Required=false)]
                public string LoginName { get; set; }

                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

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
