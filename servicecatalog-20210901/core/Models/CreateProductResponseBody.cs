// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateProductResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-bp18r7q127****</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The ID of the product version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv-bp15e79d26****</para>
        /// </summary>
        [NameInMap("ProductVersionId")]
        [Validation(Required=false)]
        public string ProductVersionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F81BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
