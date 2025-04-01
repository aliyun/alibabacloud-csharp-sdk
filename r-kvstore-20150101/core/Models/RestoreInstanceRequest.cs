// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class RestoreInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup file. You can call the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation to query the IDs of backup files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78241****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The key that you want to restore. You can specify multiple keys. Separate multiple keys with commas (,). Regular expressions are supported.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the entire instance is restored.</description></item>
        /// <item><description>If you specify this parameter, only the involved keys are restored. Only classic instances support this feature.</description></item>
        /// </list>
        /// <remarks>
        /// <para> In a regular expression, an asterisk (<c>*</c>) matches zero or more occurrences of a subexpression that occurs before. For example, if you set this parameter to <c>h.*llo</c>, strings such as <c>hllo</c> and <c>heeeello</c> are matched.</para>
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
        /// <para>The point in time to which you want to restore data. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> The point in time cannot be earlier than the point in time when the data flashback feature is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06T07:25:57Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The restoration mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): The parameter is invalid.</description></item>
        /// <item><description><b>1</b>: restores data to a specified point in time. You can specify this value only if the <a href="https://help.aliyun.com/document_detail/148479.html">data flashback</a> feature is enabled for the instance. If you specify this value, you also need to set the <b>RestoreTime</b> parameter.</description></item>
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
        /// <para>When you restore a classic instance, regardless of whether you choose to restore all data or specific keys, you can apply an offset to the expiration time of the keys. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC. A key expires after the remaining validity period of the key elapses based on the expiration offset time point.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This feature applies only to keys and does not work on elements in the self-developed data structures of Tair, such as fields in exHash and skeys in TairTS.</para>
        /// </description></item>
        /// <item><description><para>This time point must be between the specified flashback time point and the submission time of the data restoration task.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06T08:25:57Z</para>
        /// </summary>
        [NameInMap("TimeShift")]
        [Validation(Required=false)]
        public string TimeShift { get; set; }

    }

}
