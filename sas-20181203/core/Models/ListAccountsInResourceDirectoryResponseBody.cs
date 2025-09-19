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
            [NameInMap("BuySas")]
            [Validation(Required=false)]
            [Obsolete]
            public int? BuySas { get; set; }

            [NameInMap("BuySasNew")]
            [Validation(Required=false)]
            public bool? BuySasNew { get; set; }

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

            [NameInMap("PostPayModuleSwitch")]
            [Validation(Required=false)]
            public string PostPayModuleSwitch { get; set; }

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
