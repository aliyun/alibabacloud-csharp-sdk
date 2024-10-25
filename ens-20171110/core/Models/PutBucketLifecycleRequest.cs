// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PutBucketLifecycleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow overlapped prefixes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowSameActionOverlap")]
        [Validation(Required=false)]
        public string AllowSameActionOverlap { get; set; }

        /// <summary>
        /// <para>The name of the bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The expiration time. EOS executes a lifecycle rule for objects that were last updated before the expiration time.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> ExpirationDays and CreateBeforeDate are mutually exclusive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-12T05:45:00Z</para>
        /// </summary>
        [NameInMap("CreatedBeforeDate")]
        [Validation(Required=false)]
        public string CreatedBeforeDate { get; set; }

        /// <summary>
        /// <para>The number of days from when the objects were last modified to when the lifecycle rule takes effect. The value must be a positive integer that is greater than 0.</para>
        /// <remarks>
        /// <para> ExpirationDays and CreateBeforeDate are mutually exclusive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ExpirationDays")]
        [Validation(Required=false)]
        public long? ExpirationDays { get; set; }

        /// <summary>
        /// <para>The prefix of a object name. The prefix must be unique.</para>
        /// <list type="bullet">
        /// <item><description>If you specify a prefix, the rule applies only to objects in the bucket that match the prefix.</description></item>
        /// <item><description>If you do not specify a prefix, the rule applies to all objects in the bucket.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The unique ID of the rule. The ID of a lifecycle rule can be up to 255 bytes in length.</para>
        /// <list type="bullet">
        /// <item><description>You do not need to configure this parameter when you create a rule. The system automatically generates a unique ID.</description></item>
        /// <item><description>When you update a rule, you need to specify this parameter. Make sure that the rule specified by RuleId exists. Otherwise, an error occurs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b></description></item>
        /// <item><description><b>Disabled</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
