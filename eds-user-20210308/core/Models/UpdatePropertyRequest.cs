// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UpdatePropertyRequest : TeaModel {
        /// <summary>
        /// The ID of the property that you want to modify. You can call the [ListProperty](https://help.aliyun.com/document_detail/410890.html) operation to query the property ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PropertyId")]
        [Validation(Required=false)]
        public long? PropertyId { get; set; }

        /// <summary>
        /// The new property name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PropertyKey")]
        [Validation(Required=false)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// The values of property.
        /// </summary>
        [NameInMap("PropertyValues")]
        [Validation(Required=false)]
        public List<UpdatePropertyRequestPropertyValues> PropertyValues { get; set; }
        public class UpdatePropertyRequestPropertyValues : TeaModel {
            /// <summary>
            /// The new property value.
            /// </summary>
            [NameInMap("PropertyValue")]
            [Validation(Required=false)]
            public string PropertyValue { get; set; }

            /// <summary>
            /// The ID of property value that you want to modify. You can call the [ListProperty](https://help.aliyun.com/document_detail/410890.html) operation to query the property value ID.
            /// </summary>
            [NameInMap("PropertyValueId")]
            [Validation(Required=false)]
            public long? PropertyValueId { get; set; }

        }

    }

}
