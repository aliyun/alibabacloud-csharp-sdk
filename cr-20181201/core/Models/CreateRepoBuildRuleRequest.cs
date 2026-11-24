// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoBuildRuleRequest : TeaModel {
        /// <summary>
        /// <para>The build arguments.</para>
        /// </summary>
        [NameInMap("BuildArgs")]
        [Validation(Required=false)]
        public List<string> BuildArgs { get; set; }

        /// <summary>
        /// <para>The Dockerfile path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("DockerfileLocation")]
        [Validation(Required=false)]
        public string DockerfileLocation { get; set; }

        /// <summary>
        /// <para>The Dockerfile name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dockerfile</para>
        /// </summary>
        [NameInMap("DockerfileName")]
        [Validation(Required=false)]
        public string DockerfileName { get; set; }

        /// <summary>
        /// <para>The image version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v0.9.5</para>
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xkx6vujuhay0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The image architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>linux/amd64</c></para>
        /// </description></item>
        /// <item><description><para><c>linux/arm64</c></para>
        /// </description></item>
        /// <item><description><para><c>linux/386</c></para>
        /// </description></item>
        /// <item><description><para><c>linux/arm/v7</c></para>
        /// </description></item>
        /// <item><description><para><c>linux/arm/v6</c></para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>linux/amd64</c>.</para>
        /// </summary>
        [NameInMap("Platforms")]
        [Validation(Required=false)]
        public List<string> Platforms { get; set; }

        /// <summary>
        /// <para>The trigger name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("PushName")]
        [Validation(Required=false)]
        public string PushName { get; set; }

        /// <summary>
        /// <para>The push type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>GIT_TAG</c>: Triggered by tag.</para>
        /// </description></item>
        /// <item><description><para><c>GIT_BRANCH</c>: Triggered by branch.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GIT_BRANCH</para>
        /// </summary>
        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

        /// <summary>
        /// <para>The image repository ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-8dz3aedjqlmk****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

    }

}
