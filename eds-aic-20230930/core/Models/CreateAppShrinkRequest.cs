// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateAppShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application Name 1</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The information about the custom app.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you want to pass in a custom app, configure the <c>CustomAppInfo</c> parameter. Take note that the six fields within it are mandatory.</para>
        /// </description></item>
        /// <item><description><para>A custom app has a higher priority than an app from the Alibaba Cloud Workspace Application Center. If you configure the <c>CustomAppInfo</c> parameter, the <c>FileName</c> and <c>FilePath</c> pair or the <c>OssAppUrl</c> will not take effect.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("CustomAppInfo")]
        [Validation(Required=false)]
        public string CustomAppInfoShrink { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name used by the app file in Object Storage Service (OSS). This parameter, combined with <c>FilePath</c>, uniquely identifies the OSS path of the app file.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you want to pass in an app from the Alibaba Cloud Workspace Application Center, configure the <c>FileName</c> and <c>FilePath</c> parameters. Alternatively, configure the <c>OssAppUrl</c> parameter. The FileName and FilePath parameters takes precedence over the OssAppUrl parameter.</para>
        /// </description></item>
        /// <item><description><para>Log on to the <a href="https://eds.console.aliyun.com/osshelp">Elastic Desktop Service (EDS) Enterprise</a> console, upload the app file to the Application Center according to the on-screen instructions, and then retrieve the parameter value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testApp.apk</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The OSS bucket path to the app file. This parameter, combined with <c>FileName</c>, uniquely identifies the OSS path of the app file.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you want to pass in an app from the Alibaba Cloud Workspace Application Center, configure the <c>FileName</c> and <c>FilePath</c> parameters. Alternatively, configure the <c>OssAppUrl</c> parameter. The FileName and FilePath parameters takes precedence over the OssAppUrl parameter.</para>
        /// </description></item>
        /// <item><description><para>Log on to the <a href="https://eds.console.aliyun.com/osshelp">EDS Enterprise</a> console, upload the app file to the Application Center according to the on-screen instructions, and then retrieve the parameter value.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The icon URL of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com/icon.png">https://www.example.com/icon.png</a></para>
        /// </summary>
        [NameInMap("IconUrl")]
        [Validation(Required=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// <para>The parameters used for installing the application. By default, the <c>-r</c> parameter is included when you install an application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-d</para>
        /// </summary>
        [NameInMap("InstallParam")]
        [Validation(Required=false)]
        public string InstallParam { get; set; }

        /// <summary>
        /// <para>The OSS bucket endpoint of the app file.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you want to pass in an app from the Alibaba Cloud Workspace Application Center, configure the <c>FileName</c> and <c>FilePath</c> parameters. Alternatively, configure the <c>OssAppUrl</c> parameter. The FileName and FilePath parameters takes precedence over the OssAppUrl parameter.</para>
        /// </description></item>
        /// <item><description><para>Log on to the <a href="https://eds.console.aliyun.com/osshelp">EDS Enterprise</a> console, upload the app file to the Application Center according to the on-screen instructions, and then retrieve the parameter value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://testApp.apk">http://testApp.apk</a></para>
        /// </summary>
        [NameInMap("OssAppUrl")]
        [Validation(Required=false)]
        public string OssAppUrl { get; set; }

        [NameInMap("SignApk")]
        [Validation(Required=false)]
        public string SignApk { get; set; }

    }

}
