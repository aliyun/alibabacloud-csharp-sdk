// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudVendorAccountAKListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of AK information.</para>
        /// </summary>
        [NameInMap("CloudVendorAccountAKs")]
        [Validation(Required=false)]
        public List<DescribeCloudVendorAccountAKListResponseBodyCloudVendorAccountAKs> CloudVendorAccountAKs { get; set; }
        public class DescribeCloudVendorAccountAKListResponseBodyCloudVendorAccountAKs : TeaModel {
            /// <summary>
            /// <para>The type of the AK. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>primary</b>: Primary account.</description></item>
            /// <item><description><b>sub</b>: Sub-account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>primary</para>
            /// </summary>
            [NameInMap("AkType")]
            [Validation(Required=false)]
            public string AkType { get; set; }

            /// <summary>
            /// <para>The unique ID of the AK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2345</para>
            /// </summary>
            [NameInMap("AuthId")]
            [Validation(Required=false)]
            public long? AuthId { get; set; }

            /// <summary>
            /// <para>The list of modules associated with the AK.</para>
            /// </summary>
            [NameInMap("AuthModules")]
            [Validation(Required=false)]
            public List<DescribeCloudVendorAccountAKListResponseBodyCloudVendorAccountAKsAuthModules> AuthModules { get; set; }
            public class DescribeCloudVendorAccountAKListResponseBodyCloudVendorAccountAKsAuthModules : TeaModel {
                /// <summary>
                /// <para>The exception message of the module.</para>
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
                /// <item><description><b>HOST</b>: Host.</description></item>
                /// <item><description><b>CSPM</b>: Cloud product configuration check.</description></item>
                /// <item><description><b>SIEM</b>: Cloud SIEM.</description></item>
                /// <item><description><b>TRIAL</b>: Log audit.</description></item>
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
                /// <item><description><b>0</b>: In use.</description></item>
                /// <item><description><b>1</b>: Abnormal.</description></item>
                /// <item><description><b>2</b>: Validating.</description></item>
                /// <item><description><b>3</b>: Validation timed out.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ModuleServiceStatus")]
                [Validation(Required=false)]
                public int? ModuleServiceStatus { get; set; }

                /// <summary>
                /// <para>The description of the permissions associated with the module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Read permission of the cloud server or virtual machine</para>
                /// </summary>
                [NameInMap("ModuleStatement")]
                [Validation(Required=false)]
                public string ModuleStatement { get; set; }

                /// <summary>
                /// <para>The error message for log audit access.</para>
                /// 
                /// <b>Example:</b>
                /// <para>timeout</para>
                /// </summary>
                [NameInMap("TrailMessage")]
                [Validation(Required=false)]
                public string TrailMessage { get; set; }

                /// <summary>
                /// <para>The accessed state of log audit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>init</b>: Initialization.</description></item>
                /// <item><description><b>verify</b>: Authenticate.</description></item>
                /// <item><description><b>enable</b>: Enabled.</description></item>
                /// <item><description><b>disable</b>: Disabled.</description></item>
                /// <item><description><b>error</b>: Error.</description></item>
                /// <item><description><b>timeout</b>: Timed out.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("TrailStatus")]
                [Validation(Required=false)]
                public string TrailStatus { get; set; }

            }

            /// <summary>
            /// <para>The account ID.</para>
            /// <remarks>
            /// <para>The account ID of the connected cloud service provider.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>azure_demo_1</para>
            /// </summary>
            [NameInMap("CtdrCloudUserId")]
            [Validation(Required=false)]
            public string CtdrCloudUserId { get; set; }

            /// <summary>
            /// <para>The extended information.</para>
            /// <remarks>
            /// <para>Used to record the extended information of different vendors.
            /// Google Cloud is connected through a service account. ExtendInfo stores the service key file in JSON format, excluding the private_key_id and zprivate_key fields. The file contains the following fields: type, project_id, client_email, client_id, auth_uri, token_uri, auth_provider_x509_cert_url, client_x509_cert_url, and universe_domain. When the vendor is <b>OracleCloud</b>, this parameter contains the following keys: <b>fingerprint</b>, which indicates the fingerprint; <b>tenancy</b>, which indicates the tenant; and <b>domain</b>, which indicates the region to which the connected account belongs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;domain&quot;:&quot;global&quot;,&quot;fingerprint&quot;:&quot;c0:f4:******&quot;,&quot;tenancy&quot;:&quot;ocid1.tenancy.*****&quot;}</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// <para>The exception message of the AK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The IAM user is forbidden in the currently selected region</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the AK parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S3D6c4O***</para>
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

            /// <summary>
            /// <para>The usage status of the AK. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: In use.</description></item>
            /// <item><description><b>1</b>: Abnormal.</description></item>
            /// <item><description><b>2</b>: Validating.</description></item>
            /// <item><description><b>3</b>: Validation timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public int? ServiceStatus { get; set; }

            /// <summary>
            /// <para>The status of the AK. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Enabled.</description></item>
            /// <item><description><b>1</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The cloud service provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Tencent</b>: Tencent Cloud.</description></item>
            /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud.</description></item>
            /// <item><description><b>Azure</b>: Azure.</description></item>
            /// <item><description><b>AWS</b>: AWS.</description></item>
            /// <item><description><b>VOLCENGINE</b>: Volcengine.</description></item>
            /// <item><description><b>google</b>: Google Cloud.</description></item>
            /// <item><description><b>CHAITIN</b>: Chaitin Tech.</description></item>
            /// <item><description><b>FORTINET</b>: Fortinet.</description></item>
            /// <item><description><b>THREATBOOK</b>: ThreatBook.</description></item>
            /// <item><description><b>KingsoftCloud</b>: Kingsoft Cloud.</description></item>
            /// <item><description><b>UCloud</b>: UCloud.</description></item>
            /// <item><description><b>BaiduCloud</b>: Baidu AI Cloud.</description></item>
            /// <item><description><b>WIZ</b>: Wiz.</description></item>
            /// <item><description><b>OracleCloud</b>: Oracle Cloud.</description></item>
            /// <item><description><b>StateCloud</b>: CTYun.</description></item>
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
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VendorAuthAlias")]
            [Validation(Required=false)]
            public string VendorAuthAlias { get; set; }

            /// <summary>
            /// <para>The account ID of the multi-cloud instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("VendorUid")]
            [Validation(Required=false)]
            public string VendorUid { get; set; }

            /// <summary>
            /// <para>The account name of the multi-cloud instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VendorUserName")]
            [Validation(Required=false)]
            public string VendorUserName { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeCloudVendorAccountAKListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeCloudVendorAccountAKListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page during paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries returned per page during paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier generated by Alibaba Cloud for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1383B0DB-D5D6-4B0C-9E6B-75939C8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
