// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRefDISyncTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRefDISyncTasksResponseBodyData Data { get; set; }
        public class ListRefDISyncTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The array of returned data. Typically, a target data source is associated with multiple data integration synchronization tasks. When you call the ListRefDISyncTasks operation to query the synchronization tasks associated with the target data source, the returned result is an array of the associated synchronization tasks. The following information is an example of a synchronization task in the array.</para>
            /// </summary>
            [NameInMap("DISyncTasks")]
            [Validation(Required=false)]
            public List<ListRefDISyncTasksResponseBodyDataDISyncTasks> DISyncTasks { get; set; }
            public class ListRefDISyncTasksResponseBodyDataDISyncTasks : TeaModel {
                /// <summary>
                /// <para>The destination data source of the current synchronization task associated with the target data source. If the current synchronization task has multiple destination data sources, multiple destination data sources are returned in a JSON array, such as [&quot;odps_writer&quot;, &quot;mysql&quot;]. If the RefType parameter is set to to, which means the target data source serves as the destination of the data integration synchronization task, the value of this parameter is the target data source itself.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[\&quot;qcc_polardb2\&quot;]</para>
                /// </summary>
                [NameInMap("DiDestinationDatasource")]
                [Validation(Required=false)]
                public string DiDestinationDatasource { get; set; }

                /// <summary>
                /// <para>The source data source of the current synchronization task associated with the target data source. If the current synchronization task has multiple source data sources, multiple source data sources are returned in a JSON array, such as [&quot;odps_writer&quot;, &quot;mysql&quot;]. If the RefType parameter is set to from, which means the target data source serves as the source of the data integration synchronization task, the value of this parameter is the target data source itself.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[\&quot;odps_writer\&quot;]</para>
                /// </summary>
                [NameInMap("DiSourceDatasource")]
                [Validation(Required=false)]
                public string DiSourceDatasource { get; set; }

                /// <summary>
                /// <para>The ID of the current data integration synchronization task associated with the target data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The name of the current data integration synchronization task associated with the target data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd1234</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The type of the current data integration synchronization task associated with the target data source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DI_OFFLINE: Batch data integration synchronization task.</description></item>
                /// <item><description>DI_REALTIME: Real-time data integration synchronization task.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DI_OFFLINE</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937635973****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
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
