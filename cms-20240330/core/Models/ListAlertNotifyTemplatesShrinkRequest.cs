// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAlertNotifyTemplatesShrinkRequest : TeaModel {
        [NameInMap("alertNotifyTemplateIds")]
        [Validation(Required=false)]
        public string AlertNotifyTemplateIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>告警通知模板</para>
        /// </summary>
        [NameInMap("alertNotifyTemplateName")]
        [Validation(Required=false)]
        public string AlertNotifyTemplateName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GO</para>
        /// </summary>
        [NameInMap("programLang")]
        [Validation(Required=false)]
        public string ProgramLang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DING</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
