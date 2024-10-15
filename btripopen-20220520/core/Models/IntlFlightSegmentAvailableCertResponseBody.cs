// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightSegmentAvailableCertResponseBody : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightSegmentAvailableCertResponseBodyModule Module { get; set; }
        public class IntlFlightSegmentAvailableCertResponseBodyModule : TeaModel {
            [NameInMap("segment_available_cert_list")]
            [Validation(Required=false)]
            public List<IntlFlightSegmentAvailableCertResponseBodyModuleSegmentAvailableCertList> SegmentAvailableCertList { get; set; }
            public class IntlFlightSegmentAvailableCertResponseBodyModuleSegmentAvailableCertList : TeaModel {
                [NameInMap("cert_types")]
                [Validation(Required=false)]
                public List<int?> CertTypes { get; set; }

                [NameInMap("segment_position")]
                [Validation(Required=false)]
                public IntlFlightSegmentAvailableCertResponseBodyModuleSegmentAvailableCertListSegmentPosition SegmentPosition { get; set; }
                public class IntlFlightSegmentAvailableCertResponseBodyModuleSegmentAvailableCertListSegmentPosition : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>210bc81a17090871660176894d008c</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("result_code")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>213e1ea516895592036143147e5864</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
