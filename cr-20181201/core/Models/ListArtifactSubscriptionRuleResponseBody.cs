// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListArtifactSubscriptionRuleResponseBody : TeaModel {
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
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The call failed.</para>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07FC5654-C82A-59FA-A9D1-78B4EE443F86</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListArtifactSubscriptionRuleResponseBodyRules> Rules { get; set; }
        public class ListArtifactSubscriptionRuleResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>Indicates whether the acceleration link is enabled. The subscription acceleration feature is in public preview and can improve image subscription speed based on scheduling policies and network link optimization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Accelerate")]
            [Validation(Required=false)]
            public bool? Accelerate { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1638187989000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-brlg4cbj2yl****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The modification time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1678341923385</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <para>The namespace name.</para>
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
            /// <para>The operating system and architecture. If the source repository contains multi-architecture images, only the specified operating system and architecture are subscribed to the destination repository of the Enterprise instance.</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public List<string> Platform { get; set; }

            /// <summary>
            /// <para>The repository name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-repo</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

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
            /// <para>The domain name of the source image repository for the subscription rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>anolis-registry.cn-zhangjiakou.cr.aliyuncs.com</para>
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
            /// <para>The number of subscribed images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TagCount")]
            [Validation(Required=false)]
            public long? TagCount { get; set; }

            /// <summary>
            /// <para>The list of subscribed tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>latest</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<string> TagList { get; set; }

            /// <summary>
            /// <para>The image versions subscribed from the source repository. Regular expressions are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>release.*</para>
            /// </summary>
            [NameInMap("TagRegexp")]
            [Validation(Required=false)]
            public string TagRegexp { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
