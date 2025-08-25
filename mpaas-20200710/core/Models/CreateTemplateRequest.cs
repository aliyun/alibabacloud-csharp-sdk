// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class CreateTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ALIPUB9A63274111812</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hh</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("DescInfo")]
        [Validation(Required=false)]
        public string DescInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;defaultUrl&quot;: &quot;<a href="http://111%22%7D">http://111&quot;}</a></para>
        /// </summary>
        [NameInMap("IconUrls")]
        [Validation(Required=false)]
        public string IconUrls { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;defaultUrl&quot;: &quot;<a href="http://111%22%7D">http://111&quot;}</a></para>
        /// </summary>
        [NameInMap("ImageUrls")]
        [Validation(Required=false)]
        public string ImageUrls { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("JumpAction")]
        [Validation(Required=false)]
        public int? JumpAction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PushStyle")]
        [Validation(Required=false)]
        public int? PushStyle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ShowStyle")]
        [Validation(Required=false)]
        public long? ShowStyle { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NPHTGKNR</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OKOK</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://jsonplaceholder.typicode.com/nonexistent">https://jsonplaceholder.typicode.com/nonexistent</a></para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>title,content</para>
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
