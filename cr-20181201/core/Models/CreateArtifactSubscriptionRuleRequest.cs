// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateArtifactSubscriptionRuleRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether an acceleration link is enabled for image subscription. The subscription acceleration feature is in public preview. The feature is optimized based on scheduling policies and network links to accelerate image subscription.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Accelerate")]
        [Validation(Required=false)]
        public bool? Accelerate { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-c0o11woew0k****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the Container Registry namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-ns</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// <para>Indicates whether the original image is overwritten.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Override")]
        [Validation(Required=false)]
        public bool? Override { get; set; }

        /// <summary>
        /// <para>The operating system and architecture. If the source repository contains a multi-arch image, only the specified operating system and architecture are subscribed to the destination repository of the Enterprise Edition instance. Subscribe to the destination repository of an Enterprise Edition instance</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public List<string> Platform { get; set; }

        /// <summary>
        /// <para>The name of the Container Registry repository.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-repo</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The source namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>library</para>
        /// </summary>
        [NameInMap("SourceNamespaceName")]
        [Validation(Required=false)]
        public string SourceNamespaceName { get; set; }

        /// <summary>
        /// <para>The source of the artifact.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DOCKER_HUB: Docker Hub</description></item>
        /// <item><description>GCR: GCR</description></item>
        /// <item><description>QUAY: Quay.io</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DOCKER_HUB</para>
        /// </summary>
        [NameInMap("SourceProvider")]
        [Validation(Required=false)]
        public string SourceProvider { get; set; }

        /// <summary>
        /// <para>The source repository.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nginx</para>
        /// </summary>
        [NameInMap("SourceRepoName")]
        [Validation(Required=false)]
        public string SourceRepoName { get; set; }

        /// <summary>
        /// <para>The number of subscribed images.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TagCount")]
        [Validation(Required=false)]
        public long? TagCount { get; set; }

        /// <summary>
        /// <para>The image tag in the subscription source repository. Regular expressions are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>release-v.*</para>
        /// </summary>
        [NameInMap("TagRegexp")]
        [Validation(Required=false)]
        public string TagRegexp { get; set; }

    }

}
