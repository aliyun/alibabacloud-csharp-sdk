// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightSegmentAvailableCertResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data returned by the server. This value is null if no result is available or an exception occurs.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightSegmentAvailableCertResponseBodyModule Module { get; set; }
        public class IntlFlightSegmentAvailableCertResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of available identity documents for each segment.</para>
            /// </summary>
            [NameInMap("segment_available_cert_list")]
            [Validation(Required=false)]
            public List<IntlFlightSegmentAvailableCertResponseBodyModuleSegmentAvailableCertList> SegmentAvailableCertList { get; set; }
            public class IntlFlightSegmentAvailableCertResponseBodyModuleSegmentAvailableCertList : TeaModel {
                /// <summary>
                /// <para>The identity document types. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: ID card.</description></item>
                /// <item><description>1: Passport.</description></item>
                /// <item><description>4: Home Return Permit.</description></item>
                /// <item><description>5: Mainland Travel Permit for Taiwan Residents.</description></item>
                /// <item><description>6: Exit-Entry Permit for Hong Kong and Macao.</description></item>
                /// <item><description>7: International Seafarer\&quot;s Identity Document.</description></item>
                /// <item><description>8: Foreigner\&quot;s Permanent Residence Card.</description></item>
                /// <item><description>12: Travel Permit to Taiwan.</description></item>
                /// <item><description>13: Entry Permit to Taiwan.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("cert_types")]
                [Validation(Required=false)]
                public List<int?> CertTypes { get; set; }

                /// <summary>
                /// <para>The segment position information.</para>
                /// </summary>
                [NameInMap("segment_position")]
                [Validation(Required=false)]
                public IntlFlightSegmentAvailableCertResponseBodyModuleSegmentAvailableCertListSegmentPosition SegmentPosition { get; set; }
                public class IntlFlightSegmentAvailableCertResponseBodyModuleSegmentAvailableCertListSegmentPosition : TeaModel {
                    /// <summary>
                    /// <para>The journey index, starting from 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <para>The segment index, starting from 0 within the same journey.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID. Each request has a unique ID for troubleshooting purposes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc81a17090871660176894d008c</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("result_code")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. This value is set by the server. The value is false if an exception occurs or the result is null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>213e1ea516895592036143147e5864</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
