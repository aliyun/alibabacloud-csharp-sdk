// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetSQLReviewOptimizeDetailRequest : TeaModel {
        /// <summary>
        /// The key that is used to query the details of optimization suggestions. You can call the [ListSQLReviewOriginSQL](https://help.aliyun.com/document_detail/257870.html) operation to query the key.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SQLReviewQueryKey")]
        [Validation(Required=false)]
        public string SQLReviewQueryKey { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) or [ListUserTenants](https://help.aliyun.com/document_detail/198074.html) operation to query the ID of the tenant.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
