// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetScheduleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scheduleInformation")]
        [Validation(Required=false)]
        public List<GetScheduleResponseBodyScheduleInformation> ScheduleInformation { get; set; }
        public class GetScheduleResponseBodyScheduleInformation : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>无权限</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            [NameInMap("ScheduleItems")]
            [Validation(Required=false)]
            public List<GetScheduleResponseBodyScheduleInformationScheduleItems> ScheduleItems { get; set; }
            public class GetScheduleResponseBodyScheduleInformationScheduleItems : TeaModel {
                [NameInMap("End")]
                [Validation(Required=false)]
                public GetScheduleResponseBodyScheduleInformationScheduleItemsEnd End { get; set; }
                public class GetScheduleResponseBodyScheduleInformationScheduleItemsEnd : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-01-01</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-01-01T10:15:30+08:00</para>
                    /// </summary>
                    [NameInMap("DateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Asia/Shanghai</para>
                    /// </summary>
                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                [NameInMap("Start")]
                [Validation(Required=false)]
                public GetScheduleResponseBodyScheduleInformationScheduleItemsStart Start { get; set; }
                public class GetScheduleResponseBodyScheduleInformationScheduleItemsStart : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-01-01</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-01-01T10:15:30+08:00</para>
                    /// </summary>
                    [NameInMap("DateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Asia/Shanghai</para>
                    /// </summary>
                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BUSY</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
