// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetClriskSubscribeUserInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("DdMessageNoticeAggregate")]
        [Validation(Required=false)]
        public List<GetClriskSubscribeUserInfoResponseBodyDdMessageNoticeAggregate> DdMessageNoticeAggregate { get; set; }
        public class GetClriskSubscribeUserInfoResponseBodyDdMessageNoticeAggregate : TeaModel {
            [NameInMap("IsIssueSubscribe")]
            [Validation(Required=false)]
            public bool? IsIssueSubscribe { get; set; }

            [NameInMap("IsModelSubscribe")]
            [Validation(Required=false)]
            public bool? IsModelSubscribe { get; set; }

            [NameInMap("IsTaskSubscribe")]
            [Validation(Required=false)]
            public bool? IsTaskSubscribe { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Secret")]
            [Validation(Required=false)]
            public string Secret { get; set; }

            [NameInMap("WebHookAddress")]
            [Validation(Required=false)]
            public string WebHookAddress { get; set; }

        }

        [NameInMap("EmailNoticeAggregate")]
        [Validation(Required=false)]
        public GetClriskSubscribeUserInfoResponseBodyEmailNoticeAggregate EmailNoticeAggregate { get; set; }
        public class GetClriskSubscribeUserInfoResponseBodyEmailNoticeAggregate : TeaModel {
            [NameInMap("EmailAddress")]
            [Validation(Required=false)]
            public string EmailAddress { get; set; }
            [NameInMap("IsIssueSubscribe")]
            [Validation(Required=false)]
            public bool? IsIssueSubscribe { get; set; }
            [NameInMap("IsModelSubscribe")]
            [Validation(Required=false)]
            public bool? IsModelSubscribe { get; set; }
            [NameInMap("IsTaskSubscribe")]
            [Validation(Required=false)]
            public bool? IsTaskSubscribe { get; set; }
        };

        [NameInMap("MessageNoticeAggregate")]
        [Validation(Required=false)]
        public GetClriskSubscribeUserInfoResponseBodyMessageNoticeAggregate MessageNoticeAggregate { get; set; }
        public class GetClriskSubscribeUserInfoResponseBodyMessageNoticeAggregate : TeaModel {
            [NameInMap("IsIssueSubscribe")]
            [Validation(Required=false)]
            public bool? IsIssueSubscribe { get; set; }
            [NameInMap("IsModelSubscribe")]
            [Validation(Required=false)]
            public bool? IsModelSubscribe { get; set; }
            [NameInMap("IsTaskSubscribe")]
            [Validation(Required=false)]
            public bool? IsTaskSubscribe { get; set; }
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }
        };

    }

}
