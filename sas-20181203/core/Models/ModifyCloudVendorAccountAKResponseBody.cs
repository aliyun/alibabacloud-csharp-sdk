// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCloudVendorAccountAKResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the AccessKey pair that is added.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyCloudVendorAccountAKResponseBodyData Data { get; set; }
        public class ModifyCloudVendorAccountAKResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of the account to which the AccessKey pair belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>primary</b></description></item>
            /// <item><description><b>sub</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sub</para>
            /// </summary>
            [NameInMap("AkType")]
            [Validation(Required=false)]
            public string AkType { get; set; }

            /// <summary>
            /// <para>The unique ID of the AccessKey pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2158</para>
            /// </summary>
            [NameInMap("AuthId")]
            [Validation(Required=false)]
            public long? AuthId { get; set; }

            /// <summary>
            /// <para>The modules that are associated with the AccessKey pair.</para>
            /// </summary>
            [NameInMap("AuthModules")]
            [Validation(Required=false)]
            public List<ModifyCloudVendorAccountAKResponseBodyDataAuthModules> AuthModules { get; set; }
            public class ModifyCloudVendorAccountAKResponseBodyDataAuthModules : TeaModel {
                /// <summary>
                /// <para>The error message of the module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ak_domain_error</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The code of the module. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>HOST</b>: host.</description></item>
                /// <item><description><b>CSPM</b>: configuration assessment.</description></item>
                /// <item><description><b>SIEM</b>: CTDR.</description></item>
                /// <item><description><b>TRIAL</b>: log audit.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HOST</para>
                /// </summary>
                [NameInMap("Module")]
                [Validation(Required=false)]
                public string Module { get; set; }

                /// <summary>
                /// <para>The type of the cloud asset that is associated with the module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Module.</para>
                /// </summary>
                [NameInMap("ModuleAssetType")]
                [Validation(Required=false)]
                public string ModuleAssetType { get; set; }

                /// <summary>
                /// <para>The display name of the module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Host</para>
                /// </summary>
                [NameInMap("ModuleDisp")]
                [Validation(Required=false)]
                public string ModuleDisp { get; set; }

                /// <summary>
                /// <para>The service status of the module. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: being used.</description></item>
                /// <item><description><b>1</b>: exception occurred.</description></item>
                /// <item><description><b>2</b>: being validated.</description></item>
                /// <item><description><b>3</b>: validation timed out.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ModuleServiceStatus")]
                [Validation(Required=false)]
                public int? ModuleServiceStatus { get; set; }

                /// <summary>
                /// <para>The permission description of the module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Host</para>
                /// </summary>
                [NameInMap("ModuleStatement")]
                [Validation(Required=false)]
                public string ModuleStatement { get; set; }

            }

            /// <summary>
            /// <para>Account ID. </para>
            /// <remarks>
            /// <para>The account ID of the cloud provider being connected.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>azure_demo_1</para>
            /// </summary>
            [NameInMap("CtdrCloudUserId")]
            [Validation(Required=false)]
            public string CtdrCloudUserId { get; set; }

            /// <summary>
            /// <para>The error message of the AccessKey pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The IAM user is forbidden in the currently selected region</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The AccessKey ID.</para>
            /// <remarks>
            /// <para> If AkType is set to <b>primary</b>, the value of SecretId is AccessKey ID of the third-party master account. If AkType is set to <b>sub</b>, the value of SecretId is the AccessKey ID of the third-party sub-account. This parameter value does not change for a <b>Microsoft Azure account</b>. For an Azure account, this parameter value is the <b>app ID</b> that is used for authentication.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>AE6SLd****</para>
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

            /// <summary>
            /// <para>The service status of the AccessKey pair. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: being used.</description></item>
            /// <item><description><b>1</b>: exception occurred.</description></item>
            /// <item><description><b>2</b>: being validated.</description></item>
            /// <item><description><b>3</b>: validation timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public int? ServiceStatus { get; set; }

            /// <summary>
            /// <para>The status of the AccessKey pair. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: enabled.</description></item>
            /// <item><description><b>1</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The type of the cloud asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Tencent</b>: Tencent Cloud.</description></item>
            /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud.</description></item>
            /// <item><description><b>Azure</b>: Microsoft Azure.</description></item>
            /// <item><description><b>AWS</b>: Amazon Web Services (AWS).</description></item>
            /// <item><description><b>VOLCENGINE</b>: Volcengine </description></item>
            /// <item><description><b>google</b>: Google Cloud </description></item>
            /// <item><description><b>CHAITIN</b>: Chaitin Tech </description></item>
            /// <item><description><b>FORTINET</b>: Fortinet </description></item>
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
            /// <para>The name of the AccessKey pair.</para>
            /// <remarks>
            /// <para> The account information of the third-party cloud servers.</para>
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
        /// <para>6635CED5-4B20-5D2D-94EC-A1C8F9C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
