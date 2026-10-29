// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class SendSystemPropertyTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIds")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIds { get; set; }

        /// <summary>
        /// <para>The property template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-angyvganxlf****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The list of property template IDs. If multiple templates are provided, the specified instances are randomly matched with all the provided property templates.</para>
        /// </summary>
        [NameInMap("TemplateIds")]
        [Validation(Required=false)]
        public List<string> TemplateIds { get; set; }

    }

}
