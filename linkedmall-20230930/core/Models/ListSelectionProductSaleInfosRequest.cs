// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ListSelectionProductSaleInfosRequest : TeaModel {
        /// <summary>
        /// <para>The parameters for batch querying product sales information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ProductSaleInfoListQuery Body { get; set; }

    }

}
