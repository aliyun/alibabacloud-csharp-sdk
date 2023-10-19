// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ImportSwaggerShrinkRequest : TeaModel {
        /// <summary>
        /// The Swagger text content.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The Swagger text format:
        /// 
        /// *   json
        /// *   yaml
        /// </summary>
        [NameInMap("DataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        /// <summary>
        /// The pre-inspection.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The global conditions.
        /// </summary>
        [NameInMap("GlobalCondition")]
        [Validation(Required=false)]
        public string GlobalConditionShrink { get; set; }

        /// <summary>
        /// The ID of the API group to which the Swagger is imported.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Specifies whether to overwrite the existing API.
        /// 
        /// APIs with the same HTTP request type and backend request path are considered the same.
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
