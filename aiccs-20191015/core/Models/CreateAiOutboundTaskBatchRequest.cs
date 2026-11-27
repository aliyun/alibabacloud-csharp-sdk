// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CreateAiOutboundTaskBatchRequest : TeaModel {
        /// <summary>
        /// <para>The AICCS instance ID.
        /// You can obtain the ID in the <b>Instances</b> section of the left-side navigation pane in the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/312260.html">CreateAiOutboundTask</a> operation and view the <b>Data</b> response parameter, or call the <a href="https://help.aliyun.com/document_detail/2718026.html">GetAiOutboundTaskList</a> operation and view the <b>TaskId</b> response parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
