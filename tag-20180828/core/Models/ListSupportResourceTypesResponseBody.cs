// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListSupportResourceTypesResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the next query is required.
        /// 
        /// *   If the value of this parameter is empty, all results are returned, and the next query is not required.
        /// *   If the value of this parameter is not empty, the next query is required, and the value is the token used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The supported resource types.
        /// </summary>
        [NameInMap("SupportResourceTypes")]
        [Validation(Required=false)]
        public List<ListSupportResourceTypesResponseBodySupportResourceTypes> SupportResourceTypes { get; set; }
        public class ListSupportResourceTypesResponseBodySupportResourceTypes : TeaModel {
            /// <summary>
            /// The service code.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The resource type.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The supported tag-related capability items.
            /// 
            /// >  This parameter is returned only if the `ShowItems` parameter is set to `true`.
            /// </summary>
            [NameInMap("SupportItems")]
            [Validation(Required=false)]
            public List<ListSupportResourceTypesResponseBodySupportResourceTypesSupportItems> SupportItems { get; set; }
            public class ListSupportResourceTypesResponseBodySupportResourceTypesSupportItems : TeaModel {
                /// <summary>
                /// Indicates whether the tag-related capability item is supported. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("Support")]
                [Validation(Required=false)]
                public bool? Support { get; set; }

                /// <summary>
                /// The code of the tag-related capability item.
                /// </summary>
                [NameInMap("SupportCode")]
                [Validation(Required=false)]
                public string SupportCode { get; set; }

                /// <summary>
                /// The details of the support for the tag-related capability item.
                /// </summary>
                [NameInMap("SupportDetails")]
                [Validation(Required=false)]
                public List<Dictionary<string, string>> SupportDetails { get; set; }

            }

        }

    }

}
