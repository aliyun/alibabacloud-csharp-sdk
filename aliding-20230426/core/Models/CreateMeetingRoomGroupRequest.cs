// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateMeetingRoomGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>测试分组</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172L</para>
        /// </summary>
        [NameInMap("ParentGroupId")]
        [Validation(Required=false)]
        public long? ParentGroupId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CreateMeetingRoomGroupRequestTenantContext TenantContext { get; set; }
        public class CreateMeetingRoomGroupRequestTenantContext : TeaModel {
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
