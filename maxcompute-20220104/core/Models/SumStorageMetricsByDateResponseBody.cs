// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumStorageMetricsByDateResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SumStorageMetricsByDateResponseBodyData> Data { get; set; }
        public class SumStorageMetricsByDateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The date of the statistics. The format is yyyyMMdd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20250719</para>
            /// </summary>
            [NameInMap("dateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            /// <summary>
            /// <para>The list of storage usage of a specified type.</para>
            /// </summary>
            [NameInMap("itemStorageMetrics")]
            [Validation(Required=false)]
            public List<SumStorageMetricsByDateResponseBodyDataItemStorageMetrics> ItemStorageMetrics { get; set; }
            public class SumStorageMetricsByDateResponseBodyDataItemStorageMetrics : TeaModel {
                /// <summary>
                /// <para>If the type is PROJECT, this parameter indicates the project name. If the type is STORAGE_TYPE, this parameter indicates the storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prj</para>
                /// </summary>
                [NameInMap("itemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <para>The percentage of the storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>91.22</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

                /// <summary>
                /// <para>The storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300.560392</para>
                /// </summary>
                [NameInMap("usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

            /// <summary>
            /// <para>The storage type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Storage: Standard.</para>
            /// </description></item>
            /// <item><description><para>LowFreqStorage: Infrequent Access (IA).</para>
            /// </description></item>
            /// <item><description><para>ColdStorage: Archive.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Storage</para>
            /// </summary>
            [NameInMap("storageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The unit of the total storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// <para>The total storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>329.503338</para>
            /// </summary>
            [NameInMap("usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para>1xx: Informational. The request is received and the process is continuing.</para>
        /// </description></item>
        /// <item><description><para>2xx: Success. The request is successfully received, understood, and accepted.</para>
        /// </description></item>
        /// <item><description><para>3xx: Redirection. Further action needs to be taken to complete the request.</para>
        /// </description></item>
        /// <item><description><para>4xx: Client Error. The request contains bad syntax or cannot be fulfilled.</para>
        /// </description></item>
        /// <item><description><para>5xx: Server Error. The server fails to fulfill an apparently valid request.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0abb781a17411408145995819e0dae</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
