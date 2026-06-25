// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeChangeOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A client-side error occurred.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server-side error occurred.</para>
        /// </description></item>
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
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bbbbb-3fd370b2-3646-4ba6-91f9-9423e19ab0cd-*****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-test</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>Indicates whether gray tag routing is enabled.</para>
            /// </summary>
            [NameInMap("ApplicationEnableGreyTagRoute")]
            [Validation(Required=false)]
            public bool? ApplicationEnableGreyTagRoute { get; set; }

            /// <summary>
            /// <para>The update strategy for the application.</para>
            /// </summary>
            [NameInMap("ApplicationUpdateStrategy")]
            [Validation(Required=false)]
            public string ApplicationUpdateStrategy { get; set; }

            /// <summary>
            /// <para>The approval ID for the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>67de0b39-a9d4-4c09-a170-cf438208****</para>
            /// </summary>
            [NameInMap("ApprovalId")]
            [Validation(Required=false)]
            public string ApprovalId { get; set; }

            /// <summary>
            /// <para>Indicates whether to automatically release the change in batches. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The change is automatically released.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The change is not automatically released.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Auto")]
            [Validation(Required=false)]
            public bool? Auto { get; set; }

            /// <summary>
            /// <para>The number of batches.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BatchCount")]
            [Validation(Required=false)]
            public int? BatchCount { get; set; }

            /// <summary>
            /// <para>The release mode for batches. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>auto</b>: Automatic release.</para>
            /// </description></item>
            /// <item><description><para><b>manual</b>: Manual release.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("BatchType")]
            [Validation(Required=false)]
            public string BatchType { get; set; }

            /// <summary>
            /// <para>The wait time, in minutes, between batches in an automatic release.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BatchWaitTime")]
            [Validation(Required=false)]
            public int? BatchWaitTime { get; set; }

            /// <summary>
            /// <para>The change order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>765fa5c0-9ebb-4bb4-b383-1f885447**</para>
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

            /// <summary>
            /// <para>The change type. This parameter is a description of <c>CoTypeCode</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Batch Restart Instances</para>
            /// </summary>
            [NameInMap("CoType")]
            [Validation(Required=false)]
            public string CoType { get; set; }

            /// <summary>
            /// <para>The change type code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CoBindSlb</b>: Binds an SLB instance.</para>
            /// </description></item>
            /// <item><description><para><b>CoUnbindSlb</b>: Unbinds an SLB instance.</para>
            /// </description></item>
            /// <item><description><para><b>CoCreateApp</b>: Creates an application.</para>
            /// </description></item>
            /// <item><description><para><b>CoDeleteApp</b>: Deletes an application.</para>
            /// </description></item>
            /// <item><description><para><b>CoDeploy</b>: Deploys an application.</para>
            /// </description></item>
            /// <item><description><para><b>CoRestartApplication</b>: Restarts an application.</para>
            /// </description></item>
            /// <item><description><para><b>CoRollback</b>: Rolls back an application.</para>
            /// </description></item>
            /// <item><description><para><b>CoScaleIn</b>: Scales in an application.</para>
            /// </description></item>
            /// <item><description><para><b>CoScaleOut</b>: Scales out an application.</para>
            /// </description></item>
            /// <item><description><para><b>CoStart</b>: Starts an application.</para>
            /// </description></item>
            /// <item><description><para><b>CoStop</b>: Stops an application.</para>
            /// </description></item>
            /// <item><description><para><b>CoRescaleApplicationVertically</b>: Modifies instance specifications.</para>
            /// </description></item>
            /// <item><description><para><b>CoDeployHistroy</b>: Rolls back to a historical version.</para>
            /// </description></item>
            /// <item><description><para><b>CoBindNas</b>: Binds a NAS file system.</para>
            /// </description></item>
            /// <item><description><para><b>CoUnbindNas</b>: Unbinds a NAS file system.</para>
            /// </description></item>
            /// <item><description><para><b>CoBatchStartApplication</b>: Starts applications in batches.</para>
            /// </description></item>
            /// <item><description><para><b>CoBatchStopApplication</b>: Stops applications in batches.</para>
            /// </description></item>
            /// <item><description><para><b>CoRestartInstances</b>: Restarts instances.</para>
            /// </description></item>
            /// <item><description><para><b>CoDeleteInstances</b>: Deletes instances.</para>
            /// </description></item>
            /// <item><description><para><b>CoScaleInAppWithInstances</b>: Scales in an application by specifying instances.</para>
            /// </description></item>
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
                /// <para>The batch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e4acf82-c9b1-4c1e-ac28-55776338****</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// <para>The batch name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Batch 1 Change</para>
                /// </summary>
                [NameInMap("PipelineName")]
                [Validation(Required=false)]
                public string PipelineName { get; set; }

                /// <summary>
                /// <para>The start time of the batch.</para>
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
                /// <item><description><para><b>0</b>: Preparing</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: In progress</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Succeeded</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: Failed</para>
                /// </description></item>
                /// <item><description><para><b>6</b>: Terminated</para>
                /// </description></item>
                /// <item><description><para><b>8</b>: Awaiting manual confirmation</para>
                /// </description></item>
                /// <item><description><para><b>9</b>: Awaiting automatic confirmation</para>
                /// </description></item>
                /// <item><description><para><b>10</b>: Failed due to a system error</para>
                /// </description></item>
                /// <item><description><para><b>11</b>: Pending approval</para>
                /// </description></item>
                /// <item><description><para><b>12</b>: Approved and pending execution</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The time when the batch was last updated.</para>
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
            /// <item><description><para><b>0</b>: Preparing</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: In progress</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Succeeded</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Failed</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: Terminated</para>
            /// </description></item>
            /// <item><description><para><b>8</b>: Awaiting manual confirmation</para>
            /// </description></item>
            /// <item><description><para><b>9</b>: Awaiting automatic confirmation</para>
            /// </description></item>
            /// <item><description><para><b>10</b>: Failed due to a system error</para>
            /// </description></item>
            /// <item><description><para><b>11</b>: Pending approval</para>
            /// </description></item>
            /// <item><description><para><b>12</b>: Approved and pending execution</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The substatus of the release order. This parameter indicates whether an exception occurred during the release. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Normal.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Abnormal. For example, if a batch release fails, you must manually perform a rollback, leaving the release order in the In Progress state.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SubStatus")]
            [Validation(Required=false)]
            public int? SubStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether rollback is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Rollback is supported.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Rollback is not supported.</para>
            /// </description></item>
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
        /// <item><description><para>If the request is successful, this parameter is not returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, this parameter is returned. For more information, see the <b>error codes</b> section of this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID of the request. This ID is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
