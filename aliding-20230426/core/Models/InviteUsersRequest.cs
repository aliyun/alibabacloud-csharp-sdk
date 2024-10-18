// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class InviteUsersRequest : TeaModel {
        [NameInMap("InviteeList")]
        [Validation(Required=false)]
        public List<InviteUsersRequestInviteeList> InviteeList { get; set; }
        public class InviteUsersRequestInviteeList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试用户</para>
            /// </summary>
            [NameInMap("Nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public InviteUsersRequestTenantContext TenantContext { get; set; }
        public class InviteUsersRequestTenantContext : TeaModel {
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
        /// <para>61289fxxx</para>
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        [NameInMap("phoneInviteeList")]
        [Validation(Required=false)]
        public List<InviteUsersRequestPhoneInviteeList> PhoneInviteeList { get; set; }
        public class InviteUsersRequestPhoneInviteeList : TeaModel {
            [NameInMap("InviteClient")]
            [Validation(Required=false)]
            public bool? InviteClient { get; set; }

            [NameInMap("Nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

        }

    }

}
