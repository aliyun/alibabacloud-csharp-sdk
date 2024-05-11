// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DryRunSwaggerShrinkRequest : TeaModel {
        /// <summary>
        /// The Swagger text content.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The Swagger text format:
        /// 
        /// *   json
        /// *   yaml
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        /// <summary>
        /// The global condition.
        /// </summary>
        [NameInMap("GlobalCondition")]
        [Validation(Required=false)]
        public string GlobalConditionShrink { get; set; }

        /// <summary>
        /// The ID of the API group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Specifies whether to overwrite the existing API.
        /// 
        /// APIs with the same HTTP request type and backend request path are considered the same.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
