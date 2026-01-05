// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsAppIcpRecordResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QuerySmsAppIcpRecordResponseBodyData> Data { get; set; }
        public class QuerySmsAppIcpRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>审核通过日期，示例2025-09-01</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-01</para>
            /// </summary>
            [NameInMap("AppApprovalDate")]
            [Validation(Required=false)]
            public string AppApprovalDate { get; set; }

            /// <summary>
            /// <para>ICP备案/许可证号</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("AppIcpLicenseNumber")]
            [Validation(Required=false)]
            public string AppIcpLicenseNumber { get; set; }

            /// <summary>
            /// <para>app-icp备案材料id</para>
            /// 
            /// <b>Example:</b>
            /// <para>51</para>
            /// </summary>
            [NameInMap("AppIcpRecordId")]
            [Validation(Required=false)]
            public long? AppIcpRecordId { get; set; }

            /// <summary>
            /// <para>app-icp备案截图图片Osskey（给签名传工单用）</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000025<em><b><b>02/ac181696-</b></b>-49c6-90dc-50689267aa00_mhsjd8b8_17****</em>662348.jpeg</para>
            /// </summary>
            [NameInMap("AppIcpRecordPic")]
            [Validation(Required=false)]
            public string AppIcpRecordPic { get; set; }

            /// <summary>
            /// <para>app-icp备案截图url地址</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alicom-fc-media.oss-cn-zhangjiakou.aliyuncs.com/100000****50802/afde****-496d-46e4-899d-b43758****8_mhk9oz0p_176224****542.png?Expires=1762****6&OSSAccessKeyId=bypFN****73PsLI&Signature=BygI9X****h7%2FXmFIo****FB2c%3D">https://alicom-fc-media.oss-cn-zhangjiakou.aliyuncs.com/100000****50802/afde****-496d-46e4-899d-b43758****8_mhk9oz0p_176224****542.png?Expires=1762****6&amp;OSSAccessKeyId=bypFN****73PsLI&amp;Signature=BygI9X****h7%2FXmFIo****FB2c%3D</a></para>
            /// </summary>
            [NameInMap("AppIcpRecordPicUrl")]
            [Validation(Required=false)]
            public string AppIcpRecordPicUrl { get; set; }

            /// <summary>
            /// <para>主办单位名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("AppPrincipalUnitName")]
            [Validation(Required=false)]
            public string AppPrincipalUnitName { get; set; }

            /// <summary>
            /// <para>app服务名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("AppServiceName")]
            [Validation(Required=false)]
            public string AppServiceName { get; set; }

            /// <summary>
            /// <para>APP应用商店链接</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://test">https://test</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C9955E63-8BFF-101D-80A1-E6998DFEFF1A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
