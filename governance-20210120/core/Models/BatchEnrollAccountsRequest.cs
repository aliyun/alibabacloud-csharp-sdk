// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class BatchEnrollAccountsRequest : TeaModel {
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public List<BatchEnrollAccountsRequestAccounts> Accounts { get; set; }
        public class BatchEnrollAccountsRequestAccounts : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12868156179****</para>
            /// </summary>
            [NameInMap("AccountUid")]
            [Validation(Required=false)]
            public long? AccountUid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>afb-bp1durvn3lgqe28v****</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public string BaselineId { get; set; }

        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<BatchEnrollAccountsRequestBaselineItems> BaselineItems { get; set; }
        public class BatchEnrollAccountsRequestBaselineItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;Notifications\&quot;:[{\&quot;GroupKey\&quot;:\&quot;account_msg\&quot;,\&quot;Contacts\&quot;:[{\&quot;Name\&quot;:\&quot;aa\&quot;}],\&quot;PmsgStatus\&quot;:1,\&quot;EmailStatus\&quot;:1,\&quot;SmsStatus\&quot;:1}]}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACS-BP_ACCOUNT_FACTORY_VPC</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
