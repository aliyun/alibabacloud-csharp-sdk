// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class LaunchProductResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the instance</para>
        /// 
        /// <b>Example:</b>
        /// <para>pp-bp1ddg1n2a****</para>
        /// </summary>
        [NameInMap("ProvisionedProductId")]
        [Validation(Required=false)]
        public string ProvisionedProductId { get; set; }

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
