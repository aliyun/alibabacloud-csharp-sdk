// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetPortfolioResponseBody : TeaModel {
        /// <summary>
        /// The details of the product portfolio.
        /// </summary>
        [NameInMap("PortfolioDetail")]
        [Validation(Required=false)]
        public GetPortfolioResponseBodyPortfolioDetail PortfolioDetail { get; set; }
        public class GetPortfolioResponseBodyPortfolioDetail : TeaModel {
            /// <summary>
            /// The time when the product portfolio was created.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the product portfolio.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the product portfolio.
            /// </summary>
            [NameInMap("PortfolioArn")]
            [Validation(Required=false)]
            public string PortfolioArn { get; set; }

            /// <summary>
            /// The ID of the product portfolio.
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// The name of the product portfolio.
            /// </summary>
            [NameInMap("PortfolioName")]
            [Validation(Required=false)]
            public string PortfolioName { get; set; }

            /// <summary>
            /// The provider of the product portfolio.
            /// </summary>
            [NameInMap("ProviderName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The tag options associated with the service portfolio.
        /// </summary>
        [NameInMap("TagOptions")]
        [Validation(Required=false)]
        public List<GetPortfolioResponseBodyTagOptions> TagOptions { get; set; }
        public class GetPortfolioResponseBodyTagOptions : TeaModel {
            /// <summary>
            /// Indicates whether the tag option is enabled. Valid values:
            /// 
            /// - true (default)
            /// - false
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// The key of the tag option.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The ID of the owner of the tag option.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The ID of the tag option.
            /// </summary>
            [NameInMap("TagOptionId")]
            [Validation(Required=false)]
            public string TagOptionId { get; set; }

            /// <summary>
            /// The value of the tag option.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
