// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class RestoreInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup file for the instance. You can call the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78241****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The keys to restore. Regular expressions are supported. Separate multiple values with commas (,).</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the entire instance is restored.</description></item>
        /// <item><description>If you specify this parameter, only the specified keys are restored. This feature is supported only by classic architecture instances.<remarks>
        /// <para>For example, in a regular expression, an asterisk (<c>*</c>) matches the preceding subexpression zero or more times. If you set this parameter to <c>h.*llo</c>, the system matches strings such as <c>hllo</c> and <c>heeeello</c>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>key:00000007198*</para>
        /// </summary>
        [NameInMap("FilterKey")]
        [Validation(Required=false)]
        public string FilterKey { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore data. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The point in time cannot be earlier than the time when the data flashback feature is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06T07:25:57Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The restoration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): This value is deprecated.</description></item>
        /// <item><description><b>1</b>: Restores data to a specified point in time. You can specify this value only when the <a href="https://help.aliyun.com/document_detail/148479.html">data flashback</a> feature is enabled for the instance. If you specify this value, you must also specify the <b>RestoreTime</b> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>When you restore a classic architecture instance, you can apply an offset to the expiration time of keys regardless of whether you choose to restore full data or specified keys. Specify the time in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC. The instance calculates the remaining expiration duration of the keys at the specified flashback point in time, starting from the specified expiration offset point in time.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This feature supports offsetting the expiration time only at the key level. It does not support offsetting the internal expiration time of keys in Tair-developed data structures, such as the fields in exHash and the skeys in TS.</description></item>
        /// <item><description>The point in time cannot be earlier than the specified flashback point in time or later than the time when the restoration task is submitted.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06T08:25:57Z</para>
        /// </summary>
        [NameInMap("TimeShift")]
        [Validation(Required=false)]
        public string TimeShift { get; set; }

    }

}
