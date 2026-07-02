// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class RestoreInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup file. You can find backup file IDs by calling the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78241****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The keys to restore, which can be specified as a regular expression. To specify multiple keys, separate them with commas (,).</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, the entire instance is restored.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, only the specified keys are restored. This feature is available only for instances that use the classic architecture.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>In a regular expression, the asterisk (<c>*</c>) matches the preceding element zero or more times. For example, if you set this parameter to <c>h.*llo</c>, strings such as <c>hllo</c> and <c>heeeello</c> are matched.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>key:00000007198*</para>
        /// </summary>
        [NameInMap("FilterKey")]
        [Validation(Required=false)]
        public string FilterKey { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
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
        /// <para>The restore point in time. Specify the time in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format (UTC).</para>
        /// <remarks>
        /// <para>This point in time cannot be earlier than the time when the Data Flashback feature was enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06T07:25:57Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The restore method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b> (default): This value is deprecated.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Restores data to a specific point in time. You can set this parameter to 1 only if the <a href="https://help.aliyun.com/document_detail/148479.html">Data Flashback</a> feature is enabled for the instance. If you set this parameter to 1, you must also specify the <b>RestoreTime</b> parameter.</para>
        /// </description></item>
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
        /// <para>For instances that use the classic architecture, you can apply an offset to the expiration time of restored keys. This applies whether you restore the entire instance or only specific keys. The system calculates a key\&quot;s remaining time-to-live (TTL) at the specified flashback point in time and then adds this TTL to the <c>TimeShift</c> value to set the key\&quot;s new expiration time. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This feature adjusts the expiration time for top-level keys only. It does not apply to the expiration times of elements within Tair-specific data structures, such as fields in an exHash or secondary keys (Skeys) in a Time Series (TS) data structure.</para>
        /// </description></item>
        /// <item><description><para>The specified time must be later than <c>RestoreTime</c> and earlier than the task submission time.</para>
        /// </description></item>
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
