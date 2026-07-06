// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetArtifactSubscriptionRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether to enable the accelerated data transfer feature. This feature is in public preview. It optimizes scheduling policies and network paths to improve the speed of artifact subscription.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Accelerate")]
        [Validation(Required=false)]
        public bool? Accelerate { get; set; }

        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The time when the rule was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570759546000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-hpdfkc6utbaq****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The time when the rule was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638259914000</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// <para>The destination ACR namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-ns</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// <para>Indicates whether to overwrite the existing images that have the same tag in the destination repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Override")]
        [Validation(Required=false)]
        public bool? Override { get; set; }

        /// <summary>
        /// <para>The operating systems and architectures. If a source repository contains multi-architecture images, only images that match the specified platforms are synchronized to the destination repository of the Enterprise Edition instance.</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public List<string> Platform { get; set; }

        /// <summary>
        /// <para>The destination ACR repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-repo</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D4978DCC-ECBD-40B0-A714-EE6959B22C77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crasr-mdbpung4i1rm****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The domain name of the artifact source.</para>
        /// </summary>
        [NameInMap("SourceDomain")]
        [Validation(Required=false)]
        public string SourceDomain { get; set; }

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
        /// <para>The artifact source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DOCKER_HUB</para>
        /// </summary>
        [NameInMap("SourceProvider")]
        [Validation(Required=false)]
        public string SourceProvider { get; set; }

        /// <summary>
        /// <para>The source repository.</para>
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
        /// <para>The regular expression that is used to match the tags of images in the source repository for subscription.</para>
        /// 
        /// <b>Example:</b>
        /// <para>release-v.*</para>
        /// </summary>
        [NameInMap("TagRegexp")]
        [Validation(Required=false)]
        public string TagRegexp { get; set; }

    }

}
