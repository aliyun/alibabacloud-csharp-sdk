// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetAuthCodeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application to connect to. When specifying this parameter, you must also provide the matching AppVersionId. If omitted, the application configured in the building or validation environment is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-bp1example****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the application version to connect to. This parameter is used together with AppId. This parameter is not the image version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apv-bp1example****</para>
        /// </summary>
        [NameInMap("AppVersionId")]
        [Validation(Required=false)]
        public string AppVersionId { get; set; }

        /// <summary>
        /// <para>The region compatibility parameter. The destination region of the current connection resource is determined by the execution region of the task. You cannot use this parameter to switch the task region. Omit this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The type of the resource to connect to.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BUILDER</b>: Connects to the building environment.</description></item>
        /// <item><description><b>VALIDATE</b>: Connects to the validation environment.</description></item>
        /// </list>
        /// <para>The corresponding environment must be created and in a connectable state.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUILDER</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the existing building or validation task. Create the task and confirm that the corresponding resources are available before calling this operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tid-bp1example****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The actual type of the task. It must be consistent with the building or validation task corresponding to TaskId. Use the TaskType returned by GetTask. The task must also have connectable building or validation resources. You cannot obtain an authorization code for distribution or snapshot tasks that do not have connection resources.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AUTO_CREATE_IMAGE_VHD</b>: Automatically builds a VHD image.</description></item>
        /// <item><description><b>RETRY_CREATE_IMAGE_VHD</b>: Retries building a VHD image.</description></item>
        /// <item><description><b>AUTO_CREATE_VHD</b>: Automatically builds a VHD.</description></item>
        /// <item><description><b>RETRY_VHD</b>: Retries building a VHD.</description></item>
        /// <item><description><b>AUTO_VALIDATE_VHD</b>: Automatically validates a VHD.</description></item>
        /// <item><description><b>RETRY_VALIDATE_VHD</b>: Retries validating a VHD.</description></item>
        /// <item><description><b>APPLY_VHD_BUILDER</b>: Applies for a VHD application recording environment.</description></item>
        /// <item><description><b>ADAPT_AUTO</b>: Automatically builds application adaptation.</description></item>
        /// <item><description><b>ADAPT_AUTO_RETRY</b>: Retries automatically building application adaptation.</description></item>
        /// <item><description><b>ADAPT_MANUAL</b>: Manually builds application adaptation.</description></item>
        /// <item><description><b>ADAPT_MANUAL_RETRY</b>: Retries manually building application adaptation.</description></item>
        /// <item><description><b>DESKTOP_CUSTOM_IMAGE</b>: Creates a custom image for a cloud desktop.</description></item>
        /// <item><description><b>DESKTOP_CUSTOM_IMAGE_RETRY</b>: Retries creating a custom image for a cloud desktop.</description></item>
        /// <item><description><b>IMAGE_MANUAL</b>: Manually builds an image.</description></item>
        /// <item><description><b>IMAGE_MANUAL_RETRY</b>: Retries manually building an image.</description></item>
        /// <item><description><b>IMAGE_FROM_INSTANCE</b>: Builds an image based on an instance.</description></item>
        /// <item><description><b>IMAGE_FROM_INSTANCE_RETRY</b>: Retries building an image based on an instance.</description></item>
        /// <item><description><b>IMAGE_DISTRIBUTE</b>: Distributes an image to multiple regions.</description></item>
        /// <item><description><b>IMAGE_DISTRIBUTE_RETRY</b>: Retries distributing an image.</description></item>
        /// <item><description><b>SNAPSHOT_DISTRIBUTE</b>: Distributes a snapshot to multiple regions.</description></item>
        /// <item><description><b>SNAPSHOT_DISTRIBUTE_RETRY</b>: Retries distributing a snapshot.</description></item>
        /// <item><description><b>SNAPSHOT_FROM_DISK</b>: Creates a snapshot based on a disk.</description></item>
        /// <item><description><b>SNAPSHOT_FROM_DISK_RETRY</b>: Retries creating a snapshot based on a disk.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE_MANUAL</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
