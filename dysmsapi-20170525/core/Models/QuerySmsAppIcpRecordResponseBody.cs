// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsAppIcpRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denial details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description><para>OK indicates a successful request.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see the <a href="https://help.aliyun.com/document_detail/101346.htm">error code list</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A list of APP-ICP record entity details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QuerySmsAppIcpRecordResponseBodyData> Data { get; set; }
        public class QuerySmsAppIcpRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The approval date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-01</para>
            /// </summary>
            [NameInMap("AppApprovalDate")]
            [Validation(Required=false)]
            public string AppApprovalDate { get; set; }

            /// <summary>
            /// <para>The icp filing/license number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("AppIcpLicenseNumber")]
            [Validation(Required=false)]
            public string AppIcpLicenseNumber { get; set; }

            /// <summary>
            /// <para>The ID of the APP-ICP record material.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51</para>
            /// </summary>
            [NameInMap("AppIcpRecordId")]
            [Validation(Required=false)]
            public long? AppIcpRecordId { get; set; }

            /// <summary>
            /// <para>The OSS fileKey for the APP-ICP record screenshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000025<em><b><b>02/ac181696-</b></b>-49c6-90dc-50689267aa00_mhsjd8b8_17****</em>662348.jpeg</para>
            /// </summary>
            [NameInMap("AppIcpRecordPic")]
            [Validation(Required=false)]
            public string AppIcpRecordPic { get; set; }

            /// <summary>
            /// <para>The URL of the APP-ICP record screenshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alicom-fc-media.oss-cn-zhangjiakou.aliyuncs.com/100000****50802/afde****-496d-46e4-899d-b43758****8_mhk9oz0p_176224****542.png?Expires=1762****6&OSSAccessKeyId=bypFN****73PsLI&Signature=BygI9X****h7%2FXmFIo****FB2c%3D">https://alicom-fc-media.oss-cn-zhangjiakou.aliyuncs.com/100000****50802/afde****-496d-46e4-899d-b43758****8_mhk9oz0p_176224****542.png?Expires=1762****6&amp;OSSAccessKeyId=bypFN****73PsLI&amp;Signature=BygI9X****h7%2FXmFIo****FB2c%3D</a></para>
            /// </summary>
            [NameInMap("AppIcpRecordPicUrl")]
            [Validation(Required=false)]
            public string AppIcpRecordPicUrl { get; set; }

            /// <summary>
            /// <para>The hosting unit name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云</para>
            /// </summary>
            [NameInMap("AppPrincipalUnitName")]
            [Validation(Required=false)]
            public string AppPrincipalUnitName { get; set; }

            /// <summary>
            /// <para>APP实际运行截图Osskey</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("AppRuntimePic")]
            [Validation(Required=false)]
            public string AppRuntimePic { get; set; }

            /// <summary>
            /// <para>APP实际运行截图url地址</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("AppRuntimePicUrl")]
            [Validation(Required=false)]
            public string AppRuntimePicUrl { get; set; }

            /// <summary>
            /// <para>The app service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("AppServiceName")]
            [Validation(Required=false)]
            public string AppServiceName { get; set; }

            /// <summary>
            /// <para>APP应用商店下载截图Osskey</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("AppStoreDownloadPic")]
            [Validation(Required=false)]
            public string AppStoreDownloadPic { get; set; }

            /// <summary>
            /// <para>APP应用商店下载截图url地址</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("AppStoreDownloadPicUrl")]
            [Validation(Required=false)]
            public string AppStoreDownloadPicUrl { get; set; }

            /// <summary>
            /// <para>The app store link.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://apps.apple.com/cn/app/%E9%98%BF%E9%87%8C%E4%BA%91/id981011420">https://apps.apple.com/cn/app/阿里云/id981011420</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C9955E63-8BFF-101D-80A1-E6998DFEFF1A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
