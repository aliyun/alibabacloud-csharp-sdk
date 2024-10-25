// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHBaseRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorHBaseRegionResponseBodyData Data { get; set; }
        public class GetDoctorHBaseRegionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Metrics information.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorHBaseRegionResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorHBaseRegionResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <para>Number of read requests in a single day.</para>
                /// </summary>
                [NameInMap("DailyReadRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseRegionResponseBodyDataMetricsDailyReadRequest DailyReadRequest { get; set; }
                public class GetDoctorHBaseRegionResponseBodyDataMetricsDailyReadRequest : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of read requests per day</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dailyReadRequest</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Number of write requests in a single day.</para>
                /// </summary>
                [NameInMap("DailyWriteRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseRegionResponseBodyDataMetricsDailyWriteRequest DailyWriteRequest { get; set; }
                public class GetDoctorHBaseRegionResponseBodyDataMetricsDailyWriteRequest : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of write requests per day</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dailyWriteRequest</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Store file count.</para>
                /// </summary>
                [NameInMap("StoreFileCount")]
                [Validation(Required=false)]
                public GetDoctorHBaseRegionResponseBodyDataMetricsStoreFileCount StoreFileCount { get; set; }
                public class GetDoctorHBaseRegionResponseBodyDataMetricsStoreFileCount : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of store file</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>storeFileCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Total read request count</para>
                /// </summary>
                [NameInMap("TotalReadRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseRegionResponseBodyDataMetricsTotalReadRequest TotalReadRequest { get; set; }
                public class GetDoctorHBaseRegionResponseBodyDataMetricsTotalReadRequest : TeaModel {
                    /// <summary>
                    /// <para>Metric description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Total read request</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>totalReadRequest</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Metric unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Total write request count</para>
                /// </summary>
                [NameInMap("TotalWriteRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseRegionResponseBodyDataMetricsTotalWriteRequest TotalWriteRequest { get; set; }
                public class GetDoctorHBaseRegionResponseBodyDataMetricsTotalWriteRequest : TeaModel {
                    /// <summary>
                    /// <para>Metric description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Total Write Request</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>totalWriteRequest</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Metric unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

            }

            /// <summary>
            /// <para>Host of the RegionServer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr-worker-2.cluster-20****</para>
            /// </summary>
            [NameInMap("RegionServerHost")]
            [Validation(Required=false)]
            public string RegionServerHost { get; set; }

            /// <summary>
            /// <para>Table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tb_item</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
