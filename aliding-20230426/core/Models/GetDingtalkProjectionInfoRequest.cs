// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetDingtalkProjectionInfoRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetDingtalkProjectionInfoRequestTenantContext TenantContext { get; set; }
        public class GetDingtalkProjectionInfoRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("client")]
        [Validation(Required=false)]
        public string Client { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1640998800000</para>
        /// </summary>
        [NameInMap("endTs")]
        [Validation(Required=false)]
        public long? EndTs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21001</para>
        /// </summary>
        [NameInMap("orgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>342342</para>
        /// </summary>
        [NameInMap("pubWorkNo")]
        [Validation(Required=false)]
        public string PubWorkNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>room001</para>
        /// </summary>
        [NameInMap("roomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1640995200000</para>
        /// </summary>
        [NameInMap("startTs")]
        [Validation(Required=false)]
        public long? StartTs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user456</para>
        /// </summary>
        [NameInMap("subUid")]
        [Validation(Required=false)]
        public string SubUid { get; set; }

    }

}
