// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetProvisionedProductRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the product instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pp-bp1ddg1n2a****</para>
        /// </summary>
        [NameInMap("ProvisionedProductId")]
        [Validation(Required=false)]
        public string ProvisionedProductId { get; set; }

    }

}
