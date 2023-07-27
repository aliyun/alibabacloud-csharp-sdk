// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class LifecycleRule : TeaModel {
        [NameInMap("AbortMultipartUpload")]
        [Validation(Required=false)]
        public LifecycleRuleLifecycleAbortMultipartUpload LifecycleAbortMultipartUpload { get; set; }
        public class LifecycleRuleLifecycleAbortMultipartUpload : TeaModel {
            [NameInMap("CreatedBeforeDate")]
            [Validation(Required=false)]
            public string CreatedBeforeDate { get; set; }

            [NameInMap("Days")]
            [Validation(Required=false)]
            public int? Days { get; set; }

        }

        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public LifecycleRuleLifecycleExpiration LifecycleExpiration { get; set; }
        public class LifecycleRuleLifecycleExpiration : TeaModel {
            [NameInMap("CreatedBeforeDate")]
            [Validation(Required=false)]
            public string CreatedBeforeDate { get; set; }

            [NameInMap("Days")]
            [Validation(Required=false)]
            public int? Days { get; set; }

            [NameInMap("ExpiredObjectDeleteMarker")]
            [Validation(Required=false)]
            public bool? ExpiredObjectDeleteMarker { get; set; }

        }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public LifecycleRuleFilter Filter { get; set; }
        public class LifecycleRuleFilter : TeaModel {
            [NameInMap("Not")]
            [Validation(Required=false)]
            public LifecycleRuleFilterNot Not { get; set; }
            public class LifecycleRuleFilterNot : TeaModel {
                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public Tag Tag { get; set; }

            }

        }

        [NameInMap("ID")]
        [Validation(Required=false)]
        public string ID { get; set; }

        [NameInMap("NoncurrentVersionExpiration")]
        [Validation(Required=false)]
        public LifecycleRuleNoncurrentVersionExpiration NoncurrentVersionExpiration { get; set; }
        public class LifecycleRuleNoncurrentVersionExpiration : TeaModel {
            [NameInMap("NoncurrentDays")]
            [Validation(Required=false)]
            public int? NoncurrentDays { get; set; }

        }

        [NameInMap("NoncurrentVersionTransition")]
        [Validation(Required=false)]
        public List<LifecycleRuleNoncurrentVersionTransition> NoncurrentVersionTransition { get; set; }
        public class LifecycleRuleNoncurrentVersionTransition : TeaModel {
            [NameInMap("AllowSmallFile")]
            [Validation(Required=false)]
            public bool? AllowSmallFile { get; set; }

            [NameInMap("IsAccessTime")]
            [Validation(Required=false)]
            public bool? IsAccessTime { get; set; }

            [NameInMap("NoncurrentDays")]
            [Validation(Required=false)]
            public int? NoncurrentDays { get; set; }

            [NameInMap("ReturnToStdWhenVisit")]
            [Validation(Required=false)]
            public bool? ReturnToStdWhenVisit { get; set; }

            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

        }

        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<Tag> Tag { get; set; }

        [NameInMap("Transition")]
        [Validation(Required=false)]
        public List<LifecycleRuleLifecycleTransition> LifecycleTransition { get; set; }
        public class LifecycleRuleLifecycleTransition : TeaModel {
            [NameInMap("AllowSmallFile")]
            [Validation(Required=false)]
            public bool? AllowSmallFile { get; set; }

            [NameInMap("CreatedBeforeDate")]
            [Validation(Required=false)]
            public string CreatedBeforeDate { get; set; }

            [NameInMap("Days")]
            [Validation(Required=false)]
            public int? Days { get; set; }

            [NameInMap("IsAccessTime")]
            [Validation(Required=false)]
            public bool? IsAccessTime { get; set; }

            [NameInMap("ReturnToStdWhenVisit")]
            [Validation(Required=false)]
            public bool? ReturnToStdWhenVisit { get; set; }

            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

        }

    }

}
