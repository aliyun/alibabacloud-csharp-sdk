// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateAndBindAppRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the application icon. Specify an accessible icon URL when a custom icon needs to be displayed.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/apps/business/icon.png">https://example.com/apps/business/icon.png</a></para>
        /// </summary>
        [NameInMap("AppIconUrl")]
        [Validation(Required=false)]
        public string AppIconUrl { get; set; }

        /// <summary>
        /// <para>The name of the application to be created, which is used to identify the application in the image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business management platform</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The ID of the image to which the application is bound. The image must be a custom image or community image manageable by the current account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-bp1example****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The application form. If omitted, the default value is CLIENT_BASE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_BASE</b>: Client application.</description></item>
        /// <item><description><b>WEB_BASE</b>: Browser application.</description></item>
        /// <item><description><b>CLOUD_NATIVE_BASE</b>: Cloud-native application.</description></item>
        /// <item><description><b>PORT_SERVICE_BASE</b>: Port service application.</description></item>
        /// <item><description><b>AGENT_SERVICE_BASE</b>: Agent application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PORT_SERVICE_BASE</para>
        /// </summary>
        [NameInMap("OriginAppType")]
        [Validation(Required=false)]
        public string OriginAppType { get; set; }

        /// <summary>
        /// <para>The service port of the application. For applications that require port-based access, specify the actual port number that the application listens on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The path suffix of the application access URL, which together with the application service port describes the access endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/console</para>
        /// </summary>
        [NameInMap("UrlSuffix")]
        [Validation(Required=false)]
        public string UrlSuffix { get; set; }

        /// <summary>
        /// <para>The ID of the image version to which the application is bound. If omitted, the current active version of the image corresponding to ImageId is used. If specified, it must belong to the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iv-bp1example****</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
