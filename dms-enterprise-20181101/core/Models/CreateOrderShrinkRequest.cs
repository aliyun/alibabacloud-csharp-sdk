// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateOrderShrinkRequest : TeaModel {
        /// <summary>
        /// test_AttachmentKey
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// The key of an attachment that is returned after the attachment is uploaded. You can call the [GetUserUploadFileJob](~~206069~~) operation to query the key of the attachment.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("PluginParam")]
        [Validation(Required=false)]
        public string PluginParamShrink { get; set; }

        /// <summary>
        /// The ID of the ticket.
        /// </summary>
        [NameInMap("PluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

        /// <summary>
        /// The IDs of the stakeholders that are involved in the ticket. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public string RelatedUserList { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
