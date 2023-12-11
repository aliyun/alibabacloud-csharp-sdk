// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ListPropertyResponseBody : TeaModel {
        /// <summary>
        /// The token that is used for the next query. If this parameter is empty, all results have been returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The information about the properties.
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public List<ListPropertyResponseBodyProperties> Properties { get; set; }
        public class ListPropertyResponseBodyProperties : TeaModel {
            /// <summary>
            /// The ID of the property.
            /// </summary>
            [NameInMap("PropertyId")]
            [Validation(Required=false)]
            public long? PropertyId { get; set; }

            /// <summary>
            /// The name of the property.
            /// </summary>
            [NameInMap("PropertyKey")]
            [Validation(Required=false)]
            public string PropertyKey { get; set; }

            /// <summary>
            /// Details about the property values.
            /// </summary>
            [NameInMap("PropertyValues")]
            [Validation(Required=false)]
            public List<ListPropertyResponseBodyPropertiesPropertyValues> PropertyValues { get; set; }
            public class ListPropertyResponseBodyPropertiesPropertyValues : TeaModel {
                /// <summary>
                /// The value of the property.
                /// </summary>
                [NameInMap("PropertyValue")]
                [Validation(Required=false)]
                public string PropertyValue { get; set; }

                /// <summary>
                /// The ID of the property value.
                /// </summary>
                [NameInMap("PropertyValueId")]
                [Validation(Required=false)]
                public long? PropertyValueId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
