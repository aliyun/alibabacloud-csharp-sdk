// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRefDISyncTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRefDISyncTasksResponseBodyData Data { get; set; }
        public class ListRefDISyncTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the synchronization tasks. In most cases, a data source is used by multiple synchronization tasks. Therefore, the value of this parameter is an array. The following parameters are the elements in the array. The sample values of these parameters show the details of a synchronization task.</para>
            /// </summary>
            [NameInMap("DISyncTasks")]
            [Validation(Required=false)]
            public List<ListRefDISyncTasksResponseBodyDataDISyncTasks> DISyncTasks { get; set; }
            public class ListRefDISyncTasksResponseBodyDataDISyncTasks : TeaModel {
                /// <summary>
                /// <para>The destination of the synchronization task. If the synchronization task has multiple destinations, the return value is a JSON array, such as \\&quot;odps_writer\\&quot;, \\&quot;mysql\\&quot;. If the RefType parameter is set to to, the synchronization tasks that use the specified data source as the destination are returned. In this case, the value of this parameter indicates the specified data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[\&quot;qcc_polardb2\&quot;]</para>
                /// </summary>
                [NameInMap("DiDestinationDatasource")]
                [Validation(Required=false)]
                public string DiDestinationDatasource { get; set; }

                /// <summary>
                /// <para>The source of the synchronization task. If the synchronization task has multiple sources, the return value is a JSON array, such as \\&quot;odps_writer\\&quot;, \\&quot;mysql\\&quot;. If the RefType parameter is set to from, the synchronization tasks that use the specified data source as the source are returned. In this case, the value of this parameter indicates the specified data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[\&quot;odps_writer\&quot;]</para>
                /// </summary>
                [NameInMap("DiSourceDatasource")]
                [Validation(Required=false)]
                public string DiSourceDatasource { get; set; }

                /// <summary>
                /// <para>The ID of the synchronization task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The name of the synchronization task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd1234</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The type of the synchronization task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DI_OFFLINE: batch synchronization task</description></item>
                /// <item><description>DI_REALTIME: real-time synchronization task</description></item>
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
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
