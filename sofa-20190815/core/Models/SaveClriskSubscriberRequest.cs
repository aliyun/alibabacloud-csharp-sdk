// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SaveClriskSubscriberRequest : TeaModel {
        [NameInMap("DdMessageNoticeAggregate")]
        [Validation(Required=false)]
        public List<SaveClriskSubscriberRequestDdMessageNoticeAggregate> DdMessageNoticeAggregate { get; set; }
        public class SaveClriskSubscriberRequestDdMessageNoticeAggregate : TeaModel {
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

        [NameInMap("EmailNoticeAggregateJsonStr")]
        [Validation(Required=false)]
        public string EmailNoticeAggregateJsonStr { get; set; }

        [NameInMap("EntranceCodesRepeatList")]
        [Validation(Required=false)]
        public List<string> EntranceCodesRepeatList { get; set; }

        [NameInMap("MessageNoticeAggregateJsonStr")]
        [Validation(Required=false)]
        public string MessageNoticeAggregateJsonStr { get; set; }

    }

}
