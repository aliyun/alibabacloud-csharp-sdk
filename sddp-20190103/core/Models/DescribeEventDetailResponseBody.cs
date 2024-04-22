// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventDetailResponseBody : TeaModel {
        /// <summary>
        /// The details of the anomalous event.
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public DescribeEventDetailResponseBodyEvent Event { get; set; }
        public class DescribeEventDetailResponseBodyEvent : TeaModel {
            /// <summary>
            /// The time when the alert for the anomalous event was generated. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            /// <summary>
            /// Indicates whether the handling result of the anomalous event is used to enhance the detection of anomalous events. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// 
            /// > If you enhance the detection of anomalous events, the detection accuracy and the rate of triggering alerts for anomalous events are improved.
            /// </summary>
            [NameInMap("Backed")]
            [Validation(Required=false)]
            public bool? Backed { get; set; }

            /// <summary>
            /// The instance name of the service in which the anomalous event was detected.
            /// </summary>
            [NameInMap("DataInstance")]
            [Validation(Required=false)]
            public string DataInstance { get; set; }

            /// <summary>
            /// The display name of the account that is used to handle the anomalous event.
            /// </summary>
            [NameInMap("DealDisplayName")]
            [Validation(Required=false)]
            public string DealDisplayName { get; set; }

            /// <summary>
            /// The username of the account that is used to handle the anomalous event.
            /// </summary>
            [NameInMap("DealLoginName")]
            [Validation(Required=false)]
            public string DealLoginName { get; set; }

            /// <summary>
            /// The reason why the anomalous event is handled.
            /// </summary>
            [NameInMap("DealReason")]
            [Validation(Required=false)]
            public string DealReason { get; set; }

            /// <summary>
            /// The time when the anomalous event was handled. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public long? DealTime { get; set; }

            /// <summary>
            /// The ID of the account that is used to handle the anomalous event.
            /// </summary>
            [NameInMap("DealUserId")]
            [Validation(Required=false)]
            public long? DealUserId { get; set; }

            /// <summary>
            /// The content in the details of the anomalous event.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public DescribeEventDetailResponseBodyEventDetail Detail { get; set; }
            public class DescribeEventDetailResponseBodyEventDetail : TeaModel {
                /// <summary>
                /// An array that consists of the baseline behavior chart of the anomalous event.
                /// </summary>
                [NameInMap("Chart")]
                [Validation(Required=false)]
                public List<DescribeEventDetailResponseBodyEventDetailChart> Chart { get; set; }
                public class DescribeEventDetailResponseBodyEventDetailChart : TeaModel {
                    [NameInMap("ChatType")]
                    [Validation(Required=false)]
                    public int? ChatType { get; set; }

                    /// <summary>
                    /// The data in the baseline behavior profile of the anomalous event.
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public DescribeEventDetailResponseBodyEventDetailChartData Data { get; set; }
                    public class DescribeEventDetailResponseBodyEventDetailChartData : TeaModel {
                        /// <summary>
                        /// The values of data on the x-axis.
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public List<string> X { get; set; }

                        /// <summary>
                        /// The values of data on the y-axis.
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public List<string> Y { get; set; }

                        [NameInMap("Z")]
                        [Validation(Required=false)]
                        public List<string> Z { get; set; }

                    }

                    /// <summary>
                    /// The name of the baseline behavior chart of the anomalous event.
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The type of the chart. Valid values:
                    /// 
                    /// *   **1**: column chart
                    /// *   **2**: line chart
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The descriptive label of data on the x-axis.
                    /// </summary>
                    [NameInMap("XLabel")]
                    [Validation(Required=false)]
                    public string XLabel { get; set; }

                    /// <summary>
                    /// The descriptive label of data on the y-axis.
                    /// </summary>
                    [NameInMap("YLabel")]
                    [Validation(Required=false)]
                    public string YLabel { get; set; }

                    [NameInMap("ZLabel")]
                    [Validation(Required=false)]
                    public string ZLabel { get; set; }

                }

                /// <summary>
                /// An array that consists of the content in the anomalous event.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public List<DescribeEventDetailResponseBodyEventDetailContent> Content { get; set; }
                public class DescribeEventDetailResponseBodyEventDetailContent : TeaModel {
                    /// <summary>
                    /// The title of the content in the anomalous event.
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The description of the content in the anomalous event.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// An array that consists of the source from which the information of the anomalous event is recorded.
                /// </summary>
                [NameInMap("ResourceInfo")]
                [Validation(Required=false)]
                public List<DescribeEventDetailResponseBodyEventDetailResourceInfo> ResourceInfo { get; set; }
                public class DescribeEventDetailResponseBodyEventDetailResourceInfo : TeaModel {
                    /// <summary>
                    /// The source title.
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The source description.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The display name of the account that triggered the anomalous event.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The time when the anomalous event occurred. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

            /// <summary>
            /// An array that consists of the handling records of the anomalous event.
            /// </summary>
            [NameInMap("HandleInfoList")]
            [Validation(Required=false)]
            public List<DescribeEventDetailResponseBodyEventHandleInfoList> HandleInfoList { get; set; }
            public class DescribeEventDetailResponseBodyEventHandleInfoList : TeaModel {
                /// <summary>
                /// The account that is used to handle the anomalous event.
                /// </summary>
                [NameInMap("CurrentValue")]
                [Validation(Required=false)]
                public string CurrentValue { get; set; }

                /// <summary>
                /// The point in time when the account was locked. The value is a UNIX timestamp. Unit: milliseconds.
                /// </summary>
                [NameInMap("DisableTime")]
                [Validation(Required=false)]
                public long? DisableTime { get; set; }

                /// <summary>
                /// The point in time when the account was unlocked. The value is a UNIX timestamp. Unit: milliseconds.
                /// </summary>
                [NameInMap("EnableTime")]
                [Validation(Required=false)]
                public long? EnableTime { get; set; }

                /// <summary>
                /// The handling method.
                /// </summary>
                [NameInMap("HandlerName")]
                [Validation(Required=false)]
                public string HandlerName { get; set; }

                /// <summary>
                /// The type of the handling method.
                /// </summary>
                [NameInMap("HandlerType")]
                [Validation(Required=false)]
                public string HandlerType { get; set; }

                /// <summary>
                /// The duration for which the handling operation takes effect. If you leave this parameter empty, the handling operation is permanently valid. Unit: minutes.
                /// </summary>
                [NameInMap("HandlerValue")]
                [Validation(Required=false)]
                public int? HandlerValue { get; set; }

                /// <summary>
                /// The ID of the handling record.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The status of the account that triggered the anomalous event. Valid values:
                /// 
                /// *   **0**: locked
                /// *   **1**: unlocked
                /// *   **-1**: failed to unlock the account
                /// *   **-2**: failed to enable the account
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// The unique ID of the anomalous event.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The details of the alert logs.
            /// </summary>
            [NameInMap("LogDetail")]
            [Validation(Required=false)]
            public string LogDetail { get; set; }

            /// <summary>
            /// The username of the account that triggered the anomalous event.
            /// </summary>
            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }

            [NameInMap("NewAlarm")]
            [Validation(Required=false)]
            public bool? NewAlarm { get; set; }

            /// <summary>
            /// The name of the service in which the anomalous event was detected. Valid values include **MaxCompute, OSS, ADS, OTS, and RDS**.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The handling status for the anomalous event. Valid values:
            /// 
            /// *   **0**: unhandled
            /// *   **1**: confirmed
            /// *   **2**: marked as false positive
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The name of the handling status for the anomalous event.
            /// </summary>
            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }

            /// <summary>
            /// The code of the anomalous event subtype.
            /// </summary>
            [NameInMap("SubTypeCode")]
            [Validation(Required=false)]
            public string SubTypeCode { get; set; }

            /// <summary>
            /// The name of the anomalous event subtype.
            /// </summary>
            [NameInMap("SubTypeName")]
            [Validation(Required=false)]
            public string SubTypeName { get; set; }

            /// <summary>
            /// The code of the anomalous event type.
            /// </summary>
            [NameInMap("TypeCode")]
            [Validation(Required=false)]
            public string TypeCode { get; set; }

            /// <summary>
            /// The name of the anomalous event type. Valid values:
            /// 
            /// *   **01**: anomalous permission usage
            /// *   **02**: anomalous data flow
            /// *   **03**: anomalous data operation
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

            /// <summary>
            /// The ID of the account that triggered the anomalous event.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
