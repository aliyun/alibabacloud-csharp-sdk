// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PushingSetting : TeaModel {
        /// <summary>
        /// <para>The list of alert action IDs.</para>
        /// </summary>
        [NameInMap("alertActionIds")]
        [Validation(Required=false)]
        public List<string> AlertActionIds { get; set; }

        /// <summary>
        /// <para>The list of restore action IDs.</para>
        /// </summary>
        [NameInMap("restoreActionIds")]
        [Validation(Required=false)]
        public List<string> RestoreActionIds { get; set; }

        /// <summary>
        /// <para>The UUID of the message template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;template-abc123&quot;</para>
        /// </summary>
        [NameInMap("templateUuid")]
        [Validation(Required=false)]
        public string TemplateUuid { get; set; }

    }

}
