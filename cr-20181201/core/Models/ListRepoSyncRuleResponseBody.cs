// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoSyncRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
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
        /// <para>The number of entries per page.</para>
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
        /// <para>838D1602-6D8F-47FB-B60A-656645D2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried synchronization rules.</para>
        /// </summary>
        [NameInMap("SyncRules")]
        [Validation(Required=false)]
        public List<ListRepoSyncRuleResponseBodySyncRules> SyncRules { get; set; }
        public class ListRepoSyncRuleResponseBodySyncRules : TeaModel {
            /// <summary>
            /// <para>The time when the synchronization rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1572604642000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the synchronization is performed across Alibaba Cloud accounts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Images are synchronized across Alibaba Cloud accounts.</description></item>
            /// <item><description><c>false</c>: Images are synchronized within the same Alibaba Cloud account.</description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CrossUser")]
            [Validation(Required=false)]
            public bool? CrossUser { get; set; }

            /// <summary>
            /// <para>The ID of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-kmsiwlxxdcva****</para>
            /// </summary>
            [NameInMap("LocalInstanceId")]
            [Validation(Required=false)]
            public string LocalInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the namespace in the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("LocalNamespaceName")]
            [Validation(Required=false)]
            public string LocalNamespaceName { get; set; }

            /// <summary>
            /// <para>The region ID of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("LocalRegionId")]
            [Validation(Required=false)]
            public string LocalRegionId { get; set; }

            /// <summary>
            /// <para>The name of the repository in the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-repo-local</para>
            /// </summary>
            [NameInMap("LocalRepoName")]
            [Validation(Required=false)]
            public string LocalRepoName { get; set; }

            /// <summary>
            /// <para>The time when the synchronization rule was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1572604642000</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <para>The regular expression that is used to filter repositories.</para>
            /// <remarks>
            /// <para> This parameter is valid only when SyncScope is set to <c>NAMESPACE</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>.*</para>
            /// </summary>
            [NameInMap("RepoNameFilter")]
            [Validation(Required=false)]
            public string RepoNameFilter { get; set; }

            /// <summary>
            /// <para>The synchronization direction. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>FROM</c>: Images are synchronized from the source instance to the destination instance.</description></item>
            /// <item><description><c>TO</c>: Images are synchronized from the destination instance to the source instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FROM</para>
            /// </summary>
            [NameInMap("SyncDirection")]
            [Validation(Required=false)]
            public string SyncDirection { get; set; }

            /// <summary>
            /// <para>The ID of the synchronization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crsr-7lph66uloi6h****</para>
            /// </summary>
            [NameInMap("SyncRuleId")]
            [Validation(Required=false)]
            public string SyncRuleId { get; set; }

            /// <summary>
            /// <para>The name of the synchronization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sync-rule-1</para>
            /// </summary>
            [NameInMap("SyncRuleName")]
            [Validation(Required=false)]
            public string SyncRuleName { get; set; }

            /// <summary>
            /// <para>The synchronization scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>NAMESPACE</c>: synchronizes the image tags in a namespace that meet the synchronization rule.</description></item>
            /// <item><description><c>REPO</c>: synchronizes the image tags in an image repository that meet the synchronization rule.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NAMESPACE</para>
            /// </summary>
            [NameInMap("SyncScope")]
            [Validation(Required=false)]
            public string SyncScope { get; set; }

            /// <summary>
            /// <para>The policy that is applied to trigger the synchronization rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>INITIATIVE</c>: The synchronization rule is positively triggered.</description></item>
            /// <item><description><c>PASSIVE</c>: The synchronization rule is passively triggered.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PASSIVE</para>
            /// </summary>
            [NameInMap("SyncTrigger")]
            [Validation(Required=false)]
            public string SyncTrigger { get; set; }

            /// <summary>
            /// <para>The regular expression that is used to filter image tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.*</para>
            /// </summary>
            [NameInMap("TagFilter")]
            [Validation(Required=false)]
            public string TagFilter { get; set; }

            /// <summary>
            /// <para>The ID of the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-k77rd2eo9ztt****</para>
            /// </summary>
            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the namespace in the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TargetNamespaceName")]
            [Validation(Required=false)]
            public string TargetNamespaceName { get; set; }

            /// <summary>
            /// <para>The region ID of the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("TargetRegionId")]
            [Validation(Required=false)]
            public string TargetRegionId { get; set; }

            /// <summary>
            /// <para>The name of the repository in the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-repo-target</para>
            /// </summary>
            [NameInMap("TargetRepoName")]
            [Validation(Required=false)]
            public string TargetRepoName { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
