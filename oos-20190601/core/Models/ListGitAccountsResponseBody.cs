// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListGitAccountsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("GitAccounts")]
        [Validation(Required=false)]
        public List<ListGitAccountsResponseBodyGitAccounts> GitAccounts { get; set; }
        public class ListGitAccountsResponseBodyGitAccounts : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>LYH-RAIN</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1457F46C-7AAE-59FA-BD12-0BDB3751E6F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
