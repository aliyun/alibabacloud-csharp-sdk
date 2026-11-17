// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ReadFlowVersionRequest : TeaModel {
        /// <summary>
        /// <para>The business tenant code. Default value: ALICOM_OPAAS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALICOM_OPAAS</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>The business extension information. Default value: an empty set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("BizExtend")]
        [Validation(Required=false)]
        public Dictionary<string, object> BizExtend { get; set; }

        /// <summary>
        /// <para>The draft version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample valueSample value</para>
        /// </summary>
        [NameInMap("DraftVersion")]
        [Validation(Required=false)]
        public string DraftVersion { get; set; }

        /// <summary>
        /// <para>The flow code. You can view the flow code in the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ccc41**************************</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        /// <summary>
        /// <para>The flow version. You can click the flow name in the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> to go to the canvas orchestration page and view the flow version, or call the <a href="https://api.aliyun.com/document/cams/2020-06-06/ListFlowVersion">ListFlowVersion</a> operation to obtain the flow version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FlowVersion")]
        [Validation(Required=false)]
        public string FlowVersion { get; set; }

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
        /// <para>The status of the flow version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DRAFT: Draft.</description></item>
        /// <item><description>DELETED: Deleted.</description></item>
        /// <item><description>ONLINE: Online.</description></item>
        /// <item><description>OFFLINE: Offline.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DRAFT</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
