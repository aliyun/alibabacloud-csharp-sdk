// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class ListTrademarkSearchForInnerResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<string> Products { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("TrademarkSearchContents")]
        [Validation(Required=false)]
        public List<ListTrademarkSearchForInnerResponseBodyTrademarkSearchContents> TrademarkSearchContents { get; set; }
        public class ListTrademarkSearchForInnerResponseBodyTrademarkSearchContents : TeaModel {
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

            [NameInMap("NameCharSection")]
            [Validation(Required=false)]
            public string NameCharSection { get; set; }

            [NameInMap("NameOrigin")]
            [Validation(Required=false)]
            public string NameOrigin { get; set; }

            [NameInMap("NameSimplifiedChinese")]
            [Validation(Required=false)]
            public string NameSimplifiedChinese { get; set; }

            [NameInMap("NameSort")]
            [Validation(Required=false)]
            public string NameSort { get; set; }

            [NameInMap("OnSale")]
            [Validation(Required=false)]
            public string OnSale { get; set; }

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

            [NameInMap("ProductDel")]
            [Validation(Required=false)]
            public List<string> ProductDel { get; set; }

            [NameInMap("ProductDescription")]
            [Validation(Required=false)]
            public string ProductDescription { get; set; }

            [NameInMap("RegAnnNum")]
            [Validation(Required=false)]
            public string RegAnnNum { get; set; }

            [NameInMap("RegistrationNumber")]
            [Validation(Required=false)]
            public string RegistrationNumber { get; set; }

            [NameInMap("Share")]
            [Validation(Required=false)]
            public string Share { get; set; }

            [NameInMap("SimilarGroupDel")]
            [Validation(Required=false)]
            public List<string> SimilarGroupDel { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("WellKnow")]
            [Validation(Required=false)]
            public string WellKnow { get; set; }

        }

    }

}
