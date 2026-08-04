// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class GetDingTalkUserOrgByAliyunTmpCodeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDingTalkUserOrgByAliyunTmpCodeResponseBodyData Data { get; set; }
        public class GetDingTalkUserOrgByAliyunTmpCodeResponseBodyData : TeaModel {
            [NameInMap("AssociatedUnionId")]
            [Validation(Required=false)]
            public string AssociatedUnionId { get; set; }

            [NameInMap("Nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            [NameInMap("OrgDtoList")]
            [Validation(Required=false)]
            public List<GetDingTalkUserOrgByAliyunTmpCodeResponseBodyDataOrgDtoList> OrgDtoList { get; set; }
            public class GetDingTalkUserOrgByAliyunTmpCodeResponseBodyDataOrgDtoList : TeaModel {
                [NameInMap("CorpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("OrgId")]
                [Validation(Required=false)]
                public string OrgId { get; set; }

                [NameInMap("OrgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

            }

        }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

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
