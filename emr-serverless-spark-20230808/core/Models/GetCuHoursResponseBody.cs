// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetCuHoursResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;cuHours&quot;: &quot;{2025-01-09 00:00:00=2.033333, 2025-01-09 01:00:00=2.033333, 2025-01-09 02:00:00=2.033333, 2025-01-09 03:00:00=2.033333, 2025-01-09 04:00:00=2.033333, 2025-01-09 05:00:00=2.033333, 2025-01-09 06:00:00=2.033333, 2025-01-09 07:00:00=2.033333, 2025-01-09 08:00:00=2.033333, 2025-01-09 09:00:00=1.933333, 2025-01-09 10:00:00=2.133333, 2025-01-09 11:00:00=3.100000, 2025-01-09 12:00:00=2.900000}&quot;
        /// }</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetCuHoursResponseBodyData Data { get; set; }
        public class GetCuHoursResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of CU-hours consumed by a queue during a specified cycle. The value is an estimated value. Refer to your Alibaba Cloud bill for the actual number of consumed CU-hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{2025-01-09 00:00:00=2.033333, 2025-01-09 01:00:00=2.033333, 2025-01-09 02:00:00=2.033333, 2025-01-09 03:00:00=2.033333, 2025-01-09 04:00:00=2.033333, 2025-01-09 05:00:00=2.033333, 2025-01-09 06:00:00=2.033333, 2025-01-09 07:00:00=2.033333, 2025-01-09 08:00:00=2.033333, 2025-01-09 09:00:00=1.933333, 2025-01-09 10:00:00=2.133333, 2025-01-09 11:00:00=3.100000, 2025-01-09 12:00:00=2.900000}</para>
            /// </summary>
            [NameInMap("cuHours")]
            [Validation(Required=false)]
            public string CuHours { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
