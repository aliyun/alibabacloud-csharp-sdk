// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmGlobalAlertResponseBody : TeaModel {
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public DescribeCloudGtmGlobalAlertResponseBodyAlertConfig AlertConfig { get; set; }
        public class DescribeCloudGtmGlobalAlertResponseBodyAlertConfig : TeaModel {
            [NameInMap("AlertConfig")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmGlobalAlertResponseBodyAlertConfigAlertConfig> AlertConfig { get; set; }
            public class DescribeCloudGtmGlobalAlertResponseBodyAlertConfigAlertConfig : TeaModel {
                [NameInMap("DingtalkNotice")]
                [Validation(Required=false)]
                public bool? DingtalkNotice { get; set; }

                [NameInMap("EmailNotice")]
                [Validation(Required=false)]
                public bool? EmailNotice { get; set; }

                [NameInMap("NoticeType")]
                [Validation(Required=false)]
                public string NoticeType { get; set; }

                [NameInMap("SmsNotice")]
                [Validation(Required=false)]
                public bool? SmsNotice { get; set; }

            }

        }

        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public DescribeCloudGtmGlobalAlertResponseBodyAlertGroup AlertGroup { get; set; }
        public class DescribeCloudGtmGlobalAlertResponseBodyAlertGroup : TeaModel {
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public List<string> AlertGroup { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
