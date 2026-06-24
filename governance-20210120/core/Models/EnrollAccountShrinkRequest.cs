// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class EnrollAccountShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The prefix for the account name.</para>
        /// <list type="bullet">
        /// <item><description><para>If you are creating a new resource account, this parameter is required.</para>
        /// </description></item>
        /// <item><description><para>If you are enrolling an existing account, this parameter is not required.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test-account</para>
        /// </summary>
        [NameInMap("AccountNamePrefix")]
        [Validation(Required=false)]
        public string AccountNamePrefix { get; set; }

        /// <summary>
        /// <para>The ID of the account to enroll.</para>
        /// <list type="bullet">
        /// <item><description><para>If you are creating a new resource account, this parameter is not required.</para>
        /// </description></item>
        /// <item><description><para>If you are enrolling an existing account, this parameter is required.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12868156179****</para>
        /// </summary>
        [NameInMap("AccountUid")]
        [Validation(Required=false)]
        public long? AccountUid { get; set; }

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
        /// <para>The display name of the account.</para>
        /// <list type="bullet">
        /// <item><description><para>If you are creating a new resource account, this parameter is required.</para>
        /// </description></item>
        /// <item><description><para>If you are enrolling an existing account, this parameter is not required.</para>
        /// </description></item>
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
        /// <item><description><para>If you are creating a new resource account and do not specify this parameter, the account is created in the Root folder.</para>
        /// </description></item>
        /// <item><description><para>If you are enrolling an existing account, this parameter is not required.</para>
        /// </description></item>
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
        /// <item><description><para>If you are creating a new resource account and do not specify this parameter, the self-pay settlement method is used.</para>
        /// </description></item>
        /// <item><description><para>If you are enrolling an existing account, this parameter is not required.</para>
        /// </description></item>
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
        /// <item><description><para>resell (default): The member is a reseller account. A reseller relationship is automatically established between the member and the reseller. The management account of the resource directory is used as the billing account of the member.</para>
        /// </description></item>
        /// <item><description><para>non_resell: The member is a non-reseller account. The member is not associated with a reseller and can directly purchase Alibaba Cloud resources. The member is used as its own billing account.</para>
        /// </description></item>
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
