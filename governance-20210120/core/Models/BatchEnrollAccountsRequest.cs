// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class BatchEnrollAccountsRequest : TeaModel {
        /// <summary>
        /// <para>The resource accounts.</para>
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public List<BatchEnrollAccountsRequestAccounts> Accounts { get; set; }
        public class BatchEnrollAccountsRequestAccounts : TeaModel {
            /// <summary>
            /// <para>The ID of the account to enroll. This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12868156179****</para>
            /// </summary>
            [NameInMap("AccountUid")]
            [Validation(Required=false)]
            public long? AccountUid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the baseline. If you leave this parameter empty, the default baseline is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afb-bp1durvn3lgqe28v****</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public string BaselineId { get; set; }

        /// <summary>
        /// <para>The baseline items.</para>
        /// <para>If you specify this parameter, the baseline item configurations are merged with the configurations of the baseline specified by <c>BaselineId</c>. For duplicate baseline items, the configurations in this parameter take precedence. We recommend that you leave this parameter empty and use <c>BaselineId</c> to apply baseline configurations.</para>
        /// </summary>
        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<BatchEnrollAccountsRequestBaselineItems> BaselineItems { get; set; }
        public class BatchEnrollAccountsRequestBaselineItems : TeaModel {
            /// <summary>
            /// <para>The configurations of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Notifications&quot;:[{&quot;GroupKey&quot;:&quot;account_msg&quot;,&quot;Contacts&quot;:[{&quot;Name&quot;:&quot;aa&quot;}],&quot;PmsgStatus&quot;:1,&quot;EmailStatus&quot;:1,&quot;SmsStatus&quot;:1}]}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The name of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS-BP_ACCOUNT_FACTORY_VPC</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip the baseline item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>false (default): does not skip the baseline item.</para>
            /// </description></item>
            /// <item><description><para>true: skips the baseline item.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// <para>The version of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
