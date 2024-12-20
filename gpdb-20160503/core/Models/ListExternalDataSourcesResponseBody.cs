// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListExternalDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The Hadoop external table services.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListExternalDataSourcesResponseBodyItems> Items { get; set; }
        public class ListExternalDataSourcesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the service was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-09-08T16:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DataSourceDescription")]
            [Validation(Required=false)]
            public string DataSourceDescription { get; set; }

            /// <summary>
            /// <para>The service directory in which Hadoop-related configuration files are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HadoopDir</para>
            /// </summary>
            [NameInMap("DataSourceDir")]
            [Validation(Required=false)]
            public string DataSourceDir { get; set; }

            /// <summary>
            /// <para>The service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public int? DataSourceId { get; set; }

            /// <summary>
            /// <para>The name of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdfs_pxf</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>The status of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>init</description></item>
            /// <item><description>running</description></item>
            /// <item><description>exception</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DataSourceStatus")]
            [Validation(Required=false)]
            public string DataSourceStatus { get; set; }

            /// <summary>
            /// <para>The type of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HDFS</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <para>The Id of external data service</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ExternalDataServiceId")]
            [Validation(Required=false)]
            public int? ExternalDataServiceId { get; set; }

            /// <summary>
            /// <para>The time when the service was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-08T16:00:00Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The information about the service status. For example, if the service is in the exception state, the cause of the exception is displayed. If the service is in the running state, this parameter is left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

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
        /// <para>BBE00C04-A3E8-4114-881D-0480A72CB92E</para>
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
