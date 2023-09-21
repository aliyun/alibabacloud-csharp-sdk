// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceUsagesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceUsages")]
        [Validation(Required=false)]
        public List<ListServiceUsagesResponseBodyServiceUsages> ServiceUsages { get; set; }
        public class ListServiceUsagesResponseBodyServiceUsages : TeaModel {
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("UserAliUid")]
            [Validation(Required=false)]
            public long? UserAliUid { get; set; }

            [NameInMap("UserInformation")]
            [Validation(Required=false)]
            public ListServiceUsagesResponseBodyServiceUsagesUserInformation UserInformation { get; set; }
            public class ListServiceUsagesResponseBodyServiceUsagesUserInformation : TeaModel {
                [NameInMap("Company")]
                [Validation(Required=false)]
                public string Company { get; set; }

                [NameInMap("ContactEmail")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                [NameInMap("ContactNumber")]
                [Validation(Required=false)]
                public string ContactNumber { get; set; }

                [NameInMap("ContactPerson")]
                [Validation(Required=false)]
                public string ContactPerson { get; set; }

                [NameInMap("ContactPersonTitle")]
                [Validation(Required=false)]
                public string ContactPersonTitle { get; set; }

                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                [NameInMap("EmailAddress")]
                [Validation(Required=false)]
                public string EmailAddress { get; set; }

                [NameInMap("Industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ProductBusiness")]
                [Validation(Required=false)]
                public string ProductBusiness { get; set; }

                [NameInMap("ProductDeliveryTypes")]
                [Validation(Required=false)]
                public string ProductDeliveryTypes { get; set; }

                [NameInMap("ProductSellTypes")]
                [Validation(Required=false)]
                public string ProductSellTypes { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("SupplierDesc")]
                [Validation(Required=false)]
                public string SupplierDesc { get; set; }

                [NameInMap("SupplierName")]
                [Validation(Required=false)]
                public string SupplierName { get; set; }

                [NameInMap("SupplierUrl")]
                [Validation(Required=false)]
                public string SupplierUrl { get; set; }

                [NameInMap("Telephone")]
                [Validation(Required=false)]
                public string Telephone { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
