// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetAuthCodeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application to connect to. When specifying this parameter, you must also provide the matching AppVersionId. If omitted, the application configured in the creation or validation environment is used.</para>
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
        /// <para>The type of the resource to connect to. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BUILDER</b>: connect to the creation environment</description></item>
        /// <item><description><b>VALIDATE</b>: connect to the validation environment</description></item>
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
        /// <para>The ID of the existing creation or validation task. Create the task and confirm that the corresponding resources are available before calling this operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tid-bp1example****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The actual task type. It must match the creation or validation task corresponding to the TaskId. Use the TaskType returned by GetTask. The task must also have connectable creation or validation resources. You cannot obtain an authorization code for distribution or snapshot tasks that do not have connection resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AUTO_CREATE_IMAGE_VHD</b>: automatically create a VHD image</description></item>
        /// <item><description><b>RETRY_CREATE_IMAGE_VHD</b>: retry VHD image creation</description></item>
        /// <item><description><b>AUTO_CREATE_VHD</b>: automatically create a VHD</description></item>
        /// <item><description><b>RETRY_VHD</b>: retry VHD creation</description></item>
        /// <item><description><b>AUTO_VALIDATE_VHD</b>: automatically validate a VHD</description></item>
        /// <item><description><b>RETRY_VALIDATE_VHD</b>: retry VHD validation</description></item>
        /// <item><description><b>APPLY_VHD_BUILDER</b>: apply for a VHD application recording environment</description></item>
        /// <item><description><b>ADAPT_AUTO</b>: automatically create application adaptation</description></item>
        /// <item><description><b>ADAPT_AUTO_RETRY</b>: retry automatic application adaptation creation</description></item>
        /// <item><description><b>ADAPT_MANUAL</b>: manually create application adaptation</description></item>
        /// <item><description><b>ADAPT_MANUAL_RETRY</b>: retry manual application adaptation creation</description></item>
        /// <item><description><b>DESKTOP_CUSTOM_IMAGE</b>: create a custom image for cloud desktop</description></item>
        /// <item><description><b>DESKTOP_CUSTOM_IMAGE_RETRY</b>: retry custom image creation for cloud desktop</description></item>
        /// <item><description><b>IMAGE_MANUAL</b>: manually create an image</description></item>
        /// <item><description><b>IMAGE_MANUAL_RETRY</b>: retry manual image creation</description></item>
        /// <item><description><b>IMAGE_FROM_INSTANCE</b>: create an image from an instance</description></item>
        /// <item><description><b>IMAGE_FROM_INSTANCE_RETRY</b>: retry image creation from an instance</description></item>
        /// <item><description><b>IMAGE_DISTRIBUTE</b>: distribute an image to multiple regions</description></item>
        /// <item><description><b>IMAGE_DISTRIBUTE_RETRY</b>: retry image distribution</description></item>
        /// <item><description><b>SNAPSHOT_DISTRIBUTE</b>: distribute a snapshot to multiple regions</description></item>
        /// <item><description><b>SNAPSHOT_DISTRIBUTE_RETRY</b>: retry snapshot distribution</description></item>
        /// <item><description><b>SNAPSHOT_FROM_DISK</b>: create a snapshot from a disk</description></item>
        /// <item><description><b>SNAPSHOT_FROM_DISK_RETRY</b>: retry snapshot creation from a disk</description></item>
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
