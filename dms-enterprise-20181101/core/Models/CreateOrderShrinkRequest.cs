// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateOrderShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The key of an attachment that is returned after the attachment is uploaded. You can call the <a href="https://help.aliyun.com/document_detail/206069.html">GetUserUploadFileJob</a> operation to query the key of the attachment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_AttachmentKey</para>
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// <para>The description of the ticket to be created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ticket creation parameter. The value is a JSON string. The value of this parameter differs based on the type of the ticket. For more information, see the <b>PluginParam parameter</b> section in this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{PluginParam_test}</para>
        /// </summary>
        [NameInMap("PluginParam")]
        [Validation(Required=false)]
        public string PluginParamShrink { get; set; }

        /// <summary>
        /// <para>The type of the ticket. For more information, see <a href="https://help.aliyun.com/document_detail/429109.html">PluginType parameter</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATA_EXPORT</para>
        /// </summary>
        [NameInMap("PluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

        [NameInMap("RealLoginUserUid")]
        [Validation(Required=false)]
        public string RealLoginUserUid { get; set; }

        /// <summary>
        /// <para>The IDs of the stakeholders that are involved in the ticket. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1,user2</para>
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public string RelatedUserList { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
