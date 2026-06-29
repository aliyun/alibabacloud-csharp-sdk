// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateTenantMemberRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The request object.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateTenantMemberRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateTenantMemberRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The list of members.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("MemberList")]
            [Validation(Required=false)]
            public List<UpdateTenantMemberRequestUpdateCommandMemberList> MemberList { get; set; }
            public class UpdateTenantMemberRequestUpdateCommandMemberList : TeaModel {
                /// <summary>
                /// <para>The DingTalk number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123@dingding</para>
                /// </summary>
                [NameInMap("DingNumber")]
                [Validation(Required=false)]
                public string DingNumber { get; set; }

                /// <summary>
                /// <para>The email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:123@xx.com">123@xx.com</a></para>
                /// </summary>
                [NameInMap("Mail")]
                [Validation(Required=false)]
                public string Mail { get; set; }

                /// <summary>
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13888888888</para>
                /// </summary>
                [NameInMap("MobilePhone")]
                [Validation(Required=false)]
                public string MobilePhone { get; set; }

                /// <summary>
                /// <para>The list of roles.</para>
                /// </summary>
                [NameInMap("RoleList")]
                [Validation(Required=false)]
                public List<string> RoleList { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2331</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
