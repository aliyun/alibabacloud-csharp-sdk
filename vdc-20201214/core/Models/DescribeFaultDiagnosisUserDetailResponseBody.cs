// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeFaultDiagnosisUserDetailResponseBody : TeaModel {
        [NameInMap("CallInfo")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisUserDetailResponseBodyCallInfo CallInfo { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyCallInfo : TeaModel {
            /// <summary>
            /// App ID。
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

        [NameInMap("FactorList")]
        [Validation(Required=false)]
        public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorList> FactorList { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyFactorList : TeaModel {
            [NameInMap("FactorId")]
            [Validation(Required=false)]
            public string FactorId { get; set; }

            [NameInMap("FaultSource")]
            [Validation(Required=false)]
            public string FaultSource { get; set; }

            [NameInMap("RelatedEventDatas")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatas> RelatedEventDatas { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatas : TeaModel {
                [NameInMap("EventDataItems")]
                [Validation(Required=false)]
                public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItems> EventDataItems { get; set; }
                public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItems : TeaModel {
                    [NameInMap("EventList")]
                    [Validation(Required=false)]
                    public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItemsEventList> EventList { get; set; }
                    public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItemsEventList : TeaModel {
                        [NameInMap("Acs")]
                        [Validation(Required=false)]
                        public string Acs { get; set; }

                        [NameInMap("EventCode")]
                        [Validation(Required=false)]
                        public string EventCode { get; set; }

                        [NameInMap("EventName")]
                        [Validation(Required=false)]
                        public string EventName { get; set; }

                        [NameInMap("EventType")]
                        [Validation(Required=false)]
                        public string EventType { get; set; }

                        [NameInMap("Os")]
                        [Validation(Required=false)]
                        public string Os { get; set; }

                        [NameInMap("Sdk")]
                        [Validation(Required=false)]
                        public string Sdk { get; set; }

                        [NameInMap("StreamName")]
                        [Validation(Required=false)]
                        public string StreamName { get; set; }

                        [NameInMap("StreamType")]
                        [Validation(Required=false)]
                        public string StreamType { get; set; }

                        [NameInMap("TrackCode")]
                        [Validation(Required=false)]
                        public string TrackCode { get; set; }

                        [NameInMap("TrackName")]
                        [Validation(Required=false)]
                        public string TrackName { get; set; }

                        [NameInMap("Ts")]
                        [Validation(Required=false)]
                        public long? Ts { get; set; }

                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    [NameInMap("Ts")]
                    [Validation(Required=false)]
                    public long? Ts { get; set; }

                }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("RelatedMetricDatas")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatas> RelatedMetricDatas { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatas : TeaModel {
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatasNodes> Nodes { get; set; }
                public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatasNodes : TeaModel {
                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Ext { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public string X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public string Y { get; set; }

                }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("FaultMetricData")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricData FaultMetricData { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricData : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricDataNodes> Nodes { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricDataNodes : TeaModel {
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

        }

        [NameInMap("NetworkOperators")]
        [Validation(Required=false)]
        public List<string> NetworkOperators { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserDetail")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisUserDetailResponseBodyUserDetail UserDetail { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyUserDetail : TeaModel {
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyUserDetailOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyUserDetailOnlinePeriods : TeaModel {
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

            }

            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
