// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateRepoBuildRuleRequest : TeaModel {
        /// <summary>
        /// <para>Building arguments.</para>
        /// </summary>
        [NameInMap("BuildArgs")]
        [Validation(Required=false)]
        public List<string> BuildArgs { get; set; }

        /// <summary>
        /// <para>The ID of the building rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crbr-ly77w5i3t31f****</para>
        /// </summary>
        [NameInMap("BuildRuleId")]
        [Validation(Required=false)]
        public string BuildRuleId { get; set; }

        /// <summary>
        /// <para>The path of the Dockerfile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("DockerfileLocation")]
        [Validation(Required=false)]
        public string DockerfileLocation { get; set; }

        /// <summary>
        /// <para>The name of the Dockerfile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dockerfile</para>
        /// </summary>
        [NameInMap("DockerfileName")]
        [Validation(Required=false)]
        public string DockerfileName { get; set; }

        /// <summary>
        /// <para>The tag of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v0.9.5</para>
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Architecture for image building. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>linux/amd64</c></description></item>
        /// <item><description><c>linux/arm64</c></description></item>
        /// <item><description><c>linux/386</c></description></item>
        /// <item><description><c>linux/arm/v7</c></description></item>
        /// <item><description><c>linux/arm/v6</c></description></item>
        /// </list>
        /// <para>Default value: <c>linux/amd64</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>linux/amd64</para>
        /// </summary>
        [NameInMap("Platforms")]
        [Validation(Required=false)]
        public List<string> Platforms { get; set; }

        /// <summary>
        /// <para>The name of the push that triggers the building rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("PushName")]
        [Validation(Required=false)]
        public string PushName { get; set; }

        /// <summary>
        /// <para>The type of the push that triggers the building rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>GIT_TAG</c>: tag push</description></item>
        /// <item><description><c>GIT_BRANCH</c>: branch push</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GIT_BRANCH</para>
        /// </summary>
        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

        /// <summary>
        /// <para>The ID of the image repository.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-tquyps22md8p****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

    }

}
