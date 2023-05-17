// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UpdatePropertyRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **UpdateProperty**.
        /// </summary>
        [NameInMap("PropertyId")]
        [Validation(Required=false)]
        public long? PropertyId { get; set; }

        /// <summary>
        /// The property values that failed to be modified.
        /// </summary>
        [NameInMap("PropertyKey")]
        [Validation(Required=false)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// The new property value N.
        /// </summary>
        [NameInMap("PropertyValues")]
        [Validation(Required=false)]
        public List<UpdatePropertyRequestPropertyValues> PropertyValues { get; set; }
        public class UpdatePropertyRequestPropertyValues : TeaModel {
            /// <summary>
            /// The error code.
            /// </summary>
            [NameInMap("PropertyValue")]
            [Validation(Required=false)]
            public string PropertyValue { get; set; }

            /// <summary>
            /// The ID of the property that you want to modify. You can call the [ListProperty](~~410890~~) operation to query the property ID.
            /// </summary>
            [NameInMap("PropertyValueId")]
            [Validation(Required=false)]
            public long? PropertyValueId { get; set; }

        }

    }

}
