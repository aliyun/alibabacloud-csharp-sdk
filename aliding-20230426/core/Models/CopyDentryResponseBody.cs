// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CopyDentryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>alidoc</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public Dictionary<string, object> Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("dentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("dentryType")]
        [Validation(Required=false)]
        public string DentryType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cdefg</para>
        /// </summary>
        [NameInMap("dentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aabbcc</para>
        /// </summary>
        [NameInMap("docKey")]
        [Validation(Required=false)]
        public string DocKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alidoc</para>
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasChildren")]
        [Validation(Required=false)]
        public bool? HasChildren { get; set; }

        [NameInMap("linkSourceInfo")]
        [Validation(Required=false)]
        public CopyDentryResponseBodyLinkSourceInfo LinkSourceInfo { get; set; }
        public class CopyDentryResponseBodyLinkSourceInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>docx</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public CopyDentryResponseBodyLinkSourceInfoIconUrl IconUrl { get; set; }
            public class CopyDentryResponseBodyLinkSourceInfoIconUrl : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>gh</para>
                /// </summary>
                [NameInMap("Line")]
                [Validation(Required=false)]
                public string Line { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>def</para>
                /// </summary>
                [NameInMap("Small")]
                [Validation(Required=false)]
                public string Small { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>def</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LinkType")]
            [Validation(Required=false)]
            public long? LinkType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>def</para>
            /// </summary>
            [NameInMap("SpaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试组织/测试知识库/abc</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("space")]
        [Validation(Required=false)]
        public CopyDentryResponseBodySpace Space { get; set; }
        public class CopyDentryResponseBodySpace : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://img.alicdn.com/imgextra/i1/O1xxxxx.png">https://img.alicdn.com/imgextra/i1/O1xxxxx.png</a></para>
            /// </summary>
            [NameInMap("Cover")]
            [Validation(Required=false)]
            public string Cover { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>这是简介</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("HdIconVO")]
            [Validation(Required=false)]
            public CopyDentryResponseBodySpaceHdIconVO HdIconVO { get; set; }
            public class CopyDentryResponseBodySpaceHdIconVO : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>http://</para>
                /// </summary>
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>type</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("IconVO")]
            [Validation(Required=false)]
            public CopyDentryResponseBodySpaceIconVO IconVO { get; set; }
            public class CopyDentryResponseBodySpaceIconVO : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>http://</para>
                /// </summary>
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>type</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n9XJxxxxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试知识库</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public CopyDentryResponseBodySpaceOwner Owner { get; set; }
            public class CopyDentryResponseBodySpaceOwner : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>小钉</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>012345</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("RecentList")]
            [Validation(Required=false)]
            public List<CopyDentryResponseBodySpaceRecentList> RecentList { get; set; }
            public class CopyDentryResponseBodySpaceRecentList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>alidoc</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345678</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public CopyDentryResponseBodySpaceRecentListCreator Creator { get; set; }
                public class CopyDentryResponseBodySpaceRecentListCreator : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hello</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>012345</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("DentryId")]
                [Validation(Required=false)]
                public string DentryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("DentryType")]
                [Validation(Required=false)]
                public string DentryType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cdefg</para>
                /// </summary>
                [NameInMap("DentryUuid")]
                [Validation(Required=false)]
                public string DentryUuid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aabbcc</para>
                /// </summary>
                [NameInMap("DocKey")]
                [Validation(Required=false)]
                public string DocKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alidoc</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasChildren")]
                [Validation(Required=false)]
                public bool? HasChildren { get; set; }

                [NameInMap("LinkSourceInfo")]
                [Validation(Required=false)]
                public CopyDentryResponseBodySpaceRecentListLinkSourceInfo LinkSourceInfo { get; set; }
                public class CopyDentryResponseBodySpaceRecentListLinkSourceInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>docx</para>
                    /// </summary>
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    [NameInMap("IconUrl")]
                    [Validation(Required=false)]
                    public CopyDentryResponseBodySpaceRecentListLinkSourceInfoIconUrl IconUrl { get; set; }
                    public class CopyDentryResponseBodySpaceRecentListLinkSourceInfoIconUrl : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>gh</para>
                        /// </summary>
                        [NameInMap("Line")]
                        [Validation(Required=false)]
                        public string Line { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>def</para>
                        /// </summary>
                        [NameInMap("Small")]
                        [Validation(Required=false)]
                        public string Small { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>def</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("LinkType")]
                    [Validation(Required=false)]
                    public long? LinkType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>def</para>
                    /// </summary>
                    [NameInMap("SpaceId")]
                    [Validation(Required=false)]
                    public string SpaceId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试组织/测试知识库/abc</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Space")]
                [Validation(Required=false)]
                public object Space { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bcd</para>
                /// </summary>
                [NameInMap("SpaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

                [NameInMap("StatisticalInfo")]
                [Validation(Required=false)]
                public CopyDentryResponseBodySpaceRecentListStatisticalInfo StatisticalInfo { get; set; }
                public class CopyDentryResponseBodySpaceRecentListStatisticalInfo : TeaModel {
                    [NameInMap("WordCount")]
                    [Validation(Required=false)]
                    public long? WordCount { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345678</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                [NameInMap("Updater")]
                [Validation(Required=false)]
                public CopyDentryResponseBodySpaceRecentListUpdater Updater { get; set; }
                public class CopyDentryResponseBodySpaceRecentListUpdater : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hello</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>012345</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxx.yy">https://xxx.yy</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("VisitorInfo")]
                [Validation(Required=false)]
                public CopyDentryResponseBodySpaceRecentListVisitorInfo VisitorInfo { get; set; }
                public class CopyDentryResponseBodySpaceRecentListVisitorInfo : TeaModel {
                    [NameInMap("DentryActions")]
                    [Validation(Required=false)]
                    public List<string> DentryActions { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RoleCode")]
                    [Validation(Required=false)]
                    public string RoleCode { get; set; }

                    [NameInMap("SpaceActions")]
                    [Validation(Required=false)]
                    public List<string> SpaceActions { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://alidocs.dingtalk.com/i/spaces/n9XJ*******Xy/overview">https://alidocs.dingtalk.com/i/spaces/n9XJ*******Xy/overview</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("VisitorInfo")]
            [Validation(Required=false)]
            public CopyDentryResponseBodySpaceVisitorInfo VisitorInfo { get; set; }
            public class CopyDentryResponseBodySpaceVisitorInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>GET_DENTRY</para>
                /// </summary>
                [NameInMap("DentryActions")]
                [Validation(Required=false)]
                public List<string> DentryActions { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RoleCode")]
                [Validation(Required=false)]
                public string RoleCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GET_SPACE</para>
                /// </summary>
                [NameInMap("SpaceActions")]
                [Validation(Required=false)]
                public List<string> SpaceActions { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bcd</para>
        /// </summary>
        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("updatedTime")]
        [Validation(Required=false)]
        public long? UpdatedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;UserId\&quot;: \&quot;353851\&quot;, \&quot;Name\&quot;: u\&quot;\u848b\u7fbd\u4e2d\&quot;}</para>
        /// </summary>
        [NameInMap("updater")]
        [Validation(Required=false)]
        public Dictionary<string, object> Updater { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxx.yy">https://xxx.yy</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

        [NameInMap("visitorInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> VisitorInfo { get; set; }

    }

}
