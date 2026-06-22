// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAccountsInResourceDirectoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of member accounts in the resource directory.</para>
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
            /// <para>This parameter is deprecated and does not need to be used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BuySas")]
            [Validation(Required=false)]
            [Obsolete]
            public int? BuySas { get; set; }

            /// <summary>
            /// <para>Indicates whether a Security Center subscription instance is purchased. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BuySasNew")]
            [Validation(Required=false)]
            public bool? BuySasNew { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: upfront</description></item>
            /// <item><description><b>1</b>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public int? ChargeType { get; set; }

            /// <summary>
            /// <para>The account name.</para>
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
            /// <para>The instance purchase type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: self-purchased</description></item>
            /// <item><description><b>1</b>: allocated through multi-account management.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstanceBuyType")]
            [Validation(Required=false)]
            public int? InstanceBuyType { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is the management account of the resource directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>yes</b></para>
            /// </description></item>
            /// <item><description><para><b>no</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsMaAccount")]
            [Validation(Required=false)]
            public string IsMaAccount { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is marked as followed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsMarked")]
            [Validation(Required=false)]
            public string IsMarked { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is a delegated administrator account of Security Center. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>yes</b></para>
            /// </description></item>
            /// <item><description><para><b>no</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsSasDaAccount")]
            [Validation(Required=false)]
            public string IsSasDaAccount { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is a management account of Cloud Threat Detection and Response (CTDR). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>yes</b></para>
            /// </description></item>
            /// <item><description><para><b>no</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsSiemControlAccount")]
            [Validation(Required=false)]
            public string IsSiemControlAccount { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is a delegated administrator account of Cloud Threat Detection and Response (CTDR). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>yes</b></para>
            /// </description></item>
            /// <item><description><para><b>no</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsSiemDaAccount")]
            [Validation(Required=false)]
            public string IsSiemDaAccount { get; set; }

            /// <summary>
            /// <para>The pay-as-you-go module switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PostBasicService")]
            [Validation(Required=false)]
            public int? PostBasicService { get; set; }

            /// <summary>
            /// <para>The status of pay-as-you-go module switches, in JsonString format. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Key:<list type="bullet">
            /// <item><description><b>VUL</b>: vulnerability management module</description></item>
            /// <item><description><b>CSPM</b>: Cloud Security Posture Management (CSPM) module</description></item>
            /// <item><description><b>AGENTLESS</b>: agentless detection module</description></item>
            /// <item><description><b>SERVERLESS</b>: serverless asset module</description></item>
            /// <item><description><b>CTDR</b>: Cloud Threat Detection and Response (CTDR) module</description></item>
            /// <item><description><b>RASP</b>: Runtime Application Self-Protection (RASP) module</description></item>
            /// <item><description><b>SDK</b>: malicious file detection SDK module</description></item>
            /// <item><description><b>POST_HOST</b>: host and container security module</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>Value: 0 indicates disabled. 1 indicates enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;VUL\&quot;:0}</para>
            /// </summary>
            [NameInMap("PostPayModuleSwitch")]
            [Validation(Required=false)]
            public string PostPayModuleSwitch { get; set; }

            /// <summary>
            /// <para>The Security Center instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>postpay-sas-x5x3hy1ly***</para>
            /// </summary>
            [NameInMap("SaleInstance")]
            [Validation(Required=false)]
            public string SaleInstance { get; set; }

            /// <summary>
            /// <para>The purchased edition of Security Center. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> or <b>1</b>: Free Edition</description></item>
            /// <item><description><b>2</b> or <b>3</b>: Enterprise Edition  </description></item>
            /// <item><description><b>5</b>: Premium Edition  </description></item>
            /// <item><description><b>6</b>: Anti-virus Edition </description></item>
            /// <item><description><b>7</b>: Ultimate Edition.</description></item>
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
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7A839E8-70AE-591D-8D9E-C5419A2240DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
