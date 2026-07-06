// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoSyncTaskRequest : TeaModel {
        /// <summary>
        /// <para>Source instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-hpdfkc6utbaq****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite an existing image:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Overwrite the existing image.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Do not overwrite the existing image.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Override")]
        [Validation(Required=false)]
        public bool? Override { get; set; }

        /// <summary>
        /// <para>Image repository ID in the source instance</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-iql7jalx4g0****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>Image tag in the source instance</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag1</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>Target instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-ibxs3piklys3****</para>
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// <para>Namespace in the target instance</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns1</para>
        /// </summary>
        [NameInMap("TargetNamespace")]
        [Validation(Required=false)]
        public string TargetNamespace { get; set; }

        /// <summary>
        /// <para>Region ID of the target instance</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("TargetRegionId")]
        [Validation(Required=false)]
        public string TargetRegionId { get; set; }

        /// <summary>
        /// <para>Name of the image repository in the target instance</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo1</para>
        /// </summary>
        [NameInMap("TargetRepoName")]
        [Validation(Required=false)]
        public string TargetRepoName { get; set; }

        /// <summary>
        /// <para>Image tag in the target instance</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag1</para>
        /// </summary>
        [NameInMap("TargetTag")]
        [Validation(Required=false)]
        public string TargetTag { get; set; }

        /// <summary>
        /// <para>UID of the account to which the target instance belongs</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345***</para>
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}
