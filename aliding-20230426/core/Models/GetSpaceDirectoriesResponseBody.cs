// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetSpaceDirectoriesResponseBody : TeaModel {
        [NameInMap("children")]
        [Validation(Required=false)]
        public List<GetSpaceDirectoriesResponseBodyChildren> Children { get; set; }
        public class GetSpaceDirectoriesResponseBodyChildren : TeaModel {
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public GetSpaceDirectoriesResponseBodyChildrenCreator Creator { get; set; }
            public class GetSpaceDirectoriesResponseBodyChildrenCreator : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("DentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            [NameInMap("DentryType")]
            [Validation(Required=false)]
            public string DentryType { get; set; }

            [NameInMap("DentryUuid")]
            [Validation(Required=false)]
            public string DentryUuid { get; set; }

            [NameInMap("DocKey")]
            [Validation(Required=false)]
            public string DocKey { get; set; }

            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("HasChildren")]
            [Validation(Required=false)]
            public bool? HasChildren { get; set; }

            [NameInMap("LinkSourceInfo")]
            [Validation(Required=false)]
            public GetSpaceDirectoriesResponseBodyChildrenLinkSourceInfo LinkSourceInfo { get; set; }
            public class GetSpaceDirectoriesResponseBodyChildrenLinkSourceInfo : TeaModel {
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("IconUrl")]
                [Validation(Required=false)]
                public GetSpaceDirectoriesResponseBodyChildrenLinkSourceInfoIconUrl IconUrl { get; set; }
                public class GetSpaceDirectoriesResponseBodyChildrenLinkSourceInfoIconUrl : TeaModel {
                    [NameInMap("Line")]
                    [Validation(Required=false)]
                    public string Line { get; set; }

                    [NameInMap("Small")]
                    [Validation(Required=false)]
                    public string Small { get; set; }

                }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("LinkType")]
                [Validation(Required=false)]
                public long? LinkType { get; set; }

                [NameInMap("SpaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Space")]
            [Validation(Required=false)]
            public GetSpaceDirectoriesResponseBodyChildrenSpace Space { get; set; }
            public class GetSpaceDirectoriesResponseBodyChildrenSpace : TeaModel {
                [NameInMap("Cover")]
                [Validation(Required=false)]
                public string Cover { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("HdIconVO")]
                [Validation(Required=false)]
                public GetSpaceDirectoriesResponseBodyChildrenSpaceHdIconVO HdIconVO { get; set; }
                public class GetSpaceDirectoriesResponseBodyChildrenSpaceHdIconVO : TeaModel {
                    [NameInMap("Icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("IconVO")]
                [Validation(Required=false)]
                public GetSpaceDirectoriesResponseBodyChildrenSpaceIconVO IconVO { get; set; }
                public class GetSpaceDirectoriesResponseBodyChildrenSpaceIconVO : TeaModel {
                    [NameInMap("Icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public GetSpaceDirectoriesResponseBodyChildrenSpaceOwner Owner { get; set; }
                public class GetSpaceDirectoriesResponseBodyChildrenSpaceOwner : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("RecentList")]
                [Validation(Required=false)]
                public List<object> RecentList { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("VisitorInfo")]
                [Validation(Required=false)]
                public GetSpaceDirectoriesResponseBodyChildrenSpaceVisitorInfo VisitorInfo { get; set; }
                public class GetSpaceDirectoriesResponseBodyChildrenSpaceVisitorInfo : TeaModel {
                    [NameInMap("DentryActions")]
                    [Validation(Required=false)]
                    public List<string> DentryActions { get; set; }

                    [NameInMap("RoleCode")]
                    [Validation(Required=false)]
                    public string RoleCode { get; set; }

                    [NameInMap("SpaceActions")]
                    [Validation(Required=false)]
                    public List<string> SpaceActions { get; set; }

                }

            }

            [NameInMap("SpaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            [NameInMap("StatisticalInfo")]
            [Validation(Required=false)]
            public GetSpaceDirectoriesResponseBodyChildrenStatisticalInfo StatisticalInfo { get; set; }
            public class GetSpaceDirectoriesResponseBodyChildrenStatisticalInfo : TeaModel {
                /// <summary>
                /// WordCount
                /// </summary>
                [NameInMap("WordCount")]
                [Validation(Required=false)]
                public long? WordCount { get; set; }

            }

            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            [NameInMap("Updater")]
            [Validation(Required=false)]
            public GetSpaceDirectoriesResponseBodyChildrenUpdater Updater { get; set; }
            public class GetSpaceDirectoriesResponseBodyChildrenUpdater : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("VisitorInfo")]
            [Validation(Required=false)]
            public GetSpaceDirectoriesResponseBodyChildrenVisitorInfo VisitorInfo { get; set; }
            public class GetSpaceDirectoriesResponseBodyChildrenVisitorInfo : TeaModel {
                [NameInMap("DentryActions")]
                [Validation(Required=false)]
                public List<string> DentryActions { get; set; }

                [NameInMap("RoleCode")]
                [Validation(Required=false)]
                public string RoleCode { get; set; }

                [NameInMap("SpaceActions")]
                [Validation(Required=false)]
                public List<string> SpaceActions { get; set; }

            }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
