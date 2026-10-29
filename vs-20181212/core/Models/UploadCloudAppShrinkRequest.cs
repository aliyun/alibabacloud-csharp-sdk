// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UploadCloudAppShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application name. For Android applications, we recommend that you use the package name, such as com.aaa.bbb. Naming conventions: 1. The length is 4 to 50 characters. 2. The name can contain lowercase letters, digits, underscores (_), hyphens (-), and periods (.). 3. The first and last characters must be letters or digits.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aaa.bbb</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The application version. For Android applications, we recommend that you use the VersionName, such as 1.1.1. Naming conventions: 1. The length is 1 to 50 characters. 2. The version can contain lowercase letters, digits, underscores (_), hyphens (-), and periods (.). 3. The first and last characters must be letters or digits.</para>
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
        /// <para>The MD5 hash of the application package, which is used to check the integrity of the application package.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CFBB7BD10CDD7279642ADAB8FEF3DEE</para>
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// <para>The format of the installation package. The default value is the file name extension of the download URL. Valid values: 1. apk 2. tar.gz 3. tar 4. zip 5. rar.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apk</para>
        /// </summary>
        [NameInMap("PkgFormat")]
        [Validation(Required=false)]
        public string PkgFormat { get; set; }

        /// <summary>
        /// <para>The tags of the cloud application. You can specify multiple tags. Valid values: 1. hot 2. game 3. app.</para>
        /// </summary>
        [NameInMap("PkgLabels")]
        [Validation(Required=false)]
        public string PkgLabelsShrink { get; set; }

        /// <summary>
        /// <para>The type of the installation package. ## Valid values: 1. android 2. win 3. android_appmarket: This value applies to Android app marketplace scenarios. In this scenario, the actual package name of the APK is restricted. a. The package names of different AppName values cannot be duplicated. b. Different AppVersion values of the same AppName can be associated with different package names. ## Default value description: If this parameter is not specified, the installation package type is automatically mapped based on the PkgFormat parameter or the file name extension of the DownloadUrl parameter. The default mapping between PkgFormat and the installation package type is as follows: 1. android: apk. The apk format is mapped to android by default. 2. win: tar.gz, tar, zip, and rar. 3. android_appmarket: apk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>android</para>
        /// </summary>
        [NameInMap("PkgType")]
        [Validation(Required=false)]
        public string PkgType { get; set; }

        /// <summary>
        /// <para>The relative path of the post-command in the application package. This parameter is supported only for Windows applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>install.ps1</para>
        /// </summary>
        [NameInMap("PostCommandPath")]
        [Validation(Required=false)]
        public string PostCommandPath { get; set; }

        /// <summary>
        /// <para>The timeout period for executing the post-command, in seconds. This parameter is supported only for Windows applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PostCommandTimeoutSec")]
        [Validation(Required=false)]
        public int? PostCommandTimeoutSec { get; set; }

    }

}
