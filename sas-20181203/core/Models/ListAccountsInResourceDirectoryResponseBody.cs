// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAccountsInResourceDirectoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The members in the resource directory.</para>
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public List<ListAccountsInResourceDirectoryResponseBodyAccounts> Accounts { get; set; }
        public class ListAccountsInResourceDirectoryResponseBodyAccounts : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180803538814****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This parameter is deprecated and should be ignored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BuySas")]
            [Validation(Required=false)]
            [Obsolete]
            public int? BuySas { get; set; }

            /// <summary>
            /// <para>Whether a yearly or monthly subscription of Cloud Security Center is purchased. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes</description></item>
            /// <item><description><b>false</b>: No</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BuySasNew")]
            [Validation(Required=false)]
            public bool? BuySasNew { get; set; }

            /// <summary>
            /// <para>Subscription type. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Prepaid</description></item>
            /// <item><description><b>1</b>: Pay-As-You-Go</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public int? ChargeType { get; set; }

            /// <summary>
            /// <para>The name of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc**</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the folder in the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-cE2SQP****</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>Instance purchase type. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Self-purchased</description></item>
            /// <item><description><b>1</b>: Multi-account allocation</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstanceBuyType")]
            [Validation(Required=false)]
            public int? InstanceBuyType { get; set; }

            /// <summary>
            /// <para>Indicates whether the member is an administrator account of the resource directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b></description></item>
            /// <item><description><b>no</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsMaAccount")]
            [Validation(Required=false)]
            public string IsMaAccount { get; set; }

            /// <summary>
            /// <para>Indicates whether the member is marked as followed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsMarked")]
            [Validation(Required=false)]
            public string IsMarked { get; set; }

            /// <summary>
            /// <para>Indicates whether the member is a delegated administrator account of Security Center. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b></description></item>
            /// <item><description><b>no</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsSasDaAccount")]
            [Validation(Required=false)]
            public string IsSasDaAccount { get; set; }

            /// <summary>
            /// <para>Indicates whether the member is an account of the threat analysis and response feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b></description></item>
            /// <item><description><b>no</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsSiemControlAccount")]
            [Validation(Required=false)]
            public string IsSiemControlAccount { get; set; }

            /// <summary>
            /// <para>Indicates whether the member is a delegated administrator account of the threat analysis and response feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b></description></item>
            /// <item><description><b>no</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsSiemDaAccount")]
            [Validation(Required=false)]
            public string IsSiemDaAccount { get; set; }

            /// <summary>
            /// <para>Post-paid module switch. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Off</description></item>
            /// <item><description><b>1</b>: On</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PostBasicService")]
            [Validation(Required=false)]
            public int? PostBasicService { get; set; }

            /// <summary>
            /// <para>The switch status of the pay-as-you-go module. The value is a JSON string. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Key:</para>
            /// <list type="bullet">
            /// <item><description><b>VUL</b>: vulnerability fixing module</description></item>
            /// <item><description><b>CSPM</b>: cloud service configuration check module</description></item>
            /// <item><description><b>AGENTLESS</b>: agentless detection module</description></item>
            /// <item><description><b>SERVERLESS</b>: serverless asset module</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Value: A value of 0 specifies disabled. A value of 1 specifies enabled.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para> If you do not specify a value for a module, the original value of the module is retained.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;VUL\&quot;:0}</para>
            /// </summary>
            [NameInMap("PostPayModuleSwitch")]
            [Validation(Required=false)]
            public string PostPayModuleSwitch { get; set; }

            /// <summary>
            /// <para>Cloud Security Center Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>postpay-sas-x5x3hy1ly***</para>
            /// </summary>
            [NameInMap("SaleInstance")]
            [Validation(Required=false)]
            public string SaleInstance { get; set; }

            /// <summary>
            /// <para>The edition of Security Center that you use. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> or <b>1</b>: Basic</description></item>
            /// <item><description><b>2</b> or <b>3</b>: Enterprise</description></item>
            /// <item><description><b>5</b>: Advanced</description></item>
            /// <item><description><b>6</b>: Anti-virus</description></item>
            /// <item><description><b>7</b>: Ultimate</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SasVersion")]
            [Validation(Required=false)]
            public string SasVersion { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7A839E8-70AE-591D-8D9E-C5419A2240DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
