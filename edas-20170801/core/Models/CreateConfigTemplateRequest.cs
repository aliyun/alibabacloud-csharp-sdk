// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class CreateConfigTemplateRequest : TeaModel {
        /// <summary>
        /// The content of the configuration template. The value must be in the format that is specified by the Format parameter.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The description of the configuration template. The description can be up to 255 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The data format of the configuration template. Valid values:
        /// 
        /// *   JSON: JSON format
        /// *   XML: XML format
        /// *   YAML: YAML format
        /// *   Properties: .properties format
        /// *   KeyValue: key-value pairs
        /// *   Custom: custom format
        /// </summary>
        [NameInMap("Format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// The name of the configuration template. The name can be up to 64 characters in length.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
