// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmInstanceConfigAlertResponseBody : TeaModel {
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public DescribeCloudGtmInstanceConfigAlertResponseBodyAlertConfig AlertConfig { get; set; }
        public class DescribeCloudGtmInstanceConfigAlertResponseBodyAlertConfig : TeaModel {
            [NameInMap("AlertConfig")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmInstanceConfigAlertResponseBodyAlertConfigAlertConfig> AlertConfig { get; set; }
            public class DescribeCloudGtmInstanceConfigAlertResponseBodyAlertConfigAlertConfig : TeaModel {
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
        public DescribeCloudGtmInstanceConfigAlertResponseBodyAlertGroup AlertGroup { get; set; }
        public class DescribeCloudGtmInstanceConfigAlertResponseBodyAlertGroup : TeaModel {
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public List<string> AlertGroup { get; set; }

        }

        [NameInMap("AlertMode")]
        [Validation(Required=false)]
        public string AlertMode { get; set; }

        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
