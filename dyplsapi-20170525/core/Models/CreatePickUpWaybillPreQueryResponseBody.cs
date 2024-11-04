// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillPreQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The result set.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreatePickUpWaybillPreQueryResponseBodyData Data { get; set; }
        public class CreatePickUpWaybillPreQueryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The response code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The information about whether the courier company can accept the order.</para>
            /// </summary>
            [NameInMap("CpTimeSelectList")]
            [Validation(Required=false)]
            public List<CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectList> CpTimeSelectList { get; set; }
            public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectList : TeaModel {
                /// <summary>
                /// <para>The available time for the scheduled pickup. If the current courier company cannot accept the scheduled pickup, this field is left empty.</para>
                /// </summary>
                [NameInMap("AppointTimes")]
                [Validation(Required=false)]
                public List<CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimes> AppointTimes { get; set; }
                public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimes : TeaModel {
                    /// <summary>
                    /// <para>The date in the YYYY-MM-DD format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-04-28</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the date is selectable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DateSelectable")]
                    [Validation(Required=false)]
                    public bool? DateSelectable { get; set; }

                    /// <summary>
                    /// <para>The time range for the scheduled pickup for this date.</para>
                    /// </summary>
                    [NameInMap("TimeList")]
                    [Validation(Required=false)]
                    public List<CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimesTimeList> TimeList { get; set; }
                    public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimesTimeList : TeaModel {
                        /// <summary>
                        /// <para>The end of the time range.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12:00:00</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The tip displayed when the scheduled pickup is not available.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Appointment Full</para>
                        /// </summary>
                        [NameInMap("SelectDisableTip")]
                        [Validation(Required=false)]
                        public string SelectDisableTip { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the time range can be selected for the scheduled pickup.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Selectable")]
                        [Validation(Required=false)]
                        public bool? Selectable { get; set; }

                        /// <summary>
                        /// <para>The beginning of the time range.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10:00:00</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>The estimated price. Unit: CNY. The value is accurate to two decimal places. The value of this parameter is displayed if an estimated weight is specified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12.50</para>
                /// </summary>
                [NameInMap("PrePrice")]
                [Validation(Required=false)]
                public string PrePrice { get; set; }

                /// <summary>
                /// <para>The information about whether the real-time order can be selected.</para>
                /// </summary>
                [NameInMap("RealTime")]
                [Validation(Required=false)]
                public CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListRealTime RealTime { get; set; }
                public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListRealTime : TeaModel {
                    /// <summary>
                    /// <para>The name of the real-time order type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Aliyun</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The tip displayed when the real-time order cannot be placed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Exceeding the real-time ordering time range.</para>
                    /// </summary>
                    [NameInMap("SelectDisableTip")]
                    [Validation(Required=false)]
                    public string SelectDisableTip { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the real-time order can be placed after the deadline for placing a real-time order is reached.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Selectable")]
                    [Validation(Required=false)]
                    public bool? Selectable { get; set; }

                }

            }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The response content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the request was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FC30594-3841-43AD-9008-03393BCB5CD2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
