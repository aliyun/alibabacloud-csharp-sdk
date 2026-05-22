// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetUserIdByOpenDingtalkIdRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetUserIdByOpenDingtalkIdRequestTenantContext TenantContext { get; set; }
        public class GetUserIdByOpenDingtalkIdRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DTOJdYJ2IQC4HuexhtjsSXXXX</para>
        /// </summary>
        [NameInMap("openDingtalkId")]
        [Validation(Required=false)]
        public string OpenDingtalkId { get; set; }

    }

}
