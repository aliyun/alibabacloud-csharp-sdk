// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateArtifactSubscriptionRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the acceleration link. The subscription acceleration feature is in public preview. Based on scheduling policies and network link optimization, it can improve the image subscription speed.</para>
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
        /// <para>The ACR namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-ns</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Override")]
        [Validation(Required=false)]
        public bool? Override { get; set; }

        /// <summary>
        /// <para>The operating system or architecture. If the source repository contains multi-architecture images, only images with the specified operating system or architecture are subscribed to the destination repository of the Enterprise instance.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public List<string> Platform { get; set; }

        /// <summary>
        /// <para>The ACR repository.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-repo</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The source namespace. If <c>SourceProvider</c> is set to <c>DOCKER_HUB</c>, the default value is <c>library</c>. This parameter is required in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>library</para>
        /// </summary>
        [NameInMap("SourceNamespaceName")]
        [Validation(Required=false)]
        public string SourceNamespaceName { get; set; }

        /// <summary>
        /// <para>The artifact source.</para>
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
        /// <para>The number of images to subscribe to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TagCount")]
        [Validation(Required=false)]
        public long? TagCount { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The image tags to subscribe to when matching by tag list. A maximum of 10 tags are supported.</description></item>
        /// <item><description>If TagList is specified, these tags are queried one by one. TagRegexp and TagCount cannot be specified at the same time. If TagList is not specified, TagRegexp and TagCount are used for matching, and both must be specified.</description></item>
        /// <item><description>The matching method cannot be changed after the rule is created. To change the matching method, delete the rule and create a new one.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<string> TagList { get; set; }

        /// <summary>
        /// <para>The image versions to subscribe to from the source repository. Regular expressions are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>release-v.*</para>
        /// </summary>
        [NameInMap("TagRegexp")]
        [Validation(Required=false)]
        public string TagRegexp { get; set; }

    }

}
