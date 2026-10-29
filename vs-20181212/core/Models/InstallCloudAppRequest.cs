// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class InstallCloudAppRequest : TeaModel {
        /// <summary>
        /// <para>The cloud application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The page number for the paged query of instance associations under the project. By default, the paged query is sorted by instance association time in descending order. This parameter takes effect only when ProjectId is not empty. It limits the maximum number of instances on which the operation is executed under the project to control the impact scope. Default value: 1.</para>
        /// <ol>
        /// <item><description>About the value range of PageNumber:
        ///   a. [Recommended] Method 1: Calculate the upper limit based on the total number of instances associated with the project (you can call the ListRenderingProjectInstances operation to obtain the total number).
        ///   b. Method 2: Determine whether PageNumber has reached the upper limit of the project based on the response. [Advantage: You do not need to calculate the value range.] If the response meets either of the following conditions, PageNumber has reached the upper limit:
        ///  i. The response returns HTTP status code 403 and error code 200301.
        ///  ii. The response returns SuccessInstanceCount + FailedInstanceCount &lt; PageSize.</description></item>
        /// <item><description>Example scenarios:
        ///   a. Full installation for instances under a project: If the number of instances in the project is greater than PageSize (default value: 100), you can call the Install operation multiple times by incrementing PageNumber by 1 each time to perform a full installation. You can call the ListCloudAppInstallations operation to query the installation progress of the instances.
        ///   b. Installation for newly added instances under a project: Start with PageNumber=1. By default, the paged query is sorted by instance association time in descending order. The page with PageNumber=1 contains the most recently added instances.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of instances that can be selected under the project. This parameter takes effect only when ProjectId is not empty. It limits the maximum number of instances on which the operation is performed under the project to control the impact scope. Default value: 100. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The patch package ID to install. This parameter is supported only in Windows scenarios.</para>
        /// <ol>
        /// <item><description>By default, StablePatchId is installed.</description></item>
        /// <item><description>If you set the value to origin, the original version is installed.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>patch-7bdf679812484df08a956b73e0b3bdf6</para>
        /// </summary>
        [NameInMap("PatchId")]
        [Validation(Required=false)]
        public string PatchId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-422bc38dfgh5eb44149f135ef76304f63b</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The cloud application service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        /// <summary>
        /// <para>The list of cloud application service instance IDs.</para>
        /// </summary>
        [NameInMap("RenderingInstanceIds")]
        [Validation(Required=false)]
        public List<string> RenderingInstanceIds { get; set; }

    }

}
