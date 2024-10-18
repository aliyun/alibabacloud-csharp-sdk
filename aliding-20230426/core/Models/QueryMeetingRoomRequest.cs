// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryMeetingRoomRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ffb7xxxxx</para>
        /// </summary>
        [NameInMap("RoomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public QueryMeetingRoomRequestTenantContext TenantContext { get; set; }
        public class QueryMeetingRoomRequestTenantContext : TeaModel {
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
