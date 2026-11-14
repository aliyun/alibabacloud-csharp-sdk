// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UpdateImageTaskRequest : TeaModel {
        /// <summary>
        /// <para><b>Not enabled. Do not pass this parameter.</b> The task region is determined by the associated creation resource. This parameter is not used to switch regions. The example &quot;N/A (not enabled)&quot; is only a description of the field status and is not a valid parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A (not enabled)</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para><b>Not enabled. Do not pass this parameter.</b> This parameter is not involved in task status updates. The example &quot;N/A (not enabled)&quot; is only a description of the field status and is not a valid parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A (not enabled)</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The status identifier reported by the creation resource. It must match the task type and the current creation stage. You cannot directly use the overall task status from GetTask as a substitute. Valid values for image creation tasks (IMAGE_MANUAL and IMAGE_MANUAL_RETRY):</para>
        /// <list type="bullet">
        /// <item><description><b>BUILDER_INIT_SUCCESS</b>: The creation environment is initialized.</description></item>
        /// <item><description><b>DOWNLOAD_SUCCESS</b>: The creation resource is downloaded.</description></item>
        /// <item><description><b>DOWNLOAD_FAILED</b>: The creation resource fails to be downloaded.</description></item>
        /// <item><description><b>BUILD_START</b>: The image creation starts.</description></item>
        /// <item><description><b>BUILD_SUCCESS</b>: The application installation and image configuration are successful.</description></item>
        /// <item><description><b>BUILD_FAILED</b>: The application installation or image configuration fails.</description></item>
        /// <item><description><b>BUILD_COMPLETE</b>: The creation is completed and the subsequent verification process starts.</description></item>
        /// <item><description><b>BUILD_COMPLETE_SKIP_VALIDATE</b>: The creation is completed in compatibility mode. Whether verification is performed depends on the task query result.
        /// Valid values for application adaptation tasks:</description></item>
        /// <item><description><b>BUILDER_INIT_SUCCESS</b>: The creation environment is initialized.</description></item>
        /// <item><description><b>DOWNLOAD_SUCCESS</b>: The application resource is downloaded.</description></item>
        /// <item><description><b>DOWNLOAD_FAILED</b>: The application resource fails to be downloaded.</description></item>
        /// <item><description><b>BUILD_START</b>: The application recording starts.</description></item>
        /// <item><description><b>BUILD_SUCCESS</b>: The application recording is successful.</description></item>
        /// <item><description><b>BUILD_FAILED</b>: The application recording fails.</description></item>
        /// <item><description><b>NAS_DISPATCH_SUCCESS</b>: The application files are distributed to NAS.</description></item>
        /// <item><description><b>NAS_DISPATCH_FAILED</b>: The application files fail to be distributed to NAS.</description></item>
        /// <item><description><b>OSS_UPLOAD_SUCCESS</b>: The application files are uploaded to OSS.</description></item>
        /// <item><description><b>OSS_UPLOAD_FAILED</b>: The application files fail to be uploaded to OSS.</description></item>
        /// <item><description><b>UPLOAD_SUCCESS</b>: The application files are uploaded.</description></item>
        /// <item><description><b>UPLOAD_FAILED</b>: The application files fail to be uploaded.</description></item>
        /// <item><description><b>BUILD_COMPLETE</b>: The application creation is completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUILD_START</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the task to be updated. The task and its creation resource must already exist.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tid-bp1example****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para><b>Not enabled. Do not pass this parameter.</b> This parameter is not supported for updating the task step. The example &quot;N/A (not enabled)&quot; is only a description of the field status and is not a valid parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A (not enabled)</para>
        /// </summary>
        [NameInMap("TaskStep")]
        [Validation(Required=false)]
        public string TaskStep { get; set; }

        /// <summary>
        /// <para>The actual type of the task to be updated, which must match the task specified by TaskId. Status updates support the following application adaptation and manual image creation tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ADAPT_AUTO</b>: Creates an application adaptation automatically.</description></item>
        /// <item><description><b>ADAPT_AUTO_RETRY</b>: Retries automatic application adaptation creation.</description></item>
        /// <item><description><b>ADAPT_MANUAL</b>: Creates an application adaptation manually.</description></item>
        /// <item><description><b>ADAPT_MANUAL_RETRY</b>: Retries manual application adaptation creation.</description></item>
        /// <item><description><b>IMAGE_MANUAL</b>: Creates an image manually.</description></item>
        /// <item><description><b>IMAGE_MANUAL_RETRY</b>: Retries manual image creation.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE_MANUAL</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para><b>Not enabled. Do not pass this parameter.</b> This parameter is not supported for modifying the image version associated with the task. The example &quot;N/A (not enabled)&quot; is only a description of the field status and is not a valid parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A (not enabled)</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
