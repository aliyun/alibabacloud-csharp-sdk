// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DescTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the template was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-14T13:28Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. It is retained for historical compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Abandoned, historical reasons for compatibility</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95xxx5F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. It is retained for historical compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Abandoned, historical reasons for compatibility</para>
        /// </summary>
        [NameInMap("SmsContent")]
        [Validation(Required=false)]
        public string SmsContent { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. It is retained for historical compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Abandoned, historical reasons for compatibility</para>
        /// </summary>
        [NameInMap("SmsType")]
        [Validation(Required=false)]
        public string SmsType { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. It is retained for historical compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Abandoned, historical reasons for compatibility</para>
        /// </summary>
        [NameInMap("TemplateNickName")]
        [Validation(Required=false)]
        public string TemplateNickName { get; set; }

        /// <summary>
        /// <para>The status of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: The template is a draft.</para>
        /// </description></item>
        /// <item><description><para>1: The template is pending approval.</para>
        /// </description></item>
        /// <item><description><para>2: The template is approved.</para>
        /// </description></item>
        /// <item><description><para>3: The template is rejected.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TemplateStatus")]
        [Validation(Required=false)]
        public string TemplateStatus { get; set; }

        /// <summary>
        /// <para>The template subject, which is used to create the email subject.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TemplateSubject")]
        [Validation(Required=false)]
        public string TemplateSubject { get; set; }

        /// <summary>
        /// <para>The template content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateText")]
        [Validation(Required=false)]
        public string TemplateText { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. It is retained for historical compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Abandoned, historical reasons for compatibility</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
