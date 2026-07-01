// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateSmsAppIcpRecordRequest : TeaModel {
        /// <summary>
        /// <para>The ICP filing approval date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-22</para>
        /// </summary>
        [NameInMap("AppApprovalDate")]
        [Validation(Required=false)]
        public string AppApprovalDate { get; set; }

        /// <summary>
        /// <para>The ICP record/license number. The number must not exceed 15 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>浙B2-20080101</para>
        /// </summary>
        [NameInMap("AppIcpLicenseNumber")]
        [Validation(Required=false)]
        public string AppIcpLicenseNumber { get; set; }

        /// <summary>
        /// <para>The fileKey for the screenshot of your app\&quot;s ICP filing details.</para>
        /// <ol>
        /// <item><description><para>To look up your ICP filing, go to the <a href="https://beian.miit.gov.cn/#/Integrated/recordQuery">MIIT service platform</a>, search for your filing, and open its details page.</para>
        /// </description></item>
        /// <item><description><para>The ICP filing screenshot must be uploaded to OSS and meet the following requirements:</para>
        /// </description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description><para>The filename cannot contain Chinese characters or special characters.</para>
        /// </description></item>
        /// <item><description><para>The file must be an image in <c>jpg</c>, <c>png</c>, <c>gif</c>, or <c>jpeg</c> format. The file size cannot exceed 5 MB.</para>
        /// </description></item>
        /// <item><description><para>The screenshot must show the full URL.</para>
        /// </description></item>
        /// <item><description><para>For <b>Record Type</b>, select &quot;APP&quot;.</para>
        /// </description></item>
        /// <item><description><para>The <b>principal unit name</b> must be identical to the company or institution name on the qualification documents associated with the signature.</para>
        /// </description></item>
        /// <item><description><para>The screenshot must clearly show the complete ICP record/license number.</para>
        /// </description></item>
        /// <item><description><para>The <b>service name</b> must be identical to the <b>signature name</b>.</para>
        /// </description></item>
        /// </list>
        /// <ol start="3">
        /// <item><description>To obtain the fileKey, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files through OSS</a>.</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/test1719383196031.jpg</para>
        /// </summary>
        [NameInMap("AppIcpRecordPic")]
        [Validation(Required=false)]
        public string AppIcpRecordPic { get; set; }

        /// <summary>
        /// <para>The principal unit name from your ICP filing. The name must not exceed 50 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云计算有限公司</para>
        /// </summary>
        [NameInMap("AppPrincipalUnitName")]
        [Validation(Required=false)]
        public string AppPrincipalUnitName { get; set; }

        /// <summary>
        /// <para>APP实际运行截图osskey</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("AppRuntimePic")]
        [Validation(Required=false)]
        public string AppRuntimePic { get; set; }

        /// <summary>
        /// <para>The service name from your ICP filing. The name must not exceed 15 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("AppServiceName")]
        [Validation(Required=false)]
        public string AppServiceName { get; set; }

        /// <summary>
        /// <para>APP应用商店下载截图osskey</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("AppStoreDownloadPic")]
        [Validation(Required=false)]
        public string AppStoreDownloadPic { get; set; }

        /// <summary>
        /// <para>The app store link.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The link must start with <c>http://</c> or <c>https://</c>.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://apps.apple.com/cn/app/%E9%98%BF%E9%87%8C%E4%BA%91/id981011420">https://apps.apple.com/cn/app/阿里云/id981011420</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
