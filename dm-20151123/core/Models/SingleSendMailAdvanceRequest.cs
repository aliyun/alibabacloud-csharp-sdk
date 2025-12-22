// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SingleSendMailAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public int? AddressType { get; set; }

        [NameInMap("Attachments")]
        [Validation(Required=false)]
        public List<SingleSendMailAdvanceRequestAttachments> Attachments { get; set; }
        public class SingleSendMailAdvanceRequestAttachments : TeaModel {
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            [NameInMap("AttachmentUrl")]
            [Validation(Required=false)]
            public Stream AttachmentUrlObject { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:1@example.com">1@example.com</a>,<a href="mailto:2@example.com">2@example.com</a></para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("BccAddress")]
        [Validation(Required=false)]
        public string BccAddress { get; set; }

        [NameInMap("ClickTrace")]
        [Validation(Required=false)]
        public string ClickTrace { get; set; }

        [NameInMap("FromAlias")]
        [Validation(Required=false)]
        public string FromAlias { get; set; }

        [NameInMap("Headers")]
        [Validation(Required=false)]
        public string Headers { get; set; }

        [NameInMap("HtmlBody")]
        [Validation(Required=false)]
        public string HtmlBody { get; set; }

        [NameInMap("IpPoolId")]
        [Validation(Required=false)]
        public string IpPoolId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ReplyAddress")]
        [Validation(Required=false)]
        public string ReplyAddress { get; set; }

        [NameInMap("ReplyAddressAlias")]
        [Validation(Required=false)]
        public string ReplyAddressAlias { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ReplyToAddress")]
        [Validation(Required=false)]
        public bool? ReplyToAddress { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public SingleSendMailAdvanceRequestTemplate Template { get; set; }
        public class SingleSendMailAdvanceRequestTemplate : TeaModel {
            [NameInMap("TemplateData")]
            [Validation(Required=false)]
            public Dictionary<string, string> TemplateData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        [NameInMap("TextBody")]
        [Validation(Required=false)]
        public string TextBody { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ToAddress")]
        [Validation(Required=false)]
        public string ToAddress { get; set; }

        [NameInMap("UnSubscribeFilterLevel")]
        [Validation(Required=false)]
        public string UnSubscribeFilterLevel { get; set; }

        [NameInMap("UnSubscribeLinkType")]
        [Validation(Required=false)]
        public string UnSubscribeLinkType { get; set; }

    }

}
