// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateArtifactShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The properties for building the artifact. This is used for managed artifact builds.</para>
        /// </summary>
        [NameInMap("ArtifactBuildProperty")]
        [Validation(Required=false)]
        public string ArtifactBuildPropertyShrink { get; set; }

        /// <summary>
        /// <para>The ID of the artifact.</para>
        /// <para>To obtain the artifact ID, call the <a href="https://help.aliyun.com/document_detail/469993.html">ListArtifacts</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>artifact-eea08d1e2d3a43ae****</para>
        /// </summary>
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// <para>The properties of the artifact.</para>
        /// </summary>
        [NameInMap("ArtifactProperty")]
        [Validation(Required=false)]
        public string ArtifactPropertyShrink { get; set; }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. Generate a unique token for each request from your client. The <b>ClientToken</b> can contain only ASCII characters and must be no more than 64 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CM943JP0EN9D51H</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the artifact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Redhat8_0 image</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The permission type. This parameter is valid for container image artifacts and Helm Chart artifacts. The value can be changed only from \<c>Automatic\\</c> to \<c>Public\\</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Public</para>
        /// </description></item>
        /// <item><description><para>Automatic</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("PermissionType")]
        [Validation(Required=false)]
        public string PermissionType { get; set; }

        /// <summary>
        /// <para>The IDs of regions to which the image can be distributed.</para>
        /// </summary>
        [NameInMap("SupportRegionIds")]
        [Validation(Required=false)]
        public List<string> SupportRegionIds { get; set; }

        /// <summary>
        /// <para>The name of the artifact version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
