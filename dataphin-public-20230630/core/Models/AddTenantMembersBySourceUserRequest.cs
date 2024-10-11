// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class AddTenantMembersBySourceUserRequest : TeaModel {
        [NameInMap("AddCommand")]
        [Validation(Required=false)]
        public AddTenantMembersBySourceUserRequestAddCommand AddCommand { get; set; }
        public class AddTenantMembersBySourceUserRequestAddCommand : TeaModel {
            [NameInMap("SourceUserList")]
            [Validation(Required=false)]
            public List<AddTenantMembersBySourceUserRequestAddCommandSourceUserList> SourceUserList { get; set; }
            public class AddTenantMembersBySourceUserRequestAddCommandSourceUserList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:123@xx.com">123@xx.com</a></para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123@dingding</para>
                /// </summary>
                [NameInMap("DingNumber")]
                [Validation(Required=false)]
                public string DingNumber { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

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

                /// <summary>
                /// <b>Example:</b>
                /// <para>2323131</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

            }

        }

        /// <summary>
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
