// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The objects that are returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAppsResponseBodyData> Data { get; set; }
        public class DescribeAppsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The version of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("AndroidAppVersion")]
            [Validation(Required=false)]
            public string AndroidAppVersion { get; set; }

            /// <summary>
            /// <para>Apk size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.7</para>
            /// </summary>
            [NameInMap("ApkSize")]
            [Validation(Required=false)]
            public string ApkSize { get; set; }

            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10404</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testapp</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The application type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>Region id.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("BizRegionId")]
            [Validation(Required=false)]
            public string BizRegionId { get; set; }

            /// <summary>
            /// <para>The description of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CustomApp</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the application was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-11 17:45:03</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the application was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-11 17:45:03</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The icon URL of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://test.png">https://test.png</a></para>
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <para>The installation/uninstallation status of the application.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>INSTALLFAILED: The application failed to be installed.</para>
            /// </description></item>
            /// <item><description><para>UNINSTALLING: The application is being uninstalled.</para>
            /// </description></item>
            /// <item><description><para>INSTALLING: The application is being installed.</para>
            /// </description></item>
            /// <item><description><para>UNINSTALLED: The application is uninstalled.</para>
            /// </description></item>
            /// <item><description><para>INSTALLED: The application is installed.</para>
            /// </description></item>
            /// <item><description><para>UNINSTALLFAILED: The application failed to be uninstalled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INSTALLING</para>
            /// </summary>
            [NameInMap("InstallationStatus")]
            [Validation(Required=false)]
            public string InstallationStatus { get; set; }

            /// <summary>
            /// <para>The list of instance groups where the application is installed.</para>
            /// </summary>
            [NameInMap("InstanceGroupList")]
            [Validation(Required=false)]
            public List<string> InstanceGroupList { get; set; }

            /// <summary>
            /// <para>The value of MD5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>009ee07fe13a29fa0c180ed0b6bc****</para>
            /// </summary>
            [NameInMap("MD5")]
            [Validation(Required=false)]
            public string MD5 { get; set; }

            /// <summary>
            /// <para>The name of the application package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.example.chinalife</para>
            /// </summary>
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            /// <summary>
            /// <para>The status of the application.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>FAILED: The application failed to be created.</para>
            /// </description></item>
            /// <item><description><para>NORMAL: The application is available.</para>
            /// </description></item>
            /// <item><description><para>CREATING: The application is being created.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l5V9uON****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB95E410-FD1D-53C5-9F7D-93CC44D7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
