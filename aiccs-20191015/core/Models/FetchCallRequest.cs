// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class FetchCallRequest : TeaModel {
        /// <summary>
        /// <para>The name of the agent account, which is the logon name of the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:123@123.com">123@123.com</a></para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The acid in the WebSocket after an inbound call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7719786</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>The unique ID of the client request. This parameter is used to ensure idempotence. You can generate the ID by using a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46c1341e-2648-447a-9b11-70b6a298d94d</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The connection ID in the WebSocket after an inbound call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7719788</para>
        /// </summary>
        [NameInMap("ConnectionId")]
        [Validation(Required=false)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// <para>The hold connection ID in the WebSocket after an inbound call. This parameter is required only for a two-step transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HoldConnectionId")]
        [Validation(Required=false)]
        public string HoldConnectionId { get; set; }

        /// <summary>
        /// <para>The ID of the Artificial Intelligence Cloud Call Service (AICCS) instance. You can view the instance ID in the AICCS console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The job ID in the WebSocket after an inbound call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7719787</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
