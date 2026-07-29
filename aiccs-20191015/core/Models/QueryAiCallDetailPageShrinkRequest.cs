// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiCallDetailPageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The batch ID. On the <b>Call Task Management</b> page, click Details to view the batch ID.</para>
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
        /// <item><description>CALL_FORWARDING: call forwarding.</description></item>
        /// <item><description>INCOMING_CALL_BARRED: incoming call barred.</description></item>
        /// <item><description>CALL_REJECTED: call rejected.</description></item>
        /// <item><description>ANSWERED: answered.</description></item>
        /// <item><description>USER_BUSY: user busy.</description></item>
        /// <item><description>POWERED_OFF: powered off.</description></item>
        /// <item><description>NO_USER_RESPONSE: out of service area.</description></item>
        /// <item><description>OPERATOR_BLOCK: blocked by carrier.</description></item>
        /// <item><description>OTHERS: other status.</description></item>
        /// <item><description>SUSPEND: suspended.</description></item>
        /// <item><description>CANCEL: canceled by caller.</description></item>
        /// <item><description>INVALID_NUMBER: invalid number.</description></item>
        /// <item><description>UNAVAILABLE: temporarily unavailable.</description></item>
        /// <item><description>NETWORK_BUSY: network busy.</description></item>
        /// <item><description>NO_ANSWER: no answer.</description></item>
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
        /// <para>The list of task detail IDs. A maximum of 100 IDs can be specified.</para>
        /// </summary>
        [NameInMap("DetailIds")]
        [Validation(Required=false)]
        public string DetailIdsShrink { get; set; }

        /// <summary>
        /// <para>The encryption type. Valid values: 0: no encryption. 1: MD5. 2: SHA256. 3: SM3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public long? EncryptionType { get; set; }

        /// <summary>
        /// <para>The end calling time. This is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748948749000</para>
        /// </summary>
        [NameInMap("EndCallingTime")]
        [Validation(Required=false)]
        public long? EndCallingTime { get; set; }

        /// <summary>
        /// <para>The end import time. This is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748948749000</para>
        /// </summary>
        [NameInMap("EndImportedTime")]
        [Validation(Required=false)]
        public long? EndImportedTime { get; set; }

        /// <summary>
        /// <para>The major intent. On the <a href="https://aiccs.console.aliyun.com/agent/customize">Communication Agent Management</a> page, click agent details to view the major intent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("MajorIntent")]
        [Validation(Required=false)]
        public string MajorIntent { get; set; }

        /// <summary>
        /// <para>The maximum conversation duration. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxConversationDuration")]
        [Validation(Required=false)]
        public long? MaxConversationDuration { get; set; }

        /// <summary>
        /// <para>The minimum conversation duration. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinConversationDuration")]
        [Validation(Required=false)]
        public long? MinConversationDuration { get; set; }

        /// <summary>
        /// <para>The ID reserved for the caller. This ID is returned to the caller in the receipt message.</para>
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
        /// <para>The current page number. The value must be greater than <b>0</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>.</para>
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
        /// <para>The start calling time. This is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748948749000</para>
        /// </summary>
        [NameInMap("StartCallingTime")]
        [Validation(Required=false)]
        public long? StartCallingTime { get; set; }

        /// <summary>
        /// <para>The start import time. This is a timestamp in milliseconds.</para>
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
        /// <item><description><para>0: pending.</para>
        /// </description></item>
        /// <item><description><para>1: completed.</para>
        /// </description></item>
        /// <item><description><para>2: failed.</para>
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
