// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatappTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The review status of the message template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pass</b>: The message template is approved.</description></item>
        /// <item><description><b>fail</b>: The message template is rejected.</description></item>
        /// <item><description><b>auditing</b>: The message template is being reviewed.</description></item>
        /// <item><description><b>unaudit</b>: The review is suspended.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public string AuditStatus { get; set; }

        /// <summary>
        /// <para>Template encoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>838888822*****</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The space ID of the user under the ISV account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28251486512358****</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The WhatsApp Business account (WABA) ID of the user within the independent software vendor (ISV) account.</para>
        /// <remarks>
        /// <para> CustWabaId is an obsolete parameter. Use CustSpaceId instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65921621816****</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <para>The independent software vendor (ISV) verification code, which is used to verify whether the user is authorized by the ISV account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skdi3kksloslikdkkdk</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The language that is used in the message template. For more information, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The name of the message template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello_whatsapp</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;page&quot;: &quot;{\&quot;index\&quot;: 1,\&quot;size\&quot;: 20}</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListChatappTemplateRequestPage Page { get; set; }
        public class ListChatappTemplateRequestPage : TeaModel {
            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The type of the message template.</para>
        /// <list type="bullet">
        /// <item><description><b>WHATSAPP</b></description></item>
        /// <item><description><b>VIBER</b></description></item>
        /// <item><description>LINE: the Line message template. This type of message template will be released later.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
