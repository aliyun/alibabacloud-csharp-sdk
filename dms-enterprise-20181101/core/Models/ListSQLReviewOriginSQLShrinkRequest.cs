// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLReviewOriginSQLShrinkRequest : TeaModel {
        /// <summary>
        /// The parameters that are used to filter SQL statements involved in the ticket.
        /// </summary>
        [NameInMap("OrderActionDetail")]
        [Validation(Required=false)]
        public string OrderActionDetailShrink { get; set; }

        /// <summary>
        /// The ID of the ticket for the SQL review. You can call the [CreateSQLReviewOrder](https://help.aliyun.com/document_detail/257777.html) operation to query the ID of the ticket.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) or [ListUserTenants](https://help.aliyun.com/document_detail/465818.html) operation to query the ID of the tenant.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
