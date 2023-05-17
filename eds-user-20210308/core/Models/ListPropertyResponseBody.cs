// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ListPropertyResponseBody : TeaModel {
        /// <summary>
        /// The information about the properties.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public List<ListPropertyResponseBodyProperties> Properties { get; set; }
        public class ListPropertyResponseBodyProperties : TeaModel {
            /// <summary>
            /// The operation that you want to perform. Set the value to **ListProperty**.
            /// </summary>
            [NameInMap("PropertyId")]
            [Validation(Required=false)]
            public long? PropertyId { get; set; }

            /// <summary>
            /// Queries all user properties within an Alibaba Cloud account.
            /// </summary>
            [NameInMap("PropertyKey")]
            [Validation(Required=false)]
            public string PropertyKey { get; set; }

            /// <summary>
            /// ListProperty
            /// </summary>
            [NameInMap("PropertyValues")]
            [Validation(Required=false)]
            public List<ListPropertyResponseBodyPropertiesPropertyValues> PropertyValues { get; set; }
            public class ListPropertyResponseBodyPropertiesPropertyValues : TeaModel {
                [NameInMap("PropertyValue")]
                [Validation(Required=false)]
                public string PropertyValue { get; set; }

                [NameInMap("PropertyValueId")]
                [Validation(Required=false)]
                public long? PropertyValueId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the property.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
