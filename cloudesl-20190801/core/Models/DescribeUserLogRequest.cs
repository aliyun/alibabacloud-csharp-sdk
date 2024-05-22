// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class DescribeUserLogRequest : TeaModel {
        [NameInMap("EslBarCode")]
        [Validation(Required=false)]
        public string EslBarCode { get; set; }

        [NameInMap("FromDate")]
        [Validation(Required=false)]
        public string FromDate { get; set; }

        [NameInMap("ItemBarCode")]
        [Validation(Required=false)]
        public string ItemBarCode { get; set; }

        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

        [NameInMap("ItemTitle")]
        [Validation(Required=false)]
        public string ItemTitle { get; set; }

        [NameInMap("OperateStatus")]
        [Validation(Required=false)]
        public string OperateStatus { get; set; }

        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        [NameInMap("OperateUserId")]
        [Validation(Required=false)]
        public long? OperateUserId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

        [NameInMap("ToDate")]
        [Validation(Required=false)]
        public string ToDate { get; set; }

    }

}
