// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class InstallCloudAppShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Cloud application ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Page number for paged queries of instance associations under the project. Paged queries default to reverse order by instance association time. This applies only when ProjectId is not empty. It limits the maximum number of instances for actions within the project, controlling the impact scope. Default is 1.</para>
        /// <ol>
        /// <item><description><para>PageNumber value range:
        /// a. Method one (recommended): Calculate the upper limit using the total number of instances associated with the project. The ListRenderingProjectInstances interface provides this count.
        /// b. Method two: Determine if PageNumber reaches the project\&quot;s upper limit by checking the interface return value. This avoids calculating the range. PageNumber reaches the upper limit if the interface returns any of these conditions:
        /// ⅰ. A 403 status code and error code 200301.
        /// ⅱ. The sum of \<c>SuccessInstanceCount\\</c> and \<c>FailedInstanceCount\\</c> is less than \<c>PageSize\\</c>.</para>
        /// </description></item>
        /// <item><description><para>Scenario examples:
        /// a. Full installation for project instances: If the number of project instances exceeds \<c>PageSize\\</c> (default 100), invoke Install multiple times. Increment PageNumber by 1 for each call to complete the full installation. Get project instance installation progress using the ListCloudAppInstallations interface.
        /// b. New instance installation for a project: Start with \<c>PageNumber=1\\</c>. Paged queries default to reverse order by instance association time. The \<c>PageNumber=1\\</c> page shows the latest new instances.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Maximum number of instances selected for the project. This applies only when ProjectId is not empty. It limits the maximum number of instances for actions within the project, controlling the impact scope. Default is 100. The value range is 1-100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Patch package ID to install. This is only for Windows scenarios.</para>
        /// <ol>
        /// <item><description><para>Install \<c>StablePatchId\\</c> by default.</para>
        /// </description></item>
        /// <item><description><para>Enter \<c>origin\\</c> to install the original version.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>patch-7bdf679812484df08a956b73e0b3bdf6</para>
        /// </summary>
        [NameInMap("PatchId")]
        [Validation(Required=false)]
        public string PatchId { get; set; }

        /// <summary>
        /// <para>Project ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-422bc38dfgh5eb44149f135ef76304f63b</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>Cloud application service instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        /// <summary>
        /// <para>List of cloud application service instance IDs</para>
        /// </summary>
        [NameInMap("RenderingInstanceIds")]
        [Validation(Required=false)]
        public string RenderingInstanceIdsShrink { get; set; }

    }

}
