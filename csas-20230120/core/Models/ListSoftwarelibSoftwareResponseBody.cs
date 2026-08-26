// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListSoftwarelibSoftwareResponseBody : TeaModel {
        /// <summary>
        /// <para>The software list.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListSoftwarelibSoftwareResponseBodyDataList> DataList { get; set; }
        public class ListSoftwarelibSoftwareResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The associated built-in software ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>softwarelib-software-1da844a39729****</para>
            /// </summary>
            [NameInMap("BuiltinSoftwareId")]
            [Validation(Required=false)]
            public string BuiltinSoftwareId { get; set; }

            /// <summary>
            /// <para>The software BundleId used for verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test software</para>
            /// </summary>
            [NameInMap("CheckBundleId")]
            [Validation(Required=false)]
            public string CheckBundleId { get; set; }

            /// <summary>
            /// <para>The software name used for verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test software</para>
            /// </summary>
            [NameInMap("CheckSoftwareName")]
            [Validation(Required=false)]
            public string CheckSoftwareName { get; set; }

            /// <summary>
            /// <para>The software classification ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>softwarelib-classify-61b7ccc63cae****</para>
            /// </summary>
            [NameInMap("ClassifyId")]
            [Validation(Required=false)]
            public string ClassifyId { get; set; }

            /// <summary>
            /// <para>The time when the software was created, in seconds-level UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1781748302</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The software description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a demo software.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of associated terminal device IDs.</para>
            /// </summary>
            [NameInMap("DevTags")]
            [Validation(Required=false)]
            public List<string> DevTags { get; set; }

            /// <summary>
            /// <para>The list of associated device group IDs.</para>
            /// </summary>
            [NameInMap("DeviceGroupIds")]
            [Validation(Required=false)]
            public List<string> DeviceGroupIds { get; set; }

            /// <summary>
            /// <para>The number of times the software has been manually downloaded from the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DownloadTimes")]
            [Validation(Required=false)]
            public long? DownloadTimes { get; set; }

            /// <summary>
            /// <para>Indicates whether a new version is available for the software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasNewVersion")]
            [Validation(Required=false)]
            public bool? HasNewVersion { get; set; }

            /// <summary>
            /// <para>The URL of the software logo.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img.alicdn.com/imgextra/i4/O1CN01mXKAQX1P3a5fbS0Dp_!!6000000001785-2-tps-40-40.png">https://img.alicdn.com/imgextra/i4/O1CN01mXKAQX1P3a5fbS0Dp_!!6000000001785-2-tps-40-40.png</a></para>
            /// </summary>
            [NameInMap("LogoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            /// <summary>
            /// <para>The latest software version number for Mac (Apple).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("MacAppleVersion")]
            [Validation(Required=false)]
            public string MacAppleVersion { get; set; }

            /// <summary>
            /// <para>The latest software version number for Mac (Intel).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("MacIntelVersion")]
            [Validation(Required=false)]
            public string MacIntelVersion { get; set; }

            /// <summary>
            /// <para>The policy matching target type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UserGroupAll</b>: all users.</description></item>
            /// <item><description><b>UserGroupNormal</b>: specified user groups.</description></item>
            /// <item><description><b>DevTagNormal</b>: specified devices.</description></item>
            /// <item><description><b>DeviceGroupNormal</b>: specified device groups.</description></item>
            /// <item><description><b>DevTagAll</b>: all devices.</description></item>
            /// <item><description><b>None</b>: not configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UserGroupAll</para>
            /// </summary>
            [NameInMap("MatchMode")]
            [Validation(Required=false)]
            public string MatchMode { get; set; }

            /// <summary>
            /// <para>The official download URL of the software.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx.com/">http://xxx.com/</a>****</para>
            /// </summary>
            [NameInMap("OfficialDownloadUrl")]
            [Validation(Required=false)]
            public string OfficialDownloadUrl { get; set; }

            /// <summary>
            /// <para>The execution account (only supported on Windows).</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("RunAsAccount")]
            [Validation(Required=false)]
            public string RunAsAccount { get; set; }

            /// <summary>
            /// <para>The software ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>softwarelib-software-1da844a39729****</para>
            /// </summary>
            [NameInMap("SoftwareId")]
            [Validation(Required=false)]
            public string SoftwareId { get; set; }

            /// <summary>
            /// <para>The software name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Thunder</para>
            /// </summary>
            [NameInMap("SoftwareName")]
            [Validation(Required=false)]
            public string SoftwareName { get; set; }

            /// <summary>
            /// <para>Indicates whether the built-in library source has been deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SourceRemoved")]
            [Validation(Required=false)]
            public bool? SourceRemoved { get; set; }

            /// <summary>
            /// <para>The software source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>custom</b>: custom software.</description></item>
            /// <item><description><b>builtin</b>: built-in software library.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The list of associated user group IDs.</para>
            /// </summary>
            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<string> UserGroupIds { get; set; }

            /// <summary>
            /// <para>The software version list. This field is not returned by this operation. Call <a href="~~ListSoftwarelibVersion~~">ListSoftwarelibVersion</a> to query software versions.</para>
            /// </summary>
            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<ListSoftwarelibSoftwareResponseBodyDataListVersions> Versions { get; set; }
            public class ListSoftwarelibSoftwareResponseBodyDataListVersions : TeaModel {
                /// <summary>
                /// <para>The time when the software version was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-05 18:03:58</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The number of times the software has been downloaded from the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DownloadTimes")]
                [Validation(Required=false)]
                public long? DownloadTimes { get; set; }

                /// <summary>
                /// <para>The MD5 value of the software package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0b5824cdd509d3ed560e2d20d29a1bcb</para>
                /// </summary>
                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                /// <summary>
                /// <para>The time when the software version was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-05 18:03:58</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The operating system to which the software package applies. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Windows</b>: Windows.</description></item>
                /// <item><description><b>Mac(Apple)</b>: macOS with Apple silicon.</description></item>
                /// <item><description><b>Mac(Intel)</b>: macOS with Intel processors.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Windows</para>
                /// </summary>
                [NameInMap("Os")]
                [Validation(Required=false)]
                public string Os { get; set; }

                /// <summary>
                /// <para>The software publisher type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>local</b>: locally uploaded.</description></item>
                /// <item><description><b>thirdparty</b>: third-party link.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>local</para>
                /// </summary>
                [NameInMap("PublisherType")]
                [Validation(Required=false)]
                public string PublisherType { get; set; }

                /// <summary>
                /// <para>The ID of the software to which this version belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>softwarelib-software-1da844a39729****</para>
                /// </summary>
                [NameInMap("SoftwareId")]
                [Validation(Required=false)]
                public string SoftwareId { get; set; }

                /// <summary>
                /// <para>The name of the software package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test softwarename</para>
                /// </summary>
                [NameInMap("SoftwarePkgName")]
                [Validation(Required=false)]
                public string SoftwarePkgName { get; set; }

                /// <summary>
                /// <para>The size of the software package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SoftwarePkgSize")]
                [Validation(Required=false)]
                public long? SoftwarePkgSize { get; set; }

                /// <summary>
                /// <para>The download URL of the software package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://<b><b>.com/</b></b></para>
                /// </summary>
                [NameInMap("SoftwareUrl")]
                [Validation(Required=false)]
                public string SoftwareUrl { get; set; }

                /// <summary>
                /// <para>The version publish status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>published</b>: published.</description></item>
                /// <item><description><b>unpublished</b>: not published.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>published</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The software version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The software version ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>softwarelib-version-21ae186e2ac9****</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            /// <summary>
            /// <para>The latest software version number for Windows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("WindowsVersion")]
            [Validation(Required=false)]
            public string WindowsVersion { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries per page. This parameter is not returned by this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. This parameter is not returned by this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFM+3L1WZbKngBeLWcDmQrzLuGDDwAw7JA5q2AjvTSJm9WyhQ0MwJoOWpky9ZhgcWfIgtGpZ+4NQX97+EIwsqUNQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE4FB974-11BC-5453-9BE1-1606A73EACA6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of software entries that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
