// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UploadCloudAppRequest : TeaModel {
        /// <summary>
        /// <para>The application name. For Android applications, use the package name, such as com.aaa.bbb.</para>
        /// <para>Value rules:</para>
        /// <ol>
        /// <item><description>Length: 4 to 50 characters.</description></item>
        /// <item><description>Lowercase letters, digits, underscores (_), hyphens (-), and periods (.).</description></item>
        /// <item><description>The first and last characters must be letters or digits.</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aaa.bbb</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The application version. For Android applications, use the VersionName, such as 1.1.1.</para>
        /// <para>Value rules:</para>
        /// <ol>
        /// <item><description>Length: 1 to 50 characters.</description></item>
        /// <item><description>Lowercase letters, digits, underscores (_), hyphens (-), and periods (.).</description></item>
        /// <item><description>The first and last characters must be letters or digits.</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test application package</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The download URL of the application package.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx.xxx.xxx.apk">https://xxx.xxx.xxx.apk</a></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The MD5 checksum of the application package, used to verify package integrity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CFBB7BD10CDD7279642ADAB8FEF3DEE</para>
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// <para>The package format. The default value is the file extension of the download URL. Valid values:</para>
        /// <ol>
        /// <item><description>apk</description></item>
        /// <item><description>tar.gz</description></item>
        /// <item><description>tar</description></item>
        /// <item><description>zip</description></item>
        /// <item><description>rar</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>apk</para>
        /// </summary>
        [NameInMap("PkgFormat")]
        [Validation(Required=false)]
        public string PkgFormat { get; set; }

        /// <summary>
        /// <para>The cloud application labels. You can select multiple values. Valid values:</para>
        /// <ol>
        /// <item><description>hot</description></item>
        /// <item><description>game</description></item>
        /// <item><description>app</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("PkgLabels")]
        [Validation(Required=false)]
        public List<string> PkgLabels { get; set; }

        /// <summary>
        /// <para>The package type.</para>
        /// <h2>Valid values:</h2>
        /// <ol>
        /// <item><description>android</description></item>
        /// <item><description>win</description></item>
        /// <item><description>android_appmarket: corresponds to the Android app marketplace scenario. In this scenario, the actual APK PackageName is restricted:
        /// a. Different AppName values cannot share the same PackageName.
        /// b. The same AppName with different AppVersion values can be associated with different PackageName values.</description></item>
        /// </ol>
        /// <h2>Default value:</h2>
        /// <para>If not specified, the package type is automatically mapped based on PkgFormat (or the file extension of DownloadUrl). Default mappings between PkgFormat and package type:</para>
        /// <ol>
        /// <item><description>android: apk (the apk format is mapped to android by default).</description></item>
        /// <item><description>win: tar.gz, tar, zip, rar.</description></item>
        /// <item><description>android_appmarket: apk.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>android</para>
        /// </summary>
        [NameInMap("PkgType")]
        [Validation(Required=false)]
        public string PkgType { get; set; }

        /// <summary>
        /// <para>The relative path of the post-installation command within the application package. Only supported for win type applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>install.ps1</para>
        /// </summary>
        [NameInMap("PostCommandPath")]
        [Validation(Required=false)]
        public string PostCommandPath { get; set; }

        /// <summary>
        /// <para>The timeout period (in seconds) for the post-installation command. Only supported for win type applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PostCommandTimeoutSec")]
        [Validation(Required=false)]
        public int? PostCommandTimeoutSec { get; set; }

    }

}
