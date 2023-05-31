// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInstanceCatalogResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the asset types by service provider.
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<ListInstanceCatalogResponseBodyVendors> Vendors { get; set; }
        public class ListInstanceCatalogResponseBodyVendors : TeaModel {
            /// <summary>
            /// An array that consists of asset types.
            /// </summary>
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<ListInstanceCatalogResponseBodyVendorsInstanceTypes> InstanceTypes { get; set; }
            public class ListInstanceCatalogResponseBodyVendorsInstanceTypes : TeaModel {
                /// <summary>
                /// An array that consists of asset subtypes.
                /// </summary>
                [NameInMap("InstanceSubTypes")]
                [Validation(Required=false)]
                public List<ListInstanceCatalogResponseBodyVendorsInstanceTypesInstanceSubTypes> InstanceSubTypes { get; set; }
                public class ListInstanceCatalogResponseBodyVendorsInstanceTypesInstanceSubTypes : TeaModel {
                    /// <summary>
                    /// The name of the asset subtype.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The name of the asset type.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The name of the service provider.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
