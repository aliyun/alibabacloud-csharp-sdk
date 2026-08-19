// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class GetBasicStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. A value of 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The Backup statistics for all regions.</para>
        /// </summary>
        [NameInMap("GlobalStatistics")]
        [Validation(Required=false)]
        public GetBasicStatisticsResponseBodyGlobalStatistics GlobalStatistics { get; set; }
        public class GetBasicStatisticsResponseBodyGlobalStatistics : TeaModel {
            /// <summary>
            /// <para>The backed-up data size, in bytes.</para>
            /// <list type="bullet">
            /// <item><description>When <c>SourceType</c> is set to <c>ECS_FILE</c>, this parameter represents the total capacity of backed-up Cloud Disks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>42949672960</para>
            /// </summary>
            [NameInMap("ProtectedDataSize")]
            [Validation(Required=false)]
            public long? ProtectedDataSize { get; set; }

            /// <summary>
            /// <para>The number of backed-up resources.</para>
            /// <list type="bullet">
            /// <item><description>When <c>SourceType</c> is set to <c>ECS_FILE</c>, this parameter represents the number of backed-up ECS instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProtectedResourceCount")]
            [Validation(Required=false)]
            public int? ProtectedResourceCount { get; set; }

        }

        /// <summary>
        /// <para>The response message. If the request is successful, <c>successful</c> is returned. If the request fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The Backup statistics for each region.</para>
        /// </summary>
        [NameInMap("RegionStatistics")]
        [Validation(Required=false)]
        public List<GetBasicStatisticsResponseBodyRegionStatistics> RegionStatistics { get; set; }
        public class GetBasicStatisticsResponseBodyRegionStatistics : TeaModel {
            /// <summary>
            /// <para>The backed-up data size, in bytes.</para>
            /// <list type="bullet">
            /// <item><description>When <c>SourceType</c> is set to <c>ECS_FILE</c>, this parameter represents the total capacity of backed-up Cloud Disks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>42949672960</para>
            /// </summary>
            [NameInMap("ProtectedDataSize")]
            [Validation(Required=false)]
            public long? ProtectedDataSize { get; set; }

            /// <summary>
            /// <para>The number of backed-up resources.</para>
            /// <list type="bullet">
            /// <item><description>When <c>SourceType</c> is set to <c>ECS_FILE</c>, this parameter represents the number of backed-up ECS instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProtectedResourceCount")]
            [Validation(Required=false)]
            public int? ProtectedResourceCount { get; set; }

            /// <summary>
            /// <para>The Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB526A5D-1FE2-51C1-B790-1732C1DBA969</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data source type. The valid value is:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: ECS File Backup.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
