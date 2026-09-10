// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class DeleteDataCheckTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The list of validation template IDs. Batch operations are supported.</para>
        /// </summary>
        [NameInMap("templateIds")]
        [Validation(Required=false)]
        public List<string> TemplateIds { get; set; }

    }

}
