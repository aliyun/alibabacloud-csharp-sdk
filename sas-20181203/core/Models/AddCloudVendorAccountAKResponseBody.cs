// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddCloudVendorAccountAKResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the added AK.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddCloudVendorAccountAKResponseBodyData Data { get; set; }
        public class AddCloudVendorAccountAKResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AK type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>primary</b>: Primary account.</description></item>
            /// <item><description><b>sub</b>: Sub-account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sub</para>
            /// </summary>
            [NameInMap("AkType")]
            [Validation(Required=false)]
            public string AkType { get; set; }

            /// <summary>
            /// <para>The unique ID of the AK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2158</para>
            /// </summary>
            [NameInMap("AuthId")]
            [Validation(Required=false)]
            public long? AuthId { get; set; }

            /// <summary>
            /// <para>The list of AK-associated modules.</para>
            /// </summary>
            [NameInMap("AuthModules")]
            [Validation(Required=false)]
            public List<AddCloudVendorAccountAKResponseBodyDataAuthModules> AuthModules { get; set; }
            public class AddCloudVendorAccountAKResponseBodyDataAuthModules : TeaModel {
                /// <summary>
                /// <para>The module exception information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ak_domain_error</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The module code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>HOST</b>: Host</description></item>
                /// <item><description><b>CSPM</b>: Cloud product configuration check</description></item>
                /// <item><description><b>SIEM</b>: CloudSiem</description></item>
                /// <item><description><b>TRIAL</b>: Log audit</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HOST</para>
                /// </summary>
                [NameInMap("Module")]
                [Validation(Required=false)]
                public string Module { get; set; }

                /// <summary>
                /// <para>The cloud asset description associated with the module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cloud server or virtual machine</para>
                /// </summary>
                [NameInMap("ModuleAssetType")]
                [Validation(Required=false)]
                public string ModuleAssetType { get; set; }

                /// <summary>
                /// <para>The display name of the module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Host Assets</para>
                /// </summary>
                [NameInMap("ModuleDisp")]
                [Validation(Required=false)]
                public string ModuleDisp { get; set; }

                /// <summary>
                /// <para>The module status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: In use.</description></item>
                /// <item><description><b>1</b>: Usage exception.</description></item>
                /// <item><description><b>2</b>: Validity verification in progress.</description></item>
                /// <item><description><b>3</b>: Validity verification timed out.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ModuleServiceStatus")]
                [Validation(Required=false)]
                public int? ModuleServiceStatus { get; set; }

                /// <summary>
                /// <para>The description of permissions associated with the module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Read permission of the cloud server or virtual machine</para>
                /// </summary>
                [NameInMap("ModuleStatement")]
                [Validation(Required=false)]
                public string ModuleStatement { get; set; }

            }

            /// <summary>
            /// <para>The account ID.</para>
            /// <remarks>
            /// <para>The account ID of the connected cloud vendor.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>azure_demo_1</para>
            /// </summary>
            [NameInMap("CtdrCloudUserId")]
            [Validation(Required=false)]
            public string CtdrCloudUserId { get; set; }

            /// <summary>
            /// <para>The AK exception information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The IAM user is forbidden in the currently selected region</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The AK parameter ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AE6SLd****</para>
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

            /// <summary>
            /// <para>The AK usage status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: In use.</description></item>
            /// <item><description><b>1</b>: Usage exception.</description></item>
            /// <item><description><b>2</b>: Validity verification in progress.</description></item>
            /// <item><description><b>3</b>: Validity verification timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public int? ServiceStatus { get; set; }

            /// <summary>
            /// <para>The AK status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Enabled.</description></item>
            /// <item><description><b>1</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The cloud asset vendor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Tencent</b>: Tencent Cloud</description></item>
            /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud</description></item>
            /// <item><description><b>Azure</b>: Azure</description></item>
            /// <item><description><b>AWS</b>: AWS</description></item>
            /// <item><description><b>VOLCENGINE</b>: Volcengine</description></item>
            /// <item><description><b>google</b>: Google Cloud</description></item>
            /// <item><description><b>CHAITIN</b>: Chaitin Technology</description></item>
            /// <item><description><b>FORTINET</b>: Fortinet</description></item>
            /// <item><description><b>THREATBOOK</b>: ThreatBook</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Tencent</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

            /// <summary>
            /// <para>The AK account name.</para>
            /// <remarks>
            /// <para>Used to identify the account to which third-party host assets belong.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VendorAuthAlias")]
            [Validation(Required=false)]
            public string VendorAuthAlias { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A60DA4EC-7CD8-577D-AD73-***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
