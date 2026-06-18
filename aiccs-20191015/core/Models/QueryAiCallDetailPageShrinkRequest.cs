// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiCallDetailPageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The batch ID. You can find this ID by clicking Details on the <b>Call Task Management</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1183**************</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// <para>The call result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CALL_FORWARDING: Call Forwarding.</para>
        /// </description></item>
        /// <item><description><para>INCOMING_CALL_BARRED: Incoming Call Barred.</para>
        /// </description></item>
        /// <item><description><para>CALL_REJECTED: Call Rejected.</para>
        /// </description></item>
        /// <item><description><para>ANSWERED: Answered.</para>
        /// </description></item>
        /// <item><description><para>USER_BUSY: User Busy.</para>
        /// </description></item>
        /// <item><description><para>POWERED_OFF: Powered Off.</para>
        /// </description></item>
        /// <item><description><para>NO_USER_RESPONSE: No User Response.</para>
        /// </description></item>
        /// <item><description><para>OPERATOR_BLOCK: Operator Block.</para>
        /// </description></item>
        /// <item><description><para>OTHERS: Others.</para>
        /// </description></item>
        /// <item><description><para>SUSPEND: Suspend.</para>
        /// </description></item>
        /// <item><description><para>CANCEL: Canceled by the caller.</para>
        /// </description></item>
        /// <item><description><para>INVALID_NUMBER: Invalid Number.</para>
        /// </description></item>
        /// <item><description><para>UNAVAILABLE: Unavailable.</para>
        /// </description></item>
        /// <item><description><para>NETWORK_BUSY: Network Busy.</para>
        /// </description></item>
        /// <item><description><para>NO_ANSWER: No Answer.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ANSWERED</para>
        /// </summary>
        [NameInMap("CallResult")]
        [Validation(Required=false)]
        public string CallResult { get; set; }

        /// <summary>
        /// <para>The called number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>053714454****</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>A list of up to 100 detail IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value Sample value</para>
        /// </summary>
        [NameInMap("DetailIds")]
        [Validation(Required=false)]
        public string DetailIdsShrink { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid values: 0 (None), 1 (MD5), 2 (SHA256), and 3 (SM3).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public long? EncryptionType { get; set; }

        /// <summary>
        /// <para>The end of the call time range. This value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748948749000</para>
        /// </summary>
        [NameInMap("EndCallingTime")]
        [Validation(Required=false)]
        public long? EndCallingTime { get; set; }

        /// <summary>
        /// <para>The end of the import time range. This value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748948749000</para>
        /// </summary>
        [NameInMap("EndImportedTime")]
        [Validation(Required=false)]
        public long? EndImportedTime { get; set; }

        /// <summary>
        /// <para>The major intent. You can find this intent by clicking Agent Details on the <a href="https://aiccs.console.aliyun.com/agent/customize">Communication Agent Management</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("MajorIntent")]
        [Validation(Required=false)]
        public string MajorIntent { get; set; }

        /// <summary>
        /// <para>The maximum conversation duration, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxConversationDuration")]
        [Validation(Required=false)]
        public long? MaxConversationDuration { get; set; }

        /// <summary>
        /// <para>The minimum conversation duration, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinConversationDuration")]
        [Validation(Required=false)]
        public long? MinConversationDuration { get; set; }

        /// <summary>
        /// <para>A custom ID provided by the caller. This ID is returned in the receipt message for request tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94ba739b-c01a-ef91-335d-4be006c34899</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than <b>0</b>. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The default value is <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start of the call time range. This value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748948749000</para>
        /// </summary>
        [NameInMap("StartCallingTime")]
        [Validation(Required=false)]
        public long? StartCallingTime { get; set; }

        /// <summary>
        /// <para>The start of the import time range. This value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748948749000</para>
        /// </summary>
        [NameInMap("StartImportedTime")]
        [Validation(Required=false)]
        public long? StartImportedTime { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Pending.</para>
        /// </description></item>
        /// <item><description><para>1: Completed.</para>
        /// </description></item>
        /// <item><description><para>2: Failed.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1187**************</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
