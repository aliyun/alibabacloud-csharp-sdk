// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateAppRequest : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application name 1</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The custom application information.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you pass a custom application, pass the <c>CustomAppInfo</c> parameter. All six fields in this object parameter are required.</para>
        /// </description></item>
        /// <item><description><para>Custom applications have a higher priority than applications from the WUYING Workspace app center. If you pass the <c>CustomAppInfo</c> parameter, <c>FileName</c> and <c>FilePath</c>, or <c>OssAppUrl</c> will be invalid.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("CustomAppInfo")]
        [Validation(Required=false)]
        public CreateAppRequestCustomAppInfo CustomAppInfo { get; set; }
        public class CreateAppRequestCustomAppInfo : TeaModel {
            /// <summary>
            /// <para>The size of the .apk file. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ApkSize")]
            [Validation(Required=false)]
            public string ApkSize { get; set; }

            /// <summary>
            /// <para>The download URL of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://testApp.apk">http://testApp.apk</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The MD5 value of the .apk package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>df3f46ce5844ddb278f14c5a9cd2****</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The application package name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.example.demo</para>
            /// </summary>
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            /// <summary>
            /// <para>The application version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The application version code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("VersionCode")]
            [Validation(Required=false)]
            public string VersionCode { get; set; }

        }

        /// <summary>
        /// <para>The application description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the application file stored in Object Storage Service (OSS). This parameter and <c>FilePath</c> together determine the unique OSS address.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you pass an application from the WUYING Workspace app center, you must pass <c>FileName</c> and <c>FilePath</c>, or <c>OssAppUrl</c>. The former takes precedence.</para>
        /// </description></item>
        /// <item><description><para>Log on to the <a href="https://eds.console.aliyun.com/osshelp">WUYING Workspace console</a>. Follow the on-screen instructions to upload your application file to the WUYING Workspace app center to obtain this parameter.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testApp.apk</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The storage address of the application file in an OSS bucket. This parameter and <c>FileName</c> together determine the unique OSS address.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you pass an application from the WUYING Workspace app center, you must pass <c>FileName</c> and <c>FilePath</c>, or <c>OssAppUrl</c>. The former takes precedence.</para>
        /// </description></item>
        /// <item><description><para>Log on to the <a href="https://eds.console.aliyun.com/osshelp">WUYING Workspace console</a>. Follow the on-screen instructions to upload your application file to the WUYING Workspace app center to obtain this parameter.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The URL of the application icon.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com/icon.png">https://www.example.com/icon.png</a></para>
        /// </summary>
        [NameInMap("IconUrl")]
        [Validation(Required=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// <para>The installation parameters. The <c>-r</c> installation parameter is included by default when you install the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-d</para>
        /// </summary>
        [NameInMap("InstallParam")]
        [Validation(Required=false)]
        public string InstallParam { get; set; }

        /// <summary>
        /// <para>The OSS address of the application.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you pass an application from the WUYING Workspace app center, you must pass <c>FileName</c> and <c>FilePath</c>, or <c>OssAppUrl</c>. The former takes precedence.</para>
        /// </description></item>
        /// <item><description><para>Log on to the <a href="https://eds.console.aliyun.com/osshelp">WUYING Workspace console</a>. Follow the on-screen instructions to upload your application file to the WUYING Workspace app center to obtain this parameter.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://testApp.apk">http://testApp.apk</a></para>
        /// </summary>
        [NameInMap("OssAppUrl")]
        [Validation(Required=false)]
        public string OssAppUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a system signature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SignApk")]
        [Validation(Required=false)]
        public string SignApk { get; set; }

    }

}
