// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoSyncRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
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
        /// <para>The list of synchronization rules.</para>
        /// </summary>
        [NameInMap("SyncRules")]
        [Validation(Required=false)]
        public List<ListRepoSyncRuleResponseBodySyncRules> SyncRules { get; set; }
        public class ListRepoSyncRuleResponseBodySyncRules : TeaModel {
            /// <summary>
            /// <para>The time when the synchronization rule was created. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1572604642000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether images are synchronized across different Alibaba Cloud accounts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c></para>
            /// </description></item>
            /// <item><description><para><c>false</c></para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CrossUser")]
            [Validation(Required=false)]
            public bool? CrossUser { get; set; }

            [NameInMap("LinkId")]
            [Validation(Required=false)]
            public string LinkId { get; set; }

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
            /// <para>The time when the synchronization rule was last modified. This value is a UNIX timestamp. Unit: milliseconds.</para>
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
            /// <para>This parameter is valid only when <c>SyncScope</c> is set to <c>NAMESPACE</c>.</para>
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
            /// <item><description><para><c>FROM</c>: from the source instance to the target instance.</para>
            /// </description></item>
            /// <item><description><para><c>TO</c>: from the target instance to the source instance.</para>
            /// </description></item>
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
            /// <item><description><para><c>NAMESPACE</c>: Synchronizes resources by namespace.</para>
            /// </description></item>
            /// <item><description><para><c>REPO</c>: Synchronizes resources by repository.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NAMESPACE</para>
            /// </summary>
            [NameInMap("SyncScope")]
            [Validation(Required=false)]
            public string SyncScope { get; set; }

            /// <summary>
            /// <para>The trigger policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>INITIATIVE</c>: The synchronization is actively triggered.</para>
            /// </description></item>
            /// <item><description><para><c>PASSIVE</c>: The synchronization is passively triggered.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PASSIVE</para>
            /// </summary>
            [NameInMap("SyncTrigger")]
            [Validation(Required=false)]
            public string SyncTrigger { get; set; }

            /// <summary>
            /// <para>The regular expression that is used to filter tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.*</para>
            /// </summary>
            [NameInMap("TagFilter")]
            [Validation(Required=false)]
            public string TagFilter { get; set; }

            /// <summary>
            /// <para>The ID of the target instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-k77rd2eo9ztt****</para>
            /// </summary>
            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the namespace in the target instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TargetNamespaceName")]
            [Validation(Required=false)]
            public string TargetNamespaceName { get; set; }

            /// <summary>
            /// <para>The region ID of the target instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("TargetRegionId")]
            [Validation(Required=false)]
            public string TargetRegionId { get; set; }

            /// <summary>
            /// <para>The name of the repository in the target instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-repo-target</para>
            /// </summary>
            [NameInMap("TargetRepoName")]
            [Validation(Required=false)]
            public string TargetRepoName { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
