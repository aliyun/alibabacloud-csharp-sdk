// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryDentryResponseBody : TeaModel {
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public QueryDentryResponseBodyCreator Creator { get; set; }
        public class QueryDentryResponseBodyCreator : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("dentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        [NameInMap("dentryType")]
        [Validation(Required=false)]
        public string DentryType { get; set; }

        [NameInMap("dentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        [NameInMap("docKey")]
        [Validation(Required=false)]
        public string DocKey { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        [NameInMap("hasChildren")]
        [Validation(Required=false)]
        public bool? HasChildren { get; set; }

        [NameInMap("linkSourceInfo")]
        [Validation(Required=false)]
        public QueryDentryResponseBodyLinkSourceInfo LinkSourceInfo { get; set; }
        public class QueryDentryResponseBodyLinkSourceInfo : TeaModel {
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public QueryDentryResponseBodyLinkSourceInfoIconUrl IconUrl { get; set; }
            public class QueryDentryResponseBodyLinkSourceInfoIconUrl : TeaModel {
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

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("space")]
        [Validation(Required=false)]
        public QueryDentryResponseBodySpace Space { get; set; }
        public class QueryDentryResponseBodySpace : TeaModel {
            [NameInMap("Cover")]
            [Validation(Required=false)]
            public string Cover { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("HdIconVO")]
            [Validation(Required=false)]
            public QueryDentryResponseBodySpaceHdIconVO HdIconVO { get; set; }
            public class QueryDentryResponseBodySpaceHdIconVO : TeaModel {
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("IconVO")]
            [Validation(Required=false)]
            public QueryDentryResponseBodySpaceIconVO IconVO { get; set; }
            public class QueryDentryResponseBodySpaceIconVO : TeaModel {
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
            public QueryDentryResponseBodySpaceOwner Owner { get; set; }
            public class QueryDentryResponseBodySpaceOwner : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("RecentList")]
            [Validation(Required=false)]
            public List<QueryDentryResponseBodySpaceRecentList> RecentList { get; set; }
            public class QueryDentryResponseBodySpaceRecentList : TeaModel {
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public QueryDentryResponseBodySpaceRecentListCreator Creator { get; set; }
                public class QueryDentryResponseBodySpaceRecentListCreator : TeaModel {
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
                public QueryDentryResponseBodySpaceRecentListLinkSourceInfo LinkSourceInfo { get; set; }
                public class QueryDentryResponseBodySpaceRecentListLinkSourceInfo : TeaModel {
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    [NameInMap("IconUrl")]
                    [Validation(Required=false)]
                    public QueryDentryResponseBodySpaceRecentListLinkSourceInfoIconUrl IconUrl { get; set; }
                    public class QueryDentryResponseBodySpaceRecentListLinkSourceInfoIconUrl : TeaModel {
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
                public object Space { get; set; }

                [NameInMap("SpaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

                [NameInMap("StatisticalInfo")]
                [Validation(Required=false)]
                public QueryDentryResponseBodySpaceRecentListStatisticalInfo StatisticalInfo { get; set; }
                public class QueryDentryResponseBodySpaceRecentListStatisticalInfo : TeaModel {
                    [NameInMap("WordCount")]
                    [Validation(Required=false)]
                    public long? WordCount { get; set; }

                }

                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                [NameInMap("Updater")]
                [Validation(Required=false)]
                public QueryDentryResponseBodySpaceRecentListUpdater Updater { get; set; }
                public class QueryDentryResponseBodySpaceRecentListUpdater : TeaModel {
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
                public QueryDentryResponseBodySpaceRecentListVisitorInfo VisitorInfo { get; set; }
                public class QueryDentryResponseBodySpaceRecentListVisitorInfo : TeaModel {
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

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("VisitorInfo")]
            [Validation(Required=false)]
            public QueryDentryResponseBodySpaceVisitorInfo VisitorInfo { get; set; }
            public class QueryDentryResponseBodySpaceVisitorInfo : TeaModel {
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

        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("updatedTime")]
        [Validation(Required=false)]
        public long? UpdatedTime { get; set; }

        [NameInMap("updater")]
        [Validation(Required=false)]
        public QueryDentryResponseBodyUpdater Updater { get; set; }
        public class QueryDentryResponseBodyUpdater : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("visitorInfo")]
        [Validation(Required=false)]
        public QueryDentryResponseBodyVisitorInfo VisitorInfo { get; set; }
        public class QueryDentryResponseBodyVisitorInfo : TeaModel {
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

}
