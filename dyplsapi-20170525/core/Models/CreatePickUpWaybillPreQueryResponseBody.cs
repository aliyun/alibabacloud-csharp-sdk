// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillPreQueryResponseBody : TeaModel {
        /// <summary>
        /// The result set.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreatePickUpWaybillPreQueryResponseBodyData Data { get; set; }
        public class CreatePickUpWaybillPreQueryResponseBodyData : TeaModel {
            /// <summary>
            /// The response code.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The information about whether the courier company can accept the order.
            /// </summary>
            [NameInMap("CpTimeSelectList")]
            [Validation(Required=false)]
            public List<CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectList> CpTimeSelectList { get; set; }
            public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectList : TeaModel {
                /// <summary>
                /// The available time for the scheduled pickup. If the current courier company cannot accept the scheduled pickup, this field is left empty.
                /// </summary>
                [NameInMap("AppointTimes")]
                [Validation(Required=false)]
                public List<CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimes> AppointTimes { get; set; }
                public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimes : TeaModel {
                    /// <summary>
                    /// The date in the YYYY-MM-DD format.
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// Indicates whether the date is selectable.
                    /// </summary>
                    [NameInMap("DateSelectable")]
                    [Validation(Required=false)]
                    public bool? DateSelectable { get; set; }

                    /// <summary>
                    /// The time range for the scheduled pickup for this date.
                    /// </summary>
                    [NameInMap("TimeList")]
                    [Validation(Required=false)]
                    public List<CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimesTimeList> TimeList { get; set; }
                    public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimesTimeList : TeaModel {
                        /// <summary>
                        /// The end of the time range.
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// The tip displayed when the scheduled pickup is not available.
                        /// </summary>
                        [NameInMap("SelectDisableTip")]
                        [Validation(Required=false)]
                        public string SelectDisableTip { get; set; }

                        /// <summary>
                        /// Indicates whether the time range can be selected for the scheduled pickup.
                        /// </summary>
                        [NameInMap("Selectable")]
                        [Validation(Required=false)]
                        public bool? Selectable { get; set; }

                        /// <summary>
                        /// The beginning of the time range.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// The estimated price. Unit: CNY. The value is accurate to two decimal places. The value of this parameter is displayed if an estimated weight is specified.
                /// </summary>
                [NameInMap("PrePrice")]
                [Validation(Required=false)]
                public string PrePrice { get; set; }

                /// <summary>
                /// The information about whether the real-time order can be selected.
                /// </summary>
                [NameInMap("RealTime")]
                [Validation(Required=false)]
                public CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListRealTime RealTime { get; set; }
                public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListRealTime : TeaModel {
                    /// <summary>
                    /// The name of the real-time order type.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The tip displayed when the real-time order cannot be placed.
                    /// </summary>
                    [NameInMap("SelectDisableTip")]
                    [Validation(Required=false)]
                    public string SelectDisableTip { get; set; }

                    /// <summary>
                    /// Indicates whether the real-time order can be placed after the deadline for placing a real-time order is reached.
                    /// </summary>
                    [NameInMap("Selectable")]
                    [Validation(Required=false)]
                    public bool? Selectable { get; set; }

                }

            }

            /// <summary>
            /// The error code.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// The response content.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the request was successful.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
