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
            /// <para>The list of information about whether courier companies are available for placing orders.</para>
            /// </summary>
            [NameInMap("CpTimeSelectList")]
            [Validation(Required=false)]
            public List<CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectList> CpTimeSelectList { get; set; }
            public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectList : TeaModel {
                /// <summary>
                /// <para>The available time options for scheduled orders. If the courier company does not support scheduled orders, this field is empty.</para>
                /// </summary>
                [NameInMap("AppointTimes")]
                [Validation(Required=false)]
                public List<CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimes> AppointTimes { get; set; }
                public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimes : TeaModel {
                    /// <summary>
                    /// <para>The date string in YYYY-MM-DD format.</para>
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
                    /// <para>The list of available time slots for the day.</para>
                    /// </summary>
                    [NameInMap("TimeList")]
                    [Validation(Required=false)]
                    public List<CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimesTimeList> TimeList { get; set; }
                    public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimesTimeList : TeaModel {
                        /// <summary>
                        /// <para>The end time of the time slot, in HH:mm:ss format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12:00:00</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The tip message displayed when the option is not selectable.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Fully booked</para>
                        /// </summary>
                        [NameInMap("SelectDisableTip")]
                        [Validation(Required=false)]
                        public string SelectDisableTip { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the scheduled time slot is selectable.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Selectable")]
                        [Validation(Required=false)]
                        public bool? Selectable { get; set; }

                        /// <summary>
                        /// <para>The start time of the time slot, in HH:mm:ss format.</para>
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
                /// <para>The estimated price, in CNY, rounded to two decimal places. This field has a value only when the estimated weight is specified in the request parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12.50</para>
                /// </summary>
                [NameInMap("PrePrice")]
                [Validation(Required=false)]
                public string PrePrice { get; set; }

                /// <summary>
                /// <para>The available options for real-time orders.</para>
                /// </summary>
                [NameInMap("RealTime")]
                [Validation(Required=false)]
                public CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListRealTime RealTime { get; set; }
                public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListRealTime : TeaModel {
                    /// <summary>
                    /// <para>The service type name for real-time orders.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2-hour pickup</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The tip message displayed when the option is not selectable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The real-time order placement time range has been exceeded</para>
                    /// </summary>
                    [NameInMap("SelectDisableTip")]
                    [Validation(Required=false)]
                    public string SelectDisableTip { get; set; }

                    /// <summary>
                    /// <para>Indicates whether a real-time order can still be placed after the real-time order placement time has passed.</para>
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
            /// <para>None</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
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
            /// <para>Indicates whether the operation is successful.</para>
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
        /// <para>The description of the status code.</para>
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
