// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class ListInstanceAlarmResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstanceAlarmResponseBodyData Data { get; set; }
        public class ListInstanceAlarmResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("VoList")]
            [Validation(Required=false)]
            public ListInstanceAlarmResponseBodyDataVoList VoList { get; set; }
            public class ListInstanceAlarmResponseBodyDataVoList : TeaModel {
                [NameInMap("CommodityInstanceAlarmVO")]
                [Validation(Required=false)]
                public List<ListInstanceAlarmResponseBodyDataVoListCommodityInstanceAlarmVO> CommodityInstanceAlarmVO { get; set; }
                public class ListInstanceAlarmResponseBodyDataVoListCommodityInstanceAlarmVO : TeaModel {
                    [NameInMap("AlarmVO")]
                    [Validation(Required=false)]
                    public ListInstanceAlarmResponseBodyDataVoListCommodityInstanceAlarmVOAlarmVO AlarmVO { get; set; }
                    public class ListInstanceAlarmResponseBodyDataVoListCommodityInstanceAlarmVOAlarmVO : TeaModel {
                        [NameInMap("AlarmCount")]
                        [Validation(Required=false)]
                        public int? AlarmCount { get; set; }

                        [NameInMap("AlarmDetails")]
                        [Validation(Required=false)]
                        public ListInstanceAlarmResponseBodyDataVoListCommodityInstanceAlarmVOAlarmVOAlarmDetails AlarmDetails { get; set; }
                        public class ListInstanceAlarmResponseBodyDataVoListCommodityInstanceAlarmVOAlarmVOAlarmDetails : TeaModel {
                            [NameInMap("AlarmDetail")]
                            [Validation(Required=false)]
                            public List<ListInstanceAlarmResponseBodyDataVoListCommodityInstanceAlarmVOAlarmVOAlarmDetailsAlarmDetail> AlarmDetail { get; set; }
                            public class ListInstanceAlarmResponseBodyDataVoListCommodityInstanceAlarmVOAlarmVOAlarmDetailsAlarmDetail : TeaModel {
                                [NameInMap("AlertState")]
                                [Validation(Required=false)]
                                public string AlertState { get; set; }

                                [NameInMap("ComparisonOperator")]
                                [Validation(Required=false)]
                                public string ComparisonOperator { get; set; }

                                [NameInMap("ContactGroups")]
                                [Validation(Required=false)]
                                public string ContactGroups { get; set; }

                                [NameInMap("Dimensions")]
                                [Validation(Required=false)]
                                public string Dimensions { get; set; }

                                [NameInMap("EffectiveInterval")]
                                [Validation(Required=false)]
                                public string EffectiveInterval { get; set; }

                                [NameInMap("EnableState")]
                                [Validation(Required=false)]
                                public bool? EnableState { get; set; }

                                [NameInMap("GroupId")]
                                [Validation(Required=false)]
                                public string GroupId { get; set; }

                                [NameInMap("GroupName")]
                                [Validation(Required=false)]
                                public string GroupName { get; set; }

                                [NameInMap("MailSubject")]
                                [Validation(Required=false)]
                                public string MailSubject { get; set; }

                                [NameInMap("MetricName")]
                                [Validation(Required=false)]
                                public string MetricName { get; set; }

                                [NameInMap("Namespace")]
                                [Validation(Required=false)]
                                public string Namespace { get; set; }

                                [NameInMap("NoEffectiveInterval")]
                                [Validation(Required=false)]
                                public string NoEffectiveInterval { get; set; }

                                [NameInMap("Period")]
                                [Validation(Required=false)]
                                public string Period { get; set; }

                                [NameInMap("Resources")]
                                [Validation(Required=false)]
                                public string Resources { get; set; }

                                [NameInMap("RuleId")]
                                [Validation(Required=false)]
                                public string RuleId { get; set; }

                                [NameInMap("RuleName")]
                                [Validation(Required=false)]
                                public string RuleName { get; set; }

                                [NameInMap("SilenceTime")]
                                [Validation(Required=false)]
                                public string SilenceTime { get; set; }

                                [NameInMap("Statistics")]
                                [Validation(Required=false)]
                                public string Statistics { get; set; }

                                [NameInMap("Threshold")]
                                [Validation(Required=false)]
                                public string Threshold { get; set; }

                                [NameInMap("Times")]
                                [Validation(Required=false)]
                                public string Times { get; set; }

                                [NameInMap("Webhook")]
                                [Validation(Required=false)]
                                public string Webhook { get; set; }

                            }

                        }

                        [NameInMap("HasConfigAlarm")]
                        [Validation(Required=false)]
                        public bool? HasConfigAlarm { get; set; }

                    }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                }

            }

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
