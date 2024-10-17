// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetSQLReviewOptimizeDetailRequest : TeaModel {
        /// <summary>
        /// <para>The key that is used to query the details of optimization suggestions. You can call the <a href="https://help.aliyun.com/document_detail/257870.html">ListSQLReviewOriginSQL</a> operation to query the key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a57e54ec5433475ea3082d882fdb****</para>
        /// </summary>
        [NameInMap("SQLReviewQueryKey")]
        [Validation(Required=false)]
        public string SQLReviewQueryKey { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to query the ID of the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
