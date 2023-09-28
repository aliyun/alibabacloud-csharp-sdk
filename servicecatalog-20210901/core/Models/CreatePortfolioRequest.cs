// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreatePortfolioRequest : TeaModel {
        /// <summary>
        /// The description of the product portfolio.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the product portfolio.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("PortfolioName")]
        [Validation(Required=false)]
        public string PortfolioName { get; set; }

        /// <summary>
        /// The provider of the product portfolio.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("ProviderName")]
        [Validation(Required=false)]
        public string ProviderName { get; set; }

    }

}
