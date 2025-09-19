// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudVendorAccountAKListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the AccessKey pairs.</para>
        /// </summary>
        [NameInMap("CloudVendorAccountAKs")]
        [Validation(Required=false)]
        public List<DescribeCloudVendorAccountAKListResponseBodyCloudVendorAccountAKs> CloudVendorAccountAKs { get; set; }
        public class DescribeCloudVendorAccountAKListResponseBodyCloudVendorAccountAKs : TeaModel {
            /// <summary>
            /// <para>The type of the account to which the AccessKey pair belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>primary</b>: a primary account</description></item>
            /// <item><description><b>sub</b>: a sub-account</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>primary</para>
            /// </summary>
            [NameInMap("AkType")]
            [Validation(Required=false)]
            public string AkType { get; set; }

            /// <summary>
            /// <para>The unique ID of the AccessKey pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2345</para>
            /// </summary>
            [NameInMap("AuthId")]
            [Validation(Required=false)]
            public long? AuthId { get; set; }

            /// <summary>
            /// <para>The modules that are associated with the AccessKey pair.</para>
            /// </summary>
            [NameInMap("AuthModules")]
            [Validation(Required=false)]
            public List<DescribeCloudVendorAccountAKListResponseBodyCloudVendorAccountAKsAuthModules> AuthModules { get; set; }
            public class DescribeCloudVendorAccountAKListResponseBodyCloudVendorAccountAKsAuthModules : TeaModel {
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
                /// <item><description><b>HOST</b>: host</description></item>
                /// <item><description><b>CSPM</b>: configuration assessment</description></item>
                /// <item><description><b>SIEM</b>: CloudSiem</description></item>
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
                /// <para>The cloud asset that is associated with the module.</para>
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
                /// <para>The service status of the module. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: being used</description></item>
                /// <item><description><b>1</b>: exception occurred</description></item>
                /// <item><description><b>2</b>: being validated</description></item>
                /// <item><description><b>3</b>: validation timed out</description></item>
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
                /// <para>Read permission of the cloud server or virtual machine</para>
                /// </summary>
                [NameInMap("ModuleStatement")]
                [Validation(Required=false)]
                public string ModuleStatement { get; set; }

                /// <summary>
                /// <para>The error message of the log audit service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>timeout</para>
                /// </summary>
                [NameInMap("TrailMessage")]
                [Validation(Required=false)]
                public string TrailMessage { get; set; }

                /// <summary>
                /// <para>The status of the log audit service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>init</b>: being initialized</description></item>
                /// <item><description><b>verify</b>: being validated</description></item>
                /// <item><description><b>enable</b>: enabled</description></item>
                /// <item><description><b>disable</b>: disabled</description></item>
                /// <item><description><b>error</b>: exception occurred</description></item>
                /// <item><description><b>timeout</b>: validation timed out</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("TrailStatus")]
                [Validation(Required=false)]
                public string TrailStatus { get; set; }

            }

            [NameInMap("CtdrCloudUserId")]
            [Validation(Required=false)]
            public string CtdrCloudUserId { get; set; }

            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para>S3D6c4O***</para>
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

            /// <summary>
            /// <para>The service status of the AccessKey pair. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: being used</description></item>
            /// <item><description><b>1</b>: exception occurred</description></item>
            /// <item><description><b>2</b>: being validated</description></item>
            /// <item><description><b>3</b>: validation timed out</description></item>
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
            /// <para>The cloud service provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Tencent</b>: Tencent Cloud</description></item>
            /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud</description></item>
            /// <item><description><b>Azure</b>: Microsoft Azure</description></item>
            /// <item><description><b>AWS</b>: Amazon Web Services (AWS)</description></item>
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
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VendorAuthAlias")]
            [Validation(Required=false)]
            public string VendorAuthAlias { get; set; }

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
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1383B0DB-D5D6-4B0C-9E6B-75939C8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
