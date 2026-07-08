// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UploadCloudAppRequest : TeaModel {
        /// <summary>
        /// <para>The application name. For Android apps, use the package name, such as com.aaa.bbb.</para>
        /// <para>Value requirements:</para>
        /// <ol>
        /// <item><description><para>Length: 4–50 characters</para>
        /// </description></item>
        /// <item><description><para>Allowed characters: lowercase letters, digits, underscores (_), hyphens (-), and dots (.)</para>
        /// </description></item>
        /// <item><description><para>The first and last characters must be a letter or digit</para>
        /// </description></item>
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
        /// <para>Value requirements:</para>
        /// <ol>
        /// <item><description><para>Length: 1–50 characters</para>
        /// </description></item>
        /// <item><description><para>Allowed characters: lowercase letters, digits, underscores (_), hyphens (-), and dots (.)</para>
        /// </description></item>
        /// <item><description><para>The first and last characters must be a letter or digit</para>
        /// </description></item>
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
        /// <para>A description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试应用包</para>
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
        /// <para>The MD5 hash of the application package, used to verify package integrity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CFBB7BD10CDD7279642ADAB8FEF3DEE</para>
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// <para>The package format. By default, this is inferred from the file extension in the DownloadUrl. Valid values:</para>
        /// <ol>
        /// <item><description><para>apk</para>
        /// </description></item>
        /// <item><description><para>tar.gz</para>
        /// </description></item>
        /// <item><description><para>tar</para>
        /// </description></item>
        /// <item><description><para>zip</para>
        /// </description></item>
        /// <item><description><para>rar</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>apk</para>
        /// </summary>
        [NameInMap("PkgFormat")]
        [Validation(Required=false)]
        public string PkgFormat { get; set; }

        /// <summary>
        /// <para>Cloud application labels. You can select multiple. Valid values:</para>
        /// <ol>
        /// <item><description><para>hot</para>
        /// </description></item>
        /// <item><description><para>game</para>
        /// </description></item>
        /// <item><description><para>app</para>
        /// </description></item>
        /// </ol>
        /// </summary>
        [NameInMap("PkgLabels")]
        [Validation(Required=false)]
        public List<string> PkgLabels { get; set; }

        /// <summary>
        /// <para>The package type.</para>
        /// <h2>Valid values:</h2>
        /// <ol>
        /// <item><description><para>android</para>
        /// </description></item>
        /// <item><description><para>win</para>
        /// </description></item>
        /// <item><description><para>android_appmarket: for Android app marketplace scenarios. This scenario enforces real APK PackageName restrictions:
        /// a. PackageNames must be unique across different AppNames.
        /// b. The same AppName with different AppVersions can map to different PackageNames.</para>
        /// </description></item>
        /// </ol>
        /// <h2>Default behavior:</h2>
        /// <para>If not specified, the system automatically maps the package type based on PkgFormat (or infers PkgFormat from the DownloadUrl file extension). The default mapping is:</para>
        /// <ol>
        /// <item><description><para>android: apk</para>
        /// </description></item>
        /// <item><description><para>win: tar.gz, tar, zip, rar</para>
        /// </description></item>
        /// <item><description><para>android_appmarket: apk</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>android</para>
        /// </summary>
        [NameInMap("PkgType")]
        [Validation(Required=false)]
        public string PkgType { get; set; }

    }

}
