// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ModifyActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>The O&amp;M task IDs. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/414458.html">DescribeActiveOperationTasks</a> to obtain O&amp;M task IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111,2222</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately execute the O&amp;M task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: immediately executes the task.</description></item>
        /// <item><description><b>0</b>: executes the task at the specified time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ImmediateStart")]
        [Validation(Required=false)]
        public int? ImmediateStart { get; set; }

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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The scheduled switchover time to set. Specify the time in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format (UTC).</para>
        /// <remarks>
        /// <para>The time cannot be later than the deadline. You can call <a href="https://help.aliyun.com/document_detail/414458.html">DescribeActiveOperationTasks</a> and check the value of the <b>Deadline</b> response parameter to obtain the deadline.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-17T18:50:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

    }

}
