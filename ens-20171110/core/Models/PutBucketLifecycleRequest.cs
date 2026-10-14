// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PutBucketLifecycleRequest : TeaModel {
        /// <summary>
        /// <para>Whether to allow overlapping prefixes. Valid values:</para>
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
        /// <para>The date before which objects expire. The system applies the lifecycle rule to objects last modified before this date.</para>
        /// <para>Use ISO 8601 format and UTC time. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <remarks>
        /// <para>ExpirationDays and CreatedBeforeDate are mutually exclusive. Specify one.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-12T05:45:00Z</para>
        /// </summary>
        [NameInMap("CreatedBeforeDate")]
        [Validation(Required=false)]
        public string CreatedBeforeDate { get; set; }

        /// <summary>
        /// <para>The number of days after an object\&quot;s last modification when the lifecycle rule takes effect. Must be a positive integer greater than zero.</para>
        /// <remarks>
        /// <para>ExpirationDays and CreatedBeforeDate are mutually exclusive. Specify one.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ExpirationDays")]
        [Validation(Required=false)]
        public long? ExpirationDays { get; set; }

        /// <summary>
        /// <para>The prefix that the rule applies to. You cannot set duplicate prefixes.</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify a prefix, the rule applies only to objects in the bucket whose names start with that prefix.</para>
        /// </description></item>
        /// <item><description><para>If you leave Prefix empty, the rule applies to all objects in the bucket.</para>
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
        /// <para>A unique ID that identifies the rule. Maximum length is 255 bytes.</para>
        /// <list type="bullet">
        /// <item><description><para>Omit this parameter when creating a new rule. The system generates a unique ID automatically.</para>
        /// </description></item>
        /// <item><description><para>Specify RuleId when updating an existing rule. The rule must exist. Otherwise, the call fails.</para>
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
        /// <item><description><para><b>Enabled</b>: The system runs the rule on schedule.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: The system ignores the rule.</para>
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
