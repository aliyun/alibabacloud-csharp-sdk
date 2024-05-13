// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchDataTrackResultShrinkRequest : TeaModel {
        /// <summary>
        /// The condition to filter columns.
        /// </summary>
        [NameInMap("ColumnFilter")]
        [Validation(Required=false)]
        public string ColumnFilterShrink { get; set; }

        /// <summary>
        /// The end time of the time range in which you want to track data operations. The time must be in the yyyy-MM-dd HH:mm:ss format.
        /// </summary>
        [NameInMap("FilterEndTime")]
        [Validation(Required=false)]
        public string FilterEndTime { get; set; }

        /// <summary>
        /// The start time of the time range in which you want to track data operations. The time must be in the yyyy-MM-dd HH:mm:ss format.
        /// </summary>
        [NameInMap("FilterStartTime")]
        [Validation(Required=false)]
        public string FilterStartTime { get; set; }

        /// <summary>
        /// The names of the tables for which you want to track data operations.
        /// </summary>
        [NameInMap("FilterTableList")]
        [Validation(Required=false)]
        public string FilterTableListShrink { get; set; }

        /// <summary>
        /// The types of data operations that you want to track.
        /// </summary>
        [NameInMap("FilterTypeList")]
        [Validation(Required=false)]
        public string FilterTypeListShrink { get; set; }

        /// <summary>
        /// The ID of the ticket. You can call the [ListOrders](https://help.aliyun.com/document_detail/144643.html) operation to query the ticket ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) or [ListUserTenants](https://help.aliyun.com/document_detail/198074.html) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
