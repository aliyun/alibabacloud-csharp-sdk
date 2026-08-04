// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SpotStockItem : TeaModel {
        /// <summary>
        /// <para>The instance type.</para>
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Internal information about the stock of the spot instance type.</para>
        /// </summary>
        [NameInMap("internalInfo")]
        [Validation(Required=false)]
        public List<SpotStockInternalInfo> InternalInfo { get; set; }

        /// <summary>
        /// <para>The stock status of the instance type. Valid values are <c>Available</c> and <c>SoldOut</c>.</para>
        /// </summary>
        [NameInMap("stockStatus")]
        [Validation(Required=false)]
        public string StockStatus { get; set; }

    }

}
