// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDISyncInstanceInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the real-time synchronization task or data synchronization solution.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDISyncInstanceInfoResponseBodyData Data { get; set; }
        public class GetDISyncInstanceInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cause of the failure to obtain the status of the real-time synchronization task or data synchronization solution. If the status of the real-time synchronization task or data synchronization solution is obtained, the value null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fileId[100] is invalid</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>If the TaskType parameter is set to DI_REALTIME, the Name parameter indicates the name of the real-time synchronization task.</description></item>
            /// <item><description>If the TaskType parameter is set to DI_SOLUTION, the value null is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>streamx_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>If the TaskType parameter is set to DI_REALTIME, the value null is returned.</description></item>
            /// <item><description>If the TaskType parameter is set to DI_SOLUTION, the SolutionInfo parameter indicates the details of the data synchronization solution.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SolutionInfo")]
            [Validation(Required=false)]
            public GetDISyncInstanceInfoResponseBodyDataSolutionInfo SolutionInfo { get; set; }
            public class GetDISyncInstanceInfoResponseBodyDataSolutionInfo : TeaModel {
                /// <summary>
                /// <para>The creator of the data synchronization solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataworks_3h1</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The ID of the data synchronization solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The status of the data synchronization solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>run</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The step details of the data synchronization solution.</para>
                /// </summary>
                [NameInMap("StepDetail")]
                [Validation(Required=false)]
                public List<GetDISyncInstanceInfoResponseBodyDataSolutionInfoStepDetail> StepDetail { get; set; }
                public class GetDISyncInstanceInfoResponseBodyDataSolutionInfoStepDetail : TeaModel {
                    /// <summary>
                    /// <para>The information of the data synchronization solution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;fusionProps\&quot;:{\&quot;dataSource\&quot;:[{\&quot;fileName\&quot;:\&quot;holo_20221020161613\&quot;,\&quot;status\&quot;:\&quot;SUCCESS\&quot;}]},\&quot;customProps\&quot;:{\&quot;showSN\&quot;:true,\&quot;columns\&quot;:[{\&quot;dataIndex\&quot;:\&quot;fileName\&quot;,\&quot;width\&quot;:0.8,\&quot;title\&quot;:\&quot;Real-time synchronization name\&quot;},{\&quot;dataIndex\&quot;:\&quot;status\&quot;,\&quot;width\&quot;:0.2,\&quot;title\&quot;:\&quot;Status\&quot;}]},\&quot;componentName\&quot;:\&quot;Table\&quot;}</para>
                    /// </summary>
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public string Info { get; set; }

                    /// <summary>
                    /// <para>The status of the step in the data synchronization solution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The ID of the step in the data synchronization solution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("StepId")]
                    [Validation(Required=false)]
                    public long? StepId { get; set; }

                    /// <summary>
                    /// <para>The name of the step in the data synchronization solution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Create a base table</para>
                    /// </summary>
                    [NameInMap("StepName")]
                    [Validation(Required=false)]
                    public string StepName { get; set; }

                }

            }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>If the TaskType parameter is set to DI_REALTIME, the Status parameter indicates the status of the real-time synchronization task. Valid values: PAUSE, NORUN, RUN, KILLING, and WAIT.</description></item>
            /// <item><description>If the TaskType parameter is set to DI_SOLUTION, the Status parameter indicates the status of the data synchronization solution. Valid values: success and fail.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUN</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
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
