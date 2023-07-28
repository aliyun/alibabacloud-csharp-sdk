// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class DeleteTemplatesRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("AutoDeleteExecutions")]
        [Validation(Required=false)]
        public bool? AutoDeleteExecutions { get; set; }

        /// <summary>
        /// The name list of templates to be deleted.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to delete the related executions when a template is deleted.
        /// </summary>
        [NameInMap("TemplateNames")]
        [Validation(Required=false)]
        public string TemplateNames { get; set; }

    }

}
