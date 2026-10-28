// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAlertNotifyTemplatesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of notification template IDs.</para>
        /// </summary>
        [NameInMap("alertNotifyTemplateIds")]
        [Validation(Required=false)]
        public string AlertNotifyTemplateIdsShrink { get; set; }

        /// <summary>
        /// <para>The notification template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alert notification template</para>
        /// </summary>
        [NameInMap("alertNotifyTemplateName")]
        [Validation(Required=false)]
        public string AlertNotifyTemplateName { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The template locale.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GO</para>
        /// </summary>
        [NameInMap("programLang")]
        [Validation(Required=false)]
        public string ProgramLang { get; set; }

        /// <summary>
        /// <para>The type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DING</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
