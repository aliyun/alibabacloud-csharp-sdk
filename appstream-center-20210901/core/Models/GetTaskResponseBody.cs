// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter is returned when the request fails. A successful response may not contain this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The task details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTaskResponseBodyData Data { get; set; }
        public class GetTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100931896542****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The prompt or execution result description of the current task step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[code=Builder.Failed,httpStatusCode=<null>,message=Builder environment deploy failed.]</para>
            /// </summary>
            [NameInMap("CurrentTaskMessage")]
            [Validation(Required=false)]
            public string CurrentTaskMessage { get; set; }

            /// <summary>
            /// <para>The identifier of the step that the task is currently executing. You can call the ListTaskStep operation to query the image creation and application adaptation steps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE_BUILDER_ENV</para>
            /// </summary>
            [NameInMap("CurrentTaskStep")]
            [Validation(Required=false)]
            public string CurrentTaskStep { get; set; }

            /// <summary>
            /// <para>The ID of the region where the task is actually executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ExecuteRegion")]
            [Validation(Required=false)]
            public string ExecuteRegion { get; set; }

            /// <summary>
            /// <para>The time when the task was created. The time is in ISO 8601 format, accurate to milliseconds, and the time zone offset is +00:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T02:28:10.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the task was last updated. The time is in ISO 8601 format, accurate to milliseconds, and the time zone offset is +00:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T02:32:43.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The compute type of the task creation resource.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CPU</b>: CPU compute resource.</description></item>
            /// <item><description><b>GPU</b>: GPU compute resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CPU</para>
            /// </summary>
            [NameInMap("PerformanceType")]
            [Validation(Required=false)]
            public string PerformanceType { get; set; }

            /// <summary>
            /// <para><b>Not enabled. The system does not return valid task progress.</b> Determine the task execution status based on Status, CurrentTaskStep, and TaskStepList.</para>
            /// <para>The example &quot;Not applicable (not enabled)&quot; is only a description of the field status and is not an actual API response example.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Not applicable (not enabled)</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The list of resources used for task creation, which corresponds to the creation resources submitted when the task is created.</para>
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<GetTaskResponseBodyDataResourceList> ResourceList { get; set; }
            public class GetTaskResponseBodyDataResourceList : TeaModel {
                /// <summary>
                /// <para>The resource content corresponding to ResourceType. For the URL type, specify or return an accessible resource address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/apps/business/setup.exe">https://example.com/apps/business/setup.exe</a></para>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

                /// <summary>
                /// <para>The provision method of the resource content.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>HOSTED</b>: Hosted resource.</description></item>
                /// <item><description><b>TEXT</b>: Text resource.</description></item>
                /// <item><description><b>URL</b>: Resource provided through a URL.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>URL</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The running mode of the task creation environment.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NORMAL</b>: Normal running mode.</description></item>
            /// <item><description><b>COMPATIBLE</b>: Compatible running mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("RunMode")]
            [Validation(Required=false)]
            public string RunMode { get; set; }

            /// <summary>
            /// <para>The overall status of the task.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The task is initialized.</description></item>
            /// <item><description><b>START</b>: The task is being created or executed.</description></item>
            /// <item><description><b>SUCCESS</b>: The task is executed successfully.</description></item>
            /// <item><description><b>FAILED</b>: The task fails to be executed.</description></item>
            /// <item><description><b>DELETED</b>: The task is deleted.</description></item>
            /// </list>
            /// <para>Deleted tasks are not included in the regular valid task query scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>START</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The capacity of the system cloud disk in the task creation environment. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The ID of the base system image used in the task creation environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-bp1parent****</para>
            /// </summary>
            [NameInMap("SystemImageId")]
            [Validation(Required=false)]
            public string SystemImageId { get; set; }

            /// <summary>
            /// <para>The task ID. You can use this ID to call the GetTask operation to query the task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tid-bp1example****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The list of recorded task execution steps and results.</para>
            /// </summary>
            [NameInMap("TaskStepList")]
            [Validation(Required=false)]
            public List<GetTaskResponseBodyDataTaskStepList> TaskStepList { get; set; }
            public class GetTaskResponseBodyDataTaskStepList : TeaModel {
                /// <summary>
                /// <para>The end time of the step. It is a UNIX timestamp calculated from 1970-01-01T00:00:00Z. Unit: milliseconds. This parameter may not be returned if the step has not ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1790130491000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The start time of the step. It is a UNIX timestamp calculated from 1970-01-01T00:00:00Z. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1790130490000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The execution status of the step.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>RUNNING</b>: The step is executing.</description></item>
                /// <item><description><b>SUCCESS</b>: The step is executed successfully.</description></item>
                /// <item><description><b>FAILED</b>: The step fails to be executed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The end time of the step in ISO 8601 format, including the time zone offset. In the example, +08:00 indicates UTC+8. This parameter represents the same time as EndTime and is parsed based on the offset in the return value. This parameter may not be returned if the step has not ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-23T10:28:11+08:00</para>
                /// </summary>
                [NameInMap("StepEndTime")]
                [Validation(Required=false)]
                public string StepEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the step in ISO 8601 format, including the time zone offset. In the example, +08:00 indicates UTC+8. This parameter represents the same time as StartTime and is parsed based on the offset in the return value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-23T10:28:10+08:00</para>
                /// </summary>
                [NameInMap("StepStartTime")]
                [Validation(Required=false)]
                public string StepStartTime { get; set; }

                /// <summary>
                /// <para>The prompt or execution result description of this step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[code=Builder.Failed,httpStatusCode=<null>,message=Builder environment deploy failed.]</para>
                /// </summary>
                [NameInMap("TaskMessage")]
                [Validation(Required=false)]
                public string TaskMessage { get; set; }

                /// <summary>
                /// <para>The task step identifier corresponding to this record. You can call the ListTaskStep operation to query the image creation and application adaptation steps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE_BUILDER_ENV</para>
                /// </summary>
                [NameInMap("TaskStep")]
                [Validation(Required=false)]
                public string TaskStep { get; set; }

            }

            /// <summary>
            /// <para>The actual type of the task.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AUTO_ADAPT</b>: Automatic adaptation.</description></item>
            /// <item><description><b>AUTO_CREATE_IMAGE</b>: Automatic image creation.</description></item>
            /// <item><description><b>RETRY_ADAPT</b>: Retry automatic adaptation.</description></item>
            /// <item><description><b>RETRY_CREATE_IMAGE</b>: Retry automatic image creation.</description></item>
            /// <item><description><b>AUTO_OTA_IMAGE</b>: Automatic image OTA.</description></item>
            /// <item><description><b>AUTO_CREATE_VHD</b>: Automatic VHD creation.</description></item>
            /// <item><description><b>RETRY_VHD</b>: Retry VHD creation.</description></item>
            /// <item><description><b>AUTO_CREATE_IMAGE_VHD</b>: Automatic VHD image creation.</description></item>
            /// <item><description><b>RETRY_CREATE_IMAGE_VHD</b>: Retry VHD image creation.</description></item>
            /// <item><description><b>AUTO_VALIDATE_VHD</b>: Automatic VHD validation.</description></item>
            /// <item><description><b>RETRY_VALIDATE_VHD</b>: Retry VHD validation.</description></item>
            /// <item><description><b>SYNCHRONIZE_APP_IMAGE</b>: Synchronize application image.</description></item>
            /// <item><description><b>APPLY_VHD_BUILDER</b>: Apply for VHD application recording environment.</description></item>
            /// <item><description><b>RETRY_VHD_BUILDER</b>: Retry applying for VHD recording environment.</description></item>
            /// <item><description><b>ADAPT_AUTO</b>: Automatic application adaptation creation.</description></item>
            /// <item><description><b>ADAPT_AUTO_RETRY</b>: Retry automatic application adaptation creation.</description></item>
            /// <item><description><b>ADAPT_MANUAL</b>: Manual application adaptation creation.</description></item>
            /// <item><description><b>ADAPT_MANUAL_RETRY</b>: Retry manual application adaptation creation.</description></item>
            /// <item><description><b>IMAGE_AUTO</b>: Automatic image creation.</description></item>
            /// <item><description><b>IMAGE_AUTO_RETRY</b>: Retry automatic image creation.</description></item>
            /// <item><description><b>IMAGE_AUTO_VALIDATE</b>: Automatic image validation.</description></item>
            /// <item><description><b>IMAGE_AUTO_VALIDATE_RETRY</b>: Retry automatic image validation.</description></item>
            /// <item><description><b>IMAGE_MANUAL</b>: Manual image creation.</description></item>
            /// <item><description><b>IMAGE_MANUAL_RETRY</b>: Retry manual image creation.</description></item>
            /// <item><description><b>DESKTOP_CUSTOM_IMAGE</b>: Create cloud desktop custom image.</description></item>
            /// <item><description><b>DESKTOP_CUSTOM_IMAGE_RETRY</b>: Retry creating cloud desktop custom image.</description></item>
            /// <item><description><b>DESKTOP_SYNC_IMAGE</b>: Synchronize cloud desktop image across regions.</description></item>
            /// <item><description><b>DESKTOP_SYNC_IMAGE_RETRY</b>: Retry synchronizing cloud desktop image across regions.</description></item>
            /// <item><description><b>IMAGE_DISTRIBUTE</b>: Distribute image to multiple regions.</description></item>
            /// <item><description><b>IMAGE_DISTRIBUTE_RETRY</b>: Retry image distribution.</description></item>
            /// <item><description><b>IMAGE_FROM_INSTANCE</b>: Create image based on instance.</description></item>
            /// <item><description><b>IMAGE_FROM_INSTANCE_RETRY</b>: Retry creating image based on instance.</description></item>
            /// <item><description><b>SNAPSHOT_DISTRIBUTE</b>: Distribute snapshot to multiple regions.</description></item>
            /// <item><description><b>SNAPSHOT_DISTRIBUTE_RETRY</b>: Retry snapshot distribution.</description></item>
            /// <item><description><b>SNAPSHOT_FROM_DISK</b>: Create snapshot based on disk.</description></item>
            /// <item><description><b>SNAPSHOT_FROM_DISK_RETRY</b>: Retry creating snapshot based on disk.</description></item>
            /// <item><description><b>IMAGE_CLEAN_AND_CREATE</b>: Create temporary instance based on image, clean it, and create final image.</description></item>
            /// <item><description><b>IMAGE_CLEAN_AND_CREATE_RETRY</b>: Retry creating final image after cleaning.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE_MANUAL</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The error or result message. This parameter describes the cause when the request fails. A successful response may not contain this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal error.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can provide this value for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A1A962-5503-107B-AC8F-EBA85DF905AC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was processed successfully. A value of true indicates that the request was processed successfully. To check whether an asynchronous task is completed, you must query the task status separately.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
