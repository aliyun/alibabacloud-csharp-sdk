// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class GetBasicStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GlobalStatistics")]
        [Validation(Required=false)]
        public GetBasicStatisticsResponseBodyGlobalStatistics GlobalStatistics { get; set; }
        public class GetBasicStatisticsResponseBodyGlobalStatistics : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>42949672960</para>
            /// </summary>
            [NameInMap("ProtectedDataSize")]
            [Validation(Required=false)]
            public long? ProtectedDataSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProtectedResourceCount")]
            [Validation(Required=false)]
            public int? ProtectedResourceCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RegionStatistics")]
        [Validation(Required=false)]
        public List<GetBasicStatisticsResponseBodyRegionStatistics> RegionStatistics { get; set; }
        public class GetBasicStatisticsResponseBodyRegionStatistics : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>42949672960</para>
            /// </summary>
            [NameInMap("ProtectedDataSize")]
            [Validation(Required=false)]
            public long? ProtectedDataSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProtectedResourceCount")]
            [Validation(Required=false)]
            public int? ProtectedResourceCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EB526A5D-1FE2-51C1-B790-1732C1DBA969</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
