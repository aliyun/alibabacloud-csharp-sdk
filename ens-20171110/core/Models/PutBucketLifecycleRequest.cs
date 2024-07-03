// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PutBucketLifecycleRequest : TeaModel {
        /// <summary>
        /// Specifies whether to allow overlapped prefixes. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("AllowSameActionOverlap")]
        [Validation(Required=false)]
        public string AllowSameActionOverlap { get; set; }

        /// <summary>
        /// The name of the bucket.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// The expiration time. EOS executes a lifecycle rule for objects that were last updated before the expiration time.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// >  ExpirationDays and CreateBeforeDate are mutually exclusive.
        /// </summary>
        [NameInMap("CreatedBeforeDate")]
        [Validation(Required=false)]
        public string CreatedBeforeDate { get; set; }

        /// <summary>
        /// The number of days from when the objects were last modified to when the lifecycle rule takes effect. The value must be a positive integer that is greater than 0.
        /// 
        /// >  ExpirationDays and CreateBeforeDate are mutually exclusive.
        /// </summary>
        [NameInMap("ExpirationDays")]
        [Validation(Required=false)]
        public long? ExpirationDays { get; set; }

        /// <summary>
        /// The prefix of a object name. The prefix must be unique.
        /// 
        /// *   If you specify a prefix, the rule applies only to objects in the bucket that match the prefix.
        /// *   If you do not specify a prefix, the rule applies to all objects in the bucket.
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// The unique ID of the rule. The ID of a lifecycle rule can be up to 255 bytes in length.
        /// 
        /// *   You do not need to configure this parameter when you create a rule. The system automatically generates a unique ID.
        /// *   When you update a rule, you need to specify this parameter. Make sure that the rule specified by RuleId exists. Otherwise, an error occurs.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// The status of the rule. Valid values:
        /// 
        /// *   **Enabled**
        /// *   **Disabled**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
