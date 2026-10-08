// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSubAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57609587-DFA2-41EC-<b><b>-</b></b>*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubAccountList")]
        [Validation(Required=false)]
        public ListSubAccountResponseBodySubAccountList SubAccountList { get; set; }
        public class ListSubAccountResponseBodySubAccountList : TeaModel {
            [NameInMap("SubAccount")]
            [Validation(Required=false)]
            public List<ListSubAccountResponseBodySubAccountListSubAccount> SubAccount { get; set; }
            public class ListSubAccountResponseBodySubAccountListSubAccount : TeaModel {
                [NameInMap("AdminEdasId")]
                [Validation(Required=false)]
                public string AdminEdasId { get; set; }

                [NameInMap("AdminUserId")]
                [Validation(Required=false)]
                public string AdminUserId { get; set; }

                [NameInMap("AdminUserKp")]
                [Validation(Required=false)]
                public string AdminUserKp { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("SubEdasId")]
                [Validation(Required=false)]
                public string SubEdasId { get; set; }

                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public string SubUserId { get; set; }

                [NameInMap("SubUserKp")]
                [Validation(Required=false)]
                public string SubUserKp { get; set; }

            }

        }

    }

}
