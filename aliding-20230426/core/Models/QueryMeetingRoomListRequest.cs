// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryMeetingRoomListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>124L</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public QueryMeetingRoomListRequestTenantContext TenantContext { get; set; }
        public class QueryMeetingRoomListRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
