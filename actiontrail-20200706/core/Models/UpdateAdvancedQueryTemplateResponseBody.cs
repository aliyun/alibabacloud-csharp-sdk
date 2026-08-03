// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class UpdateAdvancedQueryTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>145318BE-DEE1-4C57-AA7C-5BE7D34A6AE0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the simple query mode is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SimpleQuery")]
        [Validation(Required=false)]
        public string SimpleQuery { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>utpl-QNL3dpYkQcyjZxrIQC****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The name of the template. The maximum length is 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-template</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The query statement of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>event.userIdentity.type: root-account AND event.userIdentity.accessKeyId: *</para>
        /// </summary>
        [NameInMap("TemplateSql")]
        [Validation(Required=false)]
        public string TemplateSql { get; set; }

    }

}
