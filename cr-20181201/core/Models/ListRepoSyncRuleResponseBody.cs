// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoSyncRuleResponseBody : TeaModel {
        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The synchronization rules.
        /// </summary>
        [NameInMap("SyncRules")]
        [Validation(Required=false)]
        public List<ListRepoSyncRuleResponseBodySyncRules> SyncRules { get; set; }
        public class ListRepoSyncRuleResponseBodySyncRules : TeaModel {
            /// <summary>
            /// The time when the synchronization rule was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// Indicates whether images are synchronized across Alibaba Cloud accounts. Valid values:
            /// 
            /// *   `true`: Images are synchronized across Alibaba Cloud accounts.
            /// *   `false`: Images are synchronized within the same Alibaba Cloud account.
            /// 
            /// Default value: `false`
            /// </summary>
            [NameInMap("CrossUser")]
            [Validation(Required=false)]
            public bool? CrossUser { get; set; }

            /// <summary>
            /// The ID of the source instance.
            /// </summary>
            [NameInMap("LocalInstanceId")]
            [Validation(Required=false)]
            public string LocalInstanceId { get; set; }

            /// <summary>
            /// The namespace name of the source instance.
            /// </summary>
            [NameInMap("LocalNamespaceName")]
            [Validation(Required=false)]
            public string LocalNamespaceName { get; set; }

            /// <summary>
            /// The region ID of the source instance.
            /// </summary>
            [NameInMap("LocalRegionId")]
            [Validation(Required=false)]
            public string LocalRegionId { get; set; }

            /// <summary>
            /// The image repository name of the source instance.
            /// </summary>
            [NameInMap("LocalRepoName")]
            [Validation(Required=false)]
            public string LocalRepoName { get; set; }

            /// <summary>
            /// The time when the synchronization rule was last modified.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// The synchronization direction. Valid values:
            /// 
            /// *   `FROM`: Images are synchronized from the source instance to the destination instance.
            /// *   `TO`: Images are synchronized from the destination instance to the source instance.
            /// </summary>
            [NameInMap("SyncDirection")]
            [Validation(Required=false)]
            public string SyncDirection { get; set; }

            /// <summary>
            /// The ID of the synchronization rule.
            /// </summary>
            [NameInMap("SyncRuleId")]
            [Validation(Required=false)]
            public string SyncRuleId { get; set; }

            /// <summary>
            /// The name of the synchronization rule.
            /// </summary>
            [NameInMap("SyncRuleName")]
            [Validation(Required=false)]
            public string SyncRuleName { get; set; }

            /// <summary>
            /// The synchronization scope. Valid values:
            /// 
            /// *   `NAMESPACE`: synchronizes the image tags in a namespace that meet the synchronization rule.
            /// *   `REPO`: synchronizes the image tags in an image repository that meet the synchronization rule.
            /// </summary>
            [NameInMap("SyncScope")]
            [Validation(Required=false)]
            public string SyncScope { get; set; }

            /// <summary>
            /// The policy that is applied to trigger the synchronization rule. Valid values:
            /// 
            /// *   `INITIATIVE`: The synchronization rule is positively triggered.
            /// *   `PASSIVE`: The synchronization rule is passively triggered.
            /// </summary>
            [NameInMap("SyncTrigger")]
            [Validation(Required=false)]
            public string SyncTrigger { get; set; }

            /// <summary>
            /// The regular expression that is used to filter image tags.
            /// </summary>
            [NameInMap("TagFilter")]
            [Validation(Required=false)]
            public string TagFilter { get; set; }

            /// <summary>
            /// The ID of the destination instance.
            /// </summary>
            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            /// <summary>
            /// The namespace name of the destination instance.
            /// </summary>
            [NameInMap("TargetNamespaceName")]
            [Validation(Required=false)]
            public string TargetNamespaceName { get; set; }

            /// <summary>
            /// The region ID of the destination instance.
            /// </summary>
            [NameInMap("TargetRegionId")]
            [Validation(Required=false)]
            public string TargetRegionId { get; set; }

            /// <summary>
            /// The image repository name of the destination instance.
            /// </summary>
            [NameInMap("TargetRepoName")]
            [Validation(Required=false)]
            public string TargetRepoName { get; set; }

        }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
