// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class AddTenantMembersBySourceUserRequest : TeaModel {
        /// <summary>
        /// <para>The add request.</para>
        /// </summary>
        [NameInMap("AddCommand")]
        [Validation(Required=false)]
        public AddTenantMembersBySourceUserRequestAddCommand AddCommand { get; set; }
        public class AddTenantMembersBySourceUserRequestAddCommand : TeaModel {
            /// <summary>
            /// <para>The list of source users.</para>
            /// </summary>
            [NameInMap("SourceUserList")]
            [Validation(Required=false)]
            public List<AddTenantMembersBySourceUserRequestAddCommandSourceUserList> SourceUserList { get; set; }
            public class AddTenantMembersBySourceUserRequestAddCommandSourceUserList : TeaModel {
                /// <summary>
                /// <para>The account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:123@xx.com">123@xx.com</a></para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

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
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

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
                /// <para>The original ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2323131</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

            }

        }

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

    }

}
