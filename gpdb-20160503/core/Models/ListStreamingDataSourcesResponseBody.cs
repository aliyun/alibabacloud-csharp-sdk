// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListStreamingDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried data sources.</para>
        /// </summary>
        [NameInMap("DataSourceItems")]
        [Validation(Required=false)]
        public List<ListStreamingDataSourcesResponseBodyDataSourceItems> DataSourceItems { get; set; }
        public class ListStreamingDataSourcesResponseBodyDataSourceItems : TeaModel {
            /// <summary>
            /// <para>The time when the data source was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-09-08T16:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The configurations of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;brokers&quot;:&quot;broker0:9091,broker1:9091&quot;,&quot;topic&quot;:&quot;topic&quot;}</para>
            /// </summary>
            [NameInMap("DataSourceConfig")]
            [Validation(Required=false)]
            public string DataSourceConfig { get; set; }

            /// <summary>
            /// <para>The description of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-kafka</para>
            /// </summary>
            [NameInMap("DataSourceDescription")]
            [Validation(Required=false)]
            public string DataSourceDescription { get; set; }

            /// <summary>
            /// <para>The data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public int? DataSourceId { get; set; }

            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-kafka</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>kafka</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>kafka</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <para>The information about the service status. For example, if the service is in the exception state, the cause of the exception is displayed. If the service is in the running state, this parameter is left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The time when the data source was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-09-08T17:00:00Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public int? ServiceId { get; set; }

            /// <summary>
            /// <para>The status of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>init</description></item>
            /// <item><description>running</description></item>
            /// <item><description>exception</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
