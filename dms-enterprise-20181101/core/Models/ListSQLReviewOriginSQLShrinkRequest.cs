// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLReviewOriginSQLShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The parameters that are used to filter SQL statements involved in the ticket.</para>
        /// </summary>
        [NameInMap("OrderActionDetail")]
        [Validation(Required=false)]
        public string OrderActionDetailShrink { get; set; }

        /// <summary>
        /// <para>The ID of the SQL review ticket. You can call the <a href="https://help.aliyun.com/document_detail/257777.html">CreateSQLReviewOrder</a> operation to query the ticket ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123321</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
