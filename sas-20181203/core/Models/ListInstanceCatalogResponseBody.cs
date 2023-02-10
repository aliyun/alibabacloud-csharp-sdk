// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInstanceCatalogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<ListInstanceCatalogResponseBodyVendors> Vendors { get; set; }
        public class ListInstanceCatalogResponseBodyVendors : TeaModel {
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<ListInstanceCatalogResponseBodyVendorsInstanceTypes> InstanceTypes { get; set; }
            public class ListInstanceCatalogResponseBodyVendorsInstanceTypes : TeaModel {
                [NameInMap("InstanceSubTypes")]
                [Validation(Required=false)]
                public List<ListInstanceCatalogResponseBodyVendorsInstanceTypesInstanceSubTypes> InstanceSubTypes { get; set; }
                public class ListInstanceCatalogResponseBodyVendorsInstanceTypesInstanceSubTypes : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
