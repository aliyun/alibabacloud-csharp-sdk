// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCloudVendorAccountAKResponseBody : TeaModel {
        /// <summary>
        /// <para>The currently added authorization and authentication information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyCloudVendorAccountAKResponseBodyData Data { get; set; }
        public class ModifyCloudVendorAccountAKResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of the AK account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>primary</b>: primary account</description></item>
            /// <item><description><b>sub</b>: sub-account</description></item>
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
            /// <para>The list of information about the modules associated with the AK.</para>
            /// </summary>
            [NameInMap("AuthModules")]
            [Validation(Required=false)]
            public List<ModifyCloudVendorAccountAKResponseBodyDataAuthModules> AuthModules { get; set; }
            public class ModifyCloudVendorAccountAKResponseBodyDataAuthModules : TeaModel {
                /// <summary>
                /// <para>The exception information of the module.</para>
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
                /// <item><description><b>HOST</b>: host</description></item>
                /// <item><description><b>CSPM</b>: cloud product configuration check</description></item>
                /// <item><description><b>SIEM</b>: threat analysis and response</description></item>
                /// <item><description><b>TRIAL</b>: log audit</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HOST</para>
                /// </summary>
                [NameInMap("Module")]
                [Validation(Required=false)]
                public string Module { get; set; }

                /// <summary>
                /// <para>The description of the cloud assets associated with the module.</para>
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
                /// <para>The status of the module. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: in use</description></item>
                /// <item><description><b>1</b>: usage exception</description></item>
                /// <item><description><b>2</b>: validity verification in progress</description></item>
                /// <item><description><b>3</b>: validity verification timed out</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ModuleServiceStatus")]
                [Validation(Required=false)]
                public int? ModuleServiceStatus { get; set; }

                /// <summary>
                /// <para>The description of the associate permissions for the module.</para>
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
            /// <para>The exception information of the AK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The IAM user is forbidden in the currently selected region</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the AK parameter.</para>
            /// <remarks>
            /// <para>If AkType is set to <b>primary</b>, this value is the SecretID of the primary account of the third-party cloud. If AkType is set to <b>sub</b>, this value is the AccessKey ID of the sub-account of the third-party cloud. For <b>Azure</b>, no distinction is made, and this value is the <b>appId</b> of the authentication information.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>AE6SLd****</para>
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

            /// <summary>
            /// <para>The availability status of the AK. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: in use</description></item>
            /// <item><description><b>1</b>: usage exception</description></item>
            /// <item><description><b>2</b>: validity verification in progress</description></item>
            /// <item><description><b>3</b>: validity verification timed out</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public int? ServiceStatus { get; set; }

            /// <summary>
            /// <para>The usage status of the AK. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: enabled</description></item>
            /// <item><description><b>1</b>: disabled</description></item>
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
            /// <item><description><b>HUAWEICLOUD</b>: HUAWEI CLOUD</description></item>
            /// <item><description><b>Azure</b>: Azure</description></item>
            /// <item><description><b>AWS</b>: AWS</description></item>
            /// <item><description><b>VOLCENGINE</b>: Volcengine</description></item>
            /// <item><description><b>google</b>: Google Cloud</description></item>
            /// <item><description><b>CHAITIN</b>: Chaitin Technology</description></item>
            /// <item><description><b>FORTINET</b>: Fortinet</description></item>
            /// <item><description><b>THREATBOOK</b>: ThreatBook</description></item>
            /// <item><description><b>KingsoftCloud</b>: Kingsoft Cloud</description></item>
            /// <item><description><b>UCloud</b>: UCloud</description></item>
            /// <item><description><b>BaiduCloud</b>: Baidu AI Cloud</description></item>
            /// <item><description><b>WIZ</b>: Wiz</description></item>
            /// <item><description><b>OracleCloud</b>: Oracle Cloud</description></item>
            /// <item><description><b>StateCloud</b>: CTYun</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Tencent</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

            /// <summary>
            /// <para>The name of the AK account.</para>
            /// <remarks>
            /// <para>This parameter is used to identify the account information to which the third-party host assets belong.</para>
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
        /// <para>The ID of the request. This ID is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6635CED5-4B20-5D2D-94EC-A1C8F9C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
