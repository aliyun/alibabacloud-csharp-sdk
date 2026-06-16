// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the application template.</para>
        /// </summary>
        [NameInMap("ApplicationTemplate")]
        [Validation(Required=false)]
        public GetApplicationTemplateResponseBodyApplicationTemplate ApplicationTemplate { get; set; }
        public class GetApplicationTemplateResponseBodyApplicationTemplate : TeaModel {
            /// <summary>
            /// <para>The ID of the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apt_ramintlrole_ixxxxx</para>
            /// </summary>
            [NameInMap("ApplicationTemplateId")]
            [Validation(Required=false)]
            public string ApplicationTemplateId { get; set; }

            /// <summary>
            /// <para>The name of the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud</para>
            /// </summary>
            [NameInMap("ApplicationTemplateName")]
            [Validation(Required=false)]
            public string ApplicationTemplateName { get; set; }

            /// <summary>
            /// <para>The time when the application template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1730341123000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud SSO</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The URL of the help document for the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/document_detail/409xxx.html">https://example.com/document_detail/409xxx.html</a></para>
            /// </summary>
            [NameInMap("HelpDocumentUrl")]
            [Validation(Required=false)]
            public string HelpDocumentUrl { get; set; }

            /// <summary>
            /// <para>The URL of the logo for the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/imgextra/i4/O1CN01xTLxLb1WtyKksHW1H_!!6000000002847-2-tps-xxx-xxx.png">https://example.com/imgextra/i4/O1CN01xTLxLb1WtyKksHW1H_!!6000000002847-2-tps-xxx-xxx.png</a></para>
            /// </summary>
            [NameInMap("LogoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            /// <summary>
            /// <para>The service code of the Alibaba Cloud service that manages the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bastionhost</para>
            /// </summary>
            [NameInMap("ManagedServiceCode")]
            [Validation(Required=false)]
            public string ManagedServiceCode { get; set; }

            /// <summary>
            /// <para>The sales information about the application template.</para>
            /// </summary>
            [NameInMap("SaleInfo")]
            [Validation(Required=false)]
            public GetApplicationTemplateResponseBodyApplicationTemplateSaleInfo SaleInfo { get; set; }
            public class GetApplicationTemplateResponseBodyApplicationTemplateSaleInfo : TeaModel {
                /// <summary>
                /// <para>Indicates whether the application template is permanently free.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AlwaysFree")]
                [Validation(Required=false)]
                public bool? AlwaysFree { get; set; }

            }

            /// <summary>
            /// <para>The URL of the console for the Alibaba Cloud service that manages the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/?p=bastion">https://example.com/?p=bastion</a></para>
            /// </summary>
            [NameInMap("ServiceConsoleUrl")]
            [Validation(Required=false)]
            public string ServiceConsoleUrl { get; set; }

            /// <summary>
            /// <para>Indicates whether the application template is managed by an Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>The supported Single Sign-On (SSO) protocols.</para>
            /// </summary>
            [NameInMap("SsoTypes")]
            [Validation(Required=false)]
            public List<string> SsoTypes { get; set; }

            /// <summary>
            /// <para>The time when the application template was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1730341124000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
