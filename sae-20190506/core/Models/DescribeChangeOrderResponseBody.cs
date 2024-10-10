// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeChangeOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: indicates that the request was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the request was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the request was invalid.</description></item>
        /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the change order.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeChangeOrderResponseBodyData Data { get; set; }
        public class DescribeChangeOrderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bbbbb-3fd370b2-3646-4ba6-91f9-9423e19ab0cd-*****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-test</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The approval ID of the change order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>67de0b39-a9d4-4c09-a170-cf438208****</para>
            /// </summary>
            [NameInMap("ApprovalId")]
            [Validation(Required=false)]
            public string ApprovalId { get; set; }

            /// <summary>
            /// <para>Indicates whether SAE automatically determines the release batches. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: SAE automatically determines the release batches.</description></item>
            /// <item><description><b>false</b>: SAE does not automatically determine the release batches.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Auto")]
            [Validation(Required=false)]
            public bool? Auto { get; set; }

            /// <summary>
            /// <para>The number of release batches.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BatchCount")]
            [Validation(Required=false)]
            public int? BatchCount { get; set; }

            /// <summary>
            /// <para>The mode in which the release batches are determined. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>auto</b>: SAE automatically determines the release batches.</description></item>
            /// <item><description><b>Manual</b>: You must manually determine the release batches.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("BatchType")]
            [Validation(Required=false)]
            public string BatchType { get; set; }

            /// <summary>
            /// <para>The interval between batches when SAE automatically determines the release batches in a phased release. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BatchWaitTime")]
            [Validation(Required=false)]
            public int? BatchWaitTime { get; set; }

            /// <summary>
            /// <para>The ID of the change order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>765fa5c0-9ebb-4bb4-b383-1f885447**</para>
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

            /// <summary>
            /// <para>The description about the change type, which corresponds to the <b>CoTypeCode</b> parameter.</para>
            /// </summary>
            [NameInMap("CoType")]
            [Validation(Required=false)]
            public string CoType { get; set; }

            /// <summary>
            /// <para>The code of the change type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CoBindSlb</b>: associates the Server Load Balancer (SLB) instance with the application.</description></item>
            /// <item><description><b>CoUnbindSlb</b>: disassociates the SLB instance from the application.</description></item>
            /// <item><description><b>CoCreateApp</b>: creates the application.</description></item>
            /// <item><description><b>CoDeleteApp</b>: deletes the application.</description></item>
            /// <item><description><b>CoDeploy</b>: deploys the application.</description></item>
            /// <item><description><b>CoRestartApplication</b>: restarts the application.</description></item>
            /// <item><description><b>CoRollback</b>: rolls back the application.</description></item>
            /// <item><description><b>CoScaleIn</b>: scales in the application.</description></item>
            /// <item><description><b>CoScaleOut</b>: scales out the application.</description></item>
            /// <item><description><b>CoStart</b>: starts the application.</description></item>
            /// <item><description><b>CoStop</b>: stops the application.</description></item>
            /// <item><description><b>CoRescaleApplicationVertically</b>: modifies the instance specifications.</description></item>
            /// <item><description><b>CoDeployHistroy</b>: rolls back the application to a historical version.</description></item>
            /// <item><description><b>CoBindNas</b>: associates a network-attached storage (NAS) file system with the application.</description></item>
            /// <item><description><b>CoUnbindNas</b>: disassociates the NAS file system from the application.</description></item>
            /// <item><description><b>CoBatchStartApplication</b>: starts multiple applications concurrently.</description></item>
            /// <item><description><b>CoBatchStopApplication</b>: stops multiple applications concurrently.</description></item>
            /// <item><description><b>CoRestartInstances</b>: restarts the instances.</description></item>
            /// <item><description><b>CoDeleteInstances</b>: deletes the instances.</description></item>
            /// <item><description><b>CoScaleInAppWithInstances</b>: reduces the number of specified application instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CoRestartInstances</para>
            /// </summary>
            [NameInMap("CoTypeCode")]
            [Validation(Required=false)]
            public string CoTypeCode { get; set; }

            /// <summary>
            /// <para>The time when the change order was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-17 21:06:45</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the current batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e4acf82-c9b1-4c1e-ac28-55776338****</para>
            /// </summary>
            [NameInMap("CurrentPipelineId")]
            [Validation(Required=false)]
            public string CurrentPipelineId { get; set; }

            /// <summary>
            /// <para>The description of the change order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The batch information.</para>
            /// </summary>
            [NameInMap("Pipelines")]
            [Validation(Required=false)]
            public List<DescribeChangeOrderResponseBodyDataPipelines> Pipelines { get; set; }
            public class DescribeChangeOrderResponseBodyDataPipelines : TeaModel {
                /// <summary>
                /// <para>The batch type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BatchType")]
                [Validation(Required=false)]
                public int? BatchType { get; set; }

                /// <summary>
                /// <para>The number of parallel tasks in a batch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ParallelCount")]
                [Validation(Required=false)]
                public int? ParallelCount { get; set; }

                /// <summary>
                /// <para>The ID of the batch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e4acf82-c9b1-4c1e-ac28-55776338****</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// <para>The name of the batch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Batch 1 Change</para>
                /// </summary>
                [NameInMap("PipelineName")]
                [Validation(Required=false)]
                public string PipelineName { get; set; }

                /// <summary>
                /// <para>The time when the batch processing starts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1562831689704</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The status of the batch. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The batch is being prepared.</description></item>
                /// <item><description><b>1</b>: The batch is being processed.</description></item>
                /// <item><description><b>2</b>: The batch was processed.</description></item>
                /// <item><description><b>3</b>: The batch could not be processed.</description></item>
                /// <item><description><b>6</b>: The batch processing was terminated.</description></item>
                /// <item><description><b>8</b>: The execution process is pending. You must manually determine the release batch.</description></item>
                /// <item><description><b>9</b>: The execution process is pending. SAE will automatically determine the release batch.</description></item>
                /// <item><description><b>10</b>: The batch could not be processed due to a system exception.</description></item>
                /// <item><description><b>11</b>: The change order is pending approval.</description></item>
                /// <item><description><b>12</b>: The change order is approved and is pending execution.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The time when the batch information is last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1562847178007</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The status of the change order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The change order is being prepared.</description></item>
            /// <item><description><b>1</b>: The change order is being executed.</description></item>
            /// <item><description><b>2</b>: The change order was executed.</description></item>
            /// <item><description><b>3</b>: The change order could not be executed.</description></item>
            /// <item><description><b>6</b>: The change order was terminated.</description></item>
            /// <item><description><b>8</b>: The execution process is pending. You must manually determine the release batch.</description></item>
            /// <item><description><b>9</b>: The execution process is pending. SAE will automatically determine the release batches.</description></item>
            /// <item><description><b>10</b>: The execution failed due to a system exception.</description></item>
            /// <item><description><b>11</b>: The change order is pending approval.</description></item>
            /// <item><description><b>12</b>: The change order is approved and is pending execution.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The substatus of the change order. This parameter indicates whether an exception occurred while the change order was being executed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No exception occurred.</description></item>
            /// <item><description><b>1</b>: An exception occurred. For example, when an error occurred during a phased release, you must manually roll back the application. In this case, the change order cannot be completed, so the Status parameter is still displayed as &quot;1&quot;, which indicates that the change order is being executed. You can check the value of this parameter to determine whether an exception occurs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SubStatus")]
            [Validation(Required=false)]
            public int? SubStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the application can be rolled back. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The application can be rolled back.</description></item>
            /// <item><description><b>false</b>: The application cannot be rolled back.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportRollback")]
            [Validation(Required=false)]
            public bool? SupportRollback { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description>The <b>ErrorCode</b> parameter is not returned when the request succeeds.</description></item>
        /// <item><description>The <b>ErrorCode</b> parameter is returned when the request fails. For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the information of a change order was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The information was obtained.</description></item>
        /// <item><description><b>false</b>: The information could not be obtained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace. It is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
