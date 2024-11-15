// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class EnrollAccountShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The prefix for the account name of the member.</para>
        /// <list type="bullet">
        /// <item><description>If the account baseline is applied to an account that is newly created, you must configure this parameter.</description></item>
        /// <item><description>If the account baseline is applied to an existing account, you do not need to configure this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test-account</para>
        /// </summary>
        [NameInMap("AccountNamePrefix")]
        [Validation(Required=false)]
        public string AccountNamePrefix { get; set; }

        /// <summary>
        /// <para>The account ID.</para>
        /// <list type="bullet">
        /// <item><description>If the account baseline is applied to an account that is newly created, you do not need to configure this parameter.</description></item>
        /// <item><description>If the account baseline is applied to an existing account, you must configure this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12868156179****</para>
        /// </summary>
        [NameInMap("AccountUid")]
        [Validation(Required=false)]
        public long? AccountUid { get; set; }

        /// <summary>
        /// <para>The baseline ID.</para>
        /// <para>If this parameter is left empty, the default baseline is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afb-bp1durvn3lgqe28v****</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public string BaselineId { get; set; }

        /// <summary>
        /// <para>An array that contains baseline items.</para>
        /// <para>If this parameter is specified, the configurations of the baseline items are merged with the baseline of the specified account. The configurations of the same baseline items are subject to the configuration of this parameter. We recommend that you leave this parameter empty and configure the <c>BaselineId</c> parameter to specify an account baseline and apply the configuration of the account baseline to the account.</para>
        /// </summary>
        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<EnrollAccountShrinkRequestBaselineItems> BaselineItems { get; set; }
        public class EnrollAccountShrinkRequestBaselineItems : TeaModel {
            /// <summary>
            /// <para>The configurations of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Notifications\&quot;:[{\&quot;GroupKey\&quot;:\&quot;account_msg\&quot;,\&quot;Contacts\&quot;:[{\&quot;Name\&quot;:\&quot;aa\&quot;}],\&quot;PmsgStatus\&quot;:1,\&quot;EmailStatus\&quot;:1,\&quot;SmsStatus\&quot;:1}]}</para>
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
            /// <item><description>false: The baseline item is not skipped.</description></item>
            /// <item><description>true: The baseline item is skipped.</description></item>
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
        /// <para>The display name of the account.</para>
        /// <list type="bullet">
        /// <item><description>If the account baseline is applied to an account that is newly created, you must configure this parameter.</description></item>
        /// <item><description>If the account baseline is applied to an existing account, you do not need to configure this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test-account</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The ID of the parent folder.</para>
        /// <list type="bullet">
        /// <item><description>If the account baseline is applied to an account that is newly created, you need to specify a parent folder. If you do not configure this parameter, the account is created in the Root folder.</description></item>
        /// <item><description>If the account baseline is applied to an existing account, you do not need to configure this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fd-5ESoku****</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>The ID of the billing account.</para>
        /// <list type="bullet">
        /// <item><description>If the account baseline is applied to an account that is newly created, you need to specify a billing account. If you do not configure this parameter, the self-pay settlement method is used for the account.</description></item>
        /// <item><description>If the account baseline is applied to an existing account, you do not need to configure this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>19534534552****</para>
        /// </summary>
        [NameInMap("PayerAccountUid")]
        [Validation(Required=false)]
        public long? PayerAccountUid { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The identity type of the member. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>resell (default): The member is an account for a reseller. A relationship is automatically established between the member and the reseller. The management account of the resource directory must be used as the billing account of the member.</description></item>
        /// <item><description>non_resell: The member is not an account for a reseller. The member is an account that is not associated with a reseller. You can directly use the account to purchase Alibaba Cloud resources. The member is used as its own billing account.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only for resellers at the international site (alibabacloud.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>resell</para>
        /// </summary>
        [NameInMap("ResellAccountType")]
        [Validation(Required=false)]
        public string ResellAccountType { get; set; }

        /// <summary>
        /// <para>The tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
