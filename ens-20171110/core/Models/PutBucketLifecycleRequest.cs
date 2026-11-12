// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PutBucketLifecycleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow overlapping prefixes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Overlapping prefixes are allowed.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Overlapping prefixes are not allowed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowSameActionOverlap")]
        [Validation(Required=false)]
        public bool? AllowSameActionOverlap { get; set; }

        /// <summary>
        /// <para>The bucket name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The expiration date. The system performs lifecycle operations on objects that were last modified before this date.</para>
        /// <para>The date must be specified in the ISO 8601 standard and in UTC. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <remarks>
        /// <para>ExpirationDays and CreatedBeforeDate are mutually exclusive. You must specify one of them.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-12T05:45:00Z</para>
        /// </summary>
        [NameInMap("CreatedBeforeDate")]
        [Validation(Required=false)]
        public string CreatedBeforeDate { get; set; }

        /// <summary>
        /// <para>The number of days after the last modification time of an object before the lifecycle rule takes effect. The value must be a positive integer greater than 0.</para>
        /// <remarks>
        /// <para>ExpirationDays and CreatedBeforeDate are mutually exclusive. You must specify one of them.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ExpirationDays")]
        [Validation(Required=false)]
        public long? ExpirationDays { get; set; }

        /// <summary>
        /// <para>The prefix to which the rule applies. You cannot specify the same prefix for multiple rules.</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify a prefix, the rule applies only to objects whose names match the prefix in the bucket.</para>
        /// </description></item>
        /// <item><description><para>If you leave the prefix empty, the rule applies to all objects in the bucket.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The unique ID that identifies the rule. The ID can be up to 255 bytes in length.</para>
        /// <list type="bullet">
        /// <item><description><para>You do not need to specify this parameter when you create a rule. The system automatically generates a unique ID.</para>
        /// </description></item>
        /// <item><description><para>You must specify the RuleId when you update an existing rule. The rule corresponding to the RuleId must exist. Otherwise, an error is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>b8f93xxxxx4881xxxxxc71d991</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b>: The rule is executed periodically.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: The rule is ignored.</para>
        /// </description></item>
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
