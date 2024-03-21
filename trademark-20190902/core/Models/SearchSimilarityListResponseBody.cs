// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class SearchSimilarityListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SearchSimilarityListResponseBodyData> Data { get; set; }
        public class SearchSimilarityListResponseBodyData : TeaModel {
            [NameInMap("ApplyDate")]
            [Validation(Required=false)]
            public string ApplyDate { get; set; }

            [NameInMap("Classification")]
            [Validation(Required=false)]
            public string Classification { get; set; }

            [NameInMap("ExclusiveDateLimit")]
            [Validation(Required=false)]
            public string ExclusiveDateLimit { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("LastProcedureStatus")]
            [Validation(Required=false)]
            public string LastProcedureStatus { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OnSale")]
            [Validation(Required=false)]
            public int? OnSale { get; set; }

            [NameInMap("OwnerAddress")]
            [Validation(Required=false)]
            public string OwnerAddress { get; set; }

            [NameInMap("OwnerEnAddress")]
            [Validation(Required=false)]
            public string OwnerEnAddress { get; set; }

            [NameInMap("OwnerEnName")]
            [Validation(Required=false)]
            public string OwnerEnName { get; set; }

            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            [NameInMap("PreAnnDate")]
            [Validation(Required=false)]
            public string PreAnnDate { get; set; }

            [NameInMap("PreAnnNum")]
            [Validation(Required=false)]
            public string PreAnnNum { get; set; }

            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("ProductDesc")]
            [Validation(Required=false)]
            public string ProductDesc { get; set; }

            [NameInMap("RegAnnDate")]
            [Validation(Required=false)]
            public string RegAnnDate { get; set; }

            [NameInMap("RegAnnNum")]
            [Validation(Required=false)]
            public string RegAnnNum { get; set; }

            [NameInMap("RegistrationNumber")]
            [Validation(Required=false)]
            public string RegistrationNumber { get; set; }

            [NameInMap("Share")]
            [Validation(Required=false)]
            public string Share { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
