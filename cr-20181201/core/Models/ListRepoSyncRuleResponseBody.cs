// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoSyncRuleResponseBody : TeaModel {
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SyncRules")]
        [Validation(Required=false)]
        public List<ListRepoSyncRuleResponseBodySyncRules> SyncRules { get; set; }
        public class ListRepoSyncRuleResponseBodySyncRules : TeaModel {
            [NameInMap("SyncTrigger")]
            [Validation(Required=false)]
            public string SyncTrigger { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("LocalRegionId")]
            [Validation(Required=false)]
            public string LocalRegionId { get; set; }

            [NameInMap("SyncScope")]
            [Validation(Required=false)]
            public string SyncScope { get; set; }

            [NameInMap("TagFilter")]
            [Validation(Required=false)]
            public string TagFilter { get; set; }

            [NameInMap("TargetNamespaceName")]
            [Validation(Required=false)]
            public string TargetNamespaceName { get; set; }

            [NameInMap("TargetRepoName")]
            [Validation(Required=false)]
            public string TargetRepoName { get; set; }

            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            [NameInMap("SyncRuleId")]
            [Validation(Required=false)]
            public string SyncRuleId { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            [NameInMap("SyncRuleName")]
            [Validation(Required=false)]
            public string SyncRuleName { get; set; }

            [NameInMap("TargetRegionId")]
            [Validation(Required=false)]
            public string TargetRegionId { get; set; }

            [NameInMap("LocalInstanceId")]
            [Validation(Required=false)]
            public string LocalInstanceId { get; set; }

            [NameInMap("LocalNamespaceName")]
            [Validation(Required=false)]
            public string LocalNamespaceName { get; set; }

            [NameInMap("LocalRepoName")]
            [Validation(Required=false)]
            public string LocalRepoName { get; set; }

            [NameInMap("SyncDirection")]
            [Validation(Required=false)]
            public string SyncDirection { get; set; }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
