// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class QueryRedemptionRecordsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("externalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ORD20240101000001</para>
        /// </summary>
        [NameInMap("redemptionOrderNo")]
        [Validation(Required=false)]
        public string RedemptionOrderNo { get; set; }

    }

}
