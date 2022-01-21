// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogListResponseBody : TeaModel {
        [NameInMap("AlertLogList")]
        [Validation(Required=false)]
        public List<DescribeAlertLogListResponseBodyAlertLogList> AlertLogList { get; set; }
        public class DescribeAlertLogListResponseBodyAlertLogList : TeaModel {
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public string AlertTime { get; set; }

            [NameInMap("BlackListDetail")]
            [Validation(Required=false)]
            public string BlackListDetail { get; set; }

            [NameInMap("BlackListName")]
            [Validation(Required=false)]
            public string BlackListName { get; set; }

            [NameInMap("BlackListUUID")]
            [Validation(Required=false)]
            public string BlackListUUID { get; set; }

            [NameInMap("ContactALIIWWList")]
            [Validation(Required=false)]
            public List<string> ContactALIIWWList { get; set; }

            [NameInMap("ContactDingList")]
            [Validation(Required=false)]
            public List<string> ContactDingList { get; set; }

            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public List<string> ContactGroups { get; set; }

            [NameInMap("ContactMailList")]
            [Validation(Required=false)]
            public List<string> ContactMailList { get; set; }

            [NameInMap("ContactOnCallList")]
            [Validation(Required=false)]
            public List<string> ContactOnCallList { get; set; }

            [NameInMap("ContactSMSList")]
            [Validation(Required=false)]
            public List<string> ContactSMSList { get; set; }

            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListDimensions> Dimensions { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListDimensions : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("DingdingWebhookList")]
            [Validation(Required=false)]
            public List<string> DingdingWebhookList { get; set; }

            [NameInMap("Escalation")]
            [Validation(Required=false)]
            public DescribeAlertLogListResponseBodyAlertLogListEscalation Escalation { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListEscalation : TeaModel {
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }
                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }
            };

            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("ExtendedInfo")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListExtendedInfo> ExtendedInfo { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListExtendedInfo : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("LevelChange")]
            [Validation(Required=false)]
            public string LevelChange { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("SendDetail")]
            [Validation(Required=false)]
            public DescribeAlertLogListResponseBodyAlertLogListSendDetail SendDetail { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListSendDetail : TeaModel {
                [NameInMap("ChannelResultList")]
                [Validation(Required=false)]
                public List<DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultList> ChannelResultList { get; set; }
                public class DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultList : TeaModel {
                    public string Channel { get; set; }
                    public List<DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultListResultList> ResultList { get; set; }
                    public class DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultListResultList : TeaModel {
                        public string Code { get; set; }
                        public string Detail { get; set; }
                        public string RequestId { get; set; }
                        public bool? Success { get; set; }
                        public List<string> NotifyTargetList { get; set; }
                    }
                }
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public string ResultCode { get; set; }
            };

            [NameInMap("SendResultList")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListSendResultList> SendResultList { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListSendResultList : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<string> Value { get; set; }

            }

            [NameInMap("SendStatus")]
            [Validation(Required=false)]
            public string SendStatus { get; set; }

            [NameInMap("WebhookList")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListWebhookList> WebhookList { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListWebhookList : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
