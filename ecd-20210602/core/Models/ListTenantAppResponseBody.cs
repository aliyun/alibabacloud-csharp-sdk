// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class ListTenantAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The business result code, returned as a string. The value is typically &quot;200&quot; when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of applications on the current page. Each element represents an application.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListTenantAppResponseBodyData> Data { get; set; }
        public class ListTenantAppResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An internal field. We do not recommend that you use this field.</para>
            /// </summary>
            [NameInMap("AdminTag")]
            [Validation(Required=false)]
            public List<string> AdminTag { get; set; }

            /// <summary>
            /// <para>An internal field. We do not recommend that you use this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Recommended</para>
            /// </summary>
            [NameInMap("AppAdminTag")]
            [Validation(Required=false)]
            public string AppAdminTag { get; set; }

            /// <summary>
            /// <para>The application registry identification information, returned as a string. This value can be used to match the name of an application registry entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleEditor</para>
            /// </summary>
            [NameInMap("AppRegInfo")]
            [Validation(Required=false)]
            public string AppRegInfo { get; set; }

            /// <summary>
            /// <para>An internal field. We do not recommend that you use this field.</para>
            /// </summary>
            [NameInMap("AppTag")]
            [Validation(Required=false)]
            public List<string> AppTag { get; set; }

            /// <summary>
            /// <para>The application UID string, which is a different identifier from the numeric Id field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-demo-001</para>
            /// </summary>
            [NameInMap("AppUid")]
            [Validation(Required=false)]
            public string AppUid { get; set; }

            /// <summary>
            /// <para>The authorization dimension of the application.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>auth_type_user: Authorized by user.</description></item>
            /// <item><description>auth_type_resource_group: Authorized by resource group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auth_type_user</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// </summary>
            [NameInMap("AutoDeleteFlag")]
            [Validation(Required=false)]
            public bool? AutoDeleteFlag { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// </summary>
            [NameInMap("AutoInstallFlag")]
            [Validation(Required=false)]
            public bool? AutoInstallFlag { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>SILENCE_INSTALL</para>
            /// </summary>
            [NameInMap("AutoInstallType")]
            [Validation(Required=false)]
            public string AutoInstallType { get; set; }

            /// <summary>
            /// <para>The new automatic installation scope policy. Use this field together with AuthType to determine the authorization dimension. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Automatically install for all visible users or resource groups.</description></item>
            /// <item><description>1: Automatically install for some visible users or resource groups.</description></item>
            /// <item><description>2: Disable automatic installation.</description></item>
            /// <item><description>99: Unknown policy.</description></item>
            /// </list>
            /// <para>This field describes the configuration scope and does not indicate that the installation has been completed on the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoInstallmentType")]
            [Validation(Required=false)]
            public int? AutoInstallmentType { get; set; }

            /// <summary>
            /// <para>The display category ID of the application. The category ID is a dynamic identifier and is not a fixed enumeration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public int? CateId { get; set; }

            /// <summary>
            /// <para>The display category name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office</para>
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster-demo-001</para>
            /// </summary>
            [NameInMap("ClusterUid")]
            [Validation(Required=false)]
            public string ClusterUid { get; set; }

            /// <summary>
            /// <para>The description of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Used for document editing</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the application developer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample Software Company</para>
            /// </summary>
            [NameInMap("Developer")]
            [Validation(Required=false)]
            public string Developer { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public double? DiscountPrice { get; set; }

            /// <summary>
            /// <para>The authorization distribution scope of the application. This field must be interpreted together with AuthType. An empty value does not necessarily mean that the application is not distributed.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL: Distributed to all.</description></item>
            /// <item><description>DESIGNATED: Distributed to a specified scope.</description></item>
            /// <item><description>NOTDISTRO: Not distributed.</description></item>
            /// <item><description>UNKNOWN: Unknown scope.</description></item>
            /// </list>
            /// <para>The distribution target is determined by AuthType.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("DistributeType")]
            [Validation(Required=false)]
            public string DistributeType { get; set; }

            /// <summary>
            /// <para>The authorization end time of the application. The value is returned as a string with a time zone, in the format of date, the letter T, hours-minutes-seconds, 3-digit milliseconds, and a time zone offset without colons. The +0000 in the example indicates UTC. This field may be empty or not returned if no value is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-07T00:00:00.000+0000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The extended information of the application, returned as a string. There is no unified fixed field structure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            /// <summary>
            /// <para>The storage file name of the installation package, which may differ from the original file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>editor_1.2.3.exe</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The storage path of the installation package. This value is not a directly accessible download URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>packages/example/editor.exe</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The original file name of the installation package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>editor.exe</para>
            /// </summary>
            [NameInMap("FileRealName")]
            [Validation(Required=false)]
            public string FileRealName { get; set; }

            /// <summary>
            /// <para>The creation time of the application record. The value is returned as a string with a time zone, in the format of date, the letter T, hours-minutes-seconds, 3-digit milliseconds, and a time zone offset without colons. The +0000 in the example indicates UTC. This field may be empty or not returned if no value is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-07T09:04:38.000+0000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time of the application record. The value is returned as a string with a time zone, in the format of date, the letter T, hours-minutes-seconds, 3-digit milliseconds, and a time zone offset without colons. The +0000 in the example indicates UTC. This field may be empty or not returned if no value is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-07T09:04:38.000+0000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// </summary>
            [NameInMap("HasCert")]
            [Validation(Required=false)]
            public bool? HasCert { get; set; }

            /// <summary>
            /// <para>The icon URL of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/icons/editor.png">https://example.com/icons/editor.png</a></para>
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <para>The internal network icon URL of the application. Use this URL only when the corresponding network access conditions are met. The domain name in the example is for illustrative purposes only.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/icons/editor.png">https://example.com/icons/editor.png</a></para>
            /// </summary>
            [NameInMap("IconUrlInternal")]
            [Validation(Required=false)]
            public string IconUrlInternal { get; set; }

            /// <summary>
            /// <para>The numeric ID of the application, used as the identity of the application and to associate what to do next.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// </summary>
            [NameInMap("Install")]
            [Validation(Required=false)]
            public bool? Install { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstallMode")]
            [Validation(Required=false)]
            public int? InstallMode { get; set; }

            /// <summary>
            /// <para>Specifies whether elevated privilege installation is configured. This does not indicate the administrator identity of the caller.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Elevated privilege installation is configured.</description></item>
            /// <item><description>false: Elevated privilege installation is not configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsAdmin")]
            [Validation(Required=false)]
            public bool? IsAdmin { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>TRUE</para>
            /// </summary>
            [NameInMap("IsFree")]
            [Validation(Required=false)]
            public string IsFree { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// </summary>
            [NameInMap("IsGame")]
            [Validation(Required=false)]
            public bool? IsGame { get; set; }

            /// <summary>
            /// <para>An internal field. We do not recommend that you use this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsWhiteList")]
            [Validation(Required=false)]
            public int? IsWhiteList { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>app-demo-001</para>
            /// </summary>
            [NameInMap("ItemCode")]
            [Validation(Required=false)]
            public string ItemCode { get; set; }

            /// <summary>
            /// <para>An internal field. We do not recommend that you use this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

            /// <summary>
            /// <para>An internal field. We do not recommend that you use this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MANUAL</para>
            /// </summary>
            [NameInMap("LicenseType")]
            [Validation(Required=false)]
            public string LicenseType { get; set; }

            /// <summary>
            /// <para>The English name of the management category of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office</para>
            /// </summary>
            [NameInMap("ManageCateEnName")]
            [Validation(Required=false)]
            public string ManageCateEnName { get; set; }

            /// <summary>
            /// <para>The management category ID of the application, which may differ from the display category CateId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ManageCateId")]
            [Validation(Required=false)]
            public int? ManageCateId { get; set; }

            /// <summary>
            /// <para>The management category name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office</para>
            /// </summary>
            [NameInMap("ManageCateName")]
            [Validation(Required=false)]
            public string ManageCateName { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleEditor</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The application type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ClientBase: Client-based application.</description></item>
            /// <item><description>WebBase: Web-based application.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ClientBase</para>
            /// </summary>
            [NameInMap("OriginAppType")]
            [Validation(Required=false)]
            public string OriginAppType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public double? OriginalPrice { get; set; }

            /// <summary>
            /// <para>The operating system type of the application.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>WINDOWS: Windows.</description></item>
            /// <item><description>LINUX: Linux.</description></item>
            /// <item><description>ANDROID: Android.</description></item>
            /// <item><description>UNKNOWN: Unknown operating system.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WINDOWS</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>WINDOWS</para>
            /// </summary>
            [NameInMap("OwnerOs")]
            [Validation(Required=false)]
            public string OwnerOs { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public int? PaymentType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public string Price { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The publish time of the application. The value is returned as a string with a time zone, in the format of date, the letter T, hours-minutes-seconds, 3-digit milliseconds, and a time zone offset without colons. The +0000 in the example indicates UTC. This field may be empty or not returned if no value is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-07T09:04:39.000+0000</para>
            /// </summary>
            [NameInMap("PublishDate")]
            [Validation(Required=false)]
            public string PublishDate { get; set; }

            /// <summary>
            /// <para>The customer scope of the application.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ENT: Enterprise.</description></item>
            /// <item><description>PER: Individual.</description></item>
            /// <item><description>BOTH: Enterprise and individual.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ENT</para>
            /// </summary>
            [NameInMap("PublishType")]
            [Validation(Required=false)]
            public string PublishType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SandboxMode")]
            [Validation(Required=false)]
            public int? SandboxMode { get; set; }

            /// <summary>
            /// <para>An internal field. We do not recommend that you use this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Edit Document</para>
            /// </summary>
            [NameInMap("SearchTag")]
            [Validation(Required=false)]
            public string SearchTag { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SilenceDeleteFlag")]
            [Validation(Required=false)]
            public int? SilenceDeleteFlag { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>/uninstall /quiet</para>
            /// </summary>
            [NameInMap("SilenceDeleteParam")]
            [Validation(Required=false)]
            public string SilenceDeleteParam { get; set; }

            /// <summary>
            /// <para>Indicates whether silent installtion is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Not supported.</description></item>
            /// <item><description>1: Supported.</description></item>
            /// </list>
            /// <para>This field indicates the application capability and does not represent the actual installation execute result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SilenceFlag")]
            [Validation(Required=false)]
            public int? SilenceFlag { get; set; }

            /// <summary>
            /// <para>The silent installtion parameters, used by the corresponding installation flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/quiet</para>
            /// </summary>
            [NameInMap("SilenceParam")]
            [Validation(Required=false)]
            public string SilenceParam { get; set; }

            /// <summary>
            /// <para>The size of the installation package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10485760</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The application source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MARKET: Alibaba Cloud Marketplace application.</description></item>
            /// <item><description>TENANT: Tenant-uploaded application.</description></item>
            /// <item><description>UNKNOWN: Unknown source.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TENANT</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The start time of the application authorization. The value is returned as a string with time zone information, in the format of date, the letter T, hours-minutes-seconds, 3-digit milliseconds, and a time zone offset without colons. The +0000 in the example indicates UTC. This field may be empty or not returned if no value is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-07T00:00:00.000+0000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The application status. This field does not represent the installation status on the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: Normal.</description></item>
            /// <item><description>DELETE: Deleted.</description></item>
            /// <item><description>UNCHECK: Not reviewed or not verified.</description></item>
            /// <item><description>DISABLE: All versions are unavailable.</description></item>
            /// <item><description>UNKNOWN: Unknown status.</description></item>
            /// </list>
            /// <para><b>The following historical statuses from the sandbox packaging and publishing process are deprecated. Do not use them: UNPACKED (not packaged), TESTING (packaged, pending testing), UNPUBLISHED (testing completed, not published), PUBLISHED (published).</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>sandbox</para>
            /// </summary>
            [NameInMap("SubAppType")]
            [Validation(Required=false)]
            public string SubAppType { get; set; }

            /// <summary>
            /// <para>The secondary source of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALI_MARKET: Alibaba Cloud Marketplace.</description></item>
            /// <item><description>ISV: Independent software vendor.</description></item>
            /// <item><description>OPS: Operations channel.</description></item>
            /// <item><description>UNKNOWN: Unknown source.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ISV</para>
            /// </summary>
            [NameInMap("SubSourceType")]
            [Validation(Required=false)]
            public string SubSourceType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SubscribeCount")]
            [Validation(Required=false)]
            public long? SubscribeCount { get; set; }

            /// <summary>
            /// <para>The account ID of the application supplier or uploader.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("SupplierId")]
            [Validation(Required=false)]
            public long? SupplierId { get; set; }

            /// <summary>
            /// <para>An internal field. We do not recommend that you use this field.</para>
            /// </summary>
            [NameInMap("UserTag")]
            [Validation(Required=false)]
            public List<string> UserTag { get; set; }

            /// <summary>
            /// <para>The application version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The display name of the application version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.3 Release</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>editor_1.2.3.wam</para>
            /// </summary>
            [NameInMap("WamFileName")]
            [Validation(Required=false)]
            public string WamFileName { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>packages/example/editor.wam</para>
            /// </summary>
            [NameInMap("WamFilePath")]
            [Validation(Required=false)]
            public string WamFilePath { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>editor.wam</para>
            /// </summary>
            [NameInMap("WamFileRealName")]
            [Validation(Required=false)]
            public string WamFileRealName { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("WamFileSize")]
            [Validation(Required=false)]
            public long? WamFileSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code field in the business response. This field may be empty. The actual transmission status is determined by the HTTP response status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The description of the request processing result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The actual page number of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The actual number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request tracking ID. Provide this value when reporting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111111-2222-4333-8444-555555555555</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was processed successfully. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Succeeded.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// <para>Refer to the corresponding field descriptions for specific business meanings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of applications that match the filter conditions. This value is not equal to the length of the array on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
