// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class AssociateProductWithPortfolioRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the product portfolio.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>port-bp1yt7582g****</para>
        /// </summary>
        [NameInMap("PortfolioId")]
        [Validation(Required=false)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// <para>The ID of the product.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-bp18r7q127****</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

    }

}
