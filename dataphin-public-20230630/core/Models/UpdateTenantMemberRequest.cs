// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateTenantMemberRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateTenantMemberRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateTenantMemberRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("MemberList")]
            [Validation(Required=false)]
            public List<UpdateTenantMemberRequestUpdateCommandMemberList> MemberList { get; set; }
            public class UpdateTenantMemberRequestUpdateCommandMemberList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123@dingding</para>
                /// </summary>
                [NameInMap("DingNumber")]
                [Validation(Required=false)]
                public string DingNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:123@xx.com">123@xx.com</a></para>
                /// </summary>
                [NameInMap("Mail")]
                [Validation(Required=false)]
                public string Mail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13888888888</para>
                /// </summary>
                [NameInMap("MobilePhone")]
                [Validation(Required=false)]
                public string MobilePhone { get; set; }

                [NameInMap("RoleList")]
                [Validation(Required=false)]
                public List<string> RoleList { get; set; }

                /// <summary>
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
