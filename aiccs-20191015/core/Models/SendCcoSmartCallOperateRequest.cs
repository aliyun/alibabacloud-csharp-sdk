// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class SendCcoSmartCallOperateRequest : TeaModel {
        /// <summary>
        /// <para>Unique receipt ID of the call. This can be obtained from the response of the <a href="https://help.aliyun.com/document_detail/311247.html">SendCcoSmartCall</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116012854210^102814279****</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>Specifies the action to be performed for the called number during an Intelligent Outbound Call.  </para>
        /// <remarks>
        /// <para>Currently, only the <b>parallelBridge</b> parameter is supported, which indicates bridging the called number with a call center agent.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>parallelBridge</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Extension field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Param</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>Product name. Default value: <b>aiccs</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aiccs</para>
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
