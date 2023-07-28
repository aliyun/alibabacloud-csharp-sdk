// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class DeleteTemplateRequest : TeaModel {
        /// <summary>
        /// You can call this operation to delete a template.
        /// </summary>
        [NameInMap("AutoDeleteExecutions")]
        [Validation(Required=false)]
        public bool? AutoDeleteExecutions { get; set; }

        /// <summary>
        /// Specifies whether to delete the related executions when a template is deleted.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
