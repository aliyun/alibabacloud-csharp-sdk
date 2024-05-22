// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class DescribeEslDevicesRequest : TeaModel {
        [NameInMap("BeBind")]
        [Validation(Required=false)]
        public bool? BeBind { get; set; }

        [NameInMap("EslBarCode")]
        [Validation(Required=false)]
        public string EslBarCode { get; set; }

        [NameInMap("EslStatus")]
        [Validation(Required=false)]
        public string EslStatus { get; set; }

        [NameInMap("FromBatteryLevel")]
        [Validation(Required=false)]
        public int? FromBatteryLevel { get; set; }

        [NameInMap("ItemBarCode")]
        [Validation(Required=false)]
        public string ItemBarCode { get; set; }

        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ShelfCode")]
        [Validation(Required=false)]
        public string ShelfCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

        [NameInMap("ToBatteryLevel")]
        [Validation(Required=false)]
        public int? ToBatteryLevel { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
