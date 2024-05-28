// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateWorkItemRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fieldType")]
        [Validation(Required=false)]
        public string FieldType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("propertyKey")]
        [Validation(Required=false)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("propertyValue")]
        [Validation(Required=false)]
        public string PropertyValue { get; set; }

    }

}
