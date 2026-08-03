// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class UpdateAdvancedQueryTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the simple query mode.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SimpleQuery")]
        [Validation(Required=false)]
        public bool? SimpleQuery { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>event.eventName: ConsoleSignin AND event.userIdentity.type: root-account</para>
        /// </summary>
        [NameInMap("TemplateSql")]
        [Validation(Required=false)]
        public string TemplateSql { get; set; }

    }

}
