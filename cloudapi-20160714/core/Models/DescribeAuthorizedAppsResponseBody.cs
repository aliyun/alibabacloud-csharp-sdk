// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAuthorizedAppsResponseBody : TeaModel {
        [NameInMap("AuthorizedApps")]
        [Validation(Required=false)]
        public DescribeAuthorizedAppsResponseBodyAuthorizedApps AuthorizedApps { get; set; }
        public class DescribeAuthorizedAppsResponseBodyAuthorizedApps : TeaModel {
            [NameInMap("AuthorizedApp")]
            [Validation(Required=false)]
            public List<DescribeAuthorizedAppsResponseBodyAuthorizedAppsAuthorizedApp> AuthorizedApp { get; set; }
            public class DescribeAuthorizedAppsResponseBodyAuthorizedAppsAuthorizedApp : TeaModel {
                [NameInMap("AppDescription")]
                [Validation(Required=false)]
                public string AppDescription { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AuthVaildTime")]
                [Validation(Required=false)]
                public string AuthVaildTime { get; set; }

                [NameInMap("AuthorizationSource")]
                [Validation(Required=false)]
                public string AuthorizationSource { get; set; }

                [NameInMap("AuthorizedTime")]
                [Validation(Required=false)]
                public string AuthorizedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("StageAlias")]
                [Validation(Required=false)]
                public string StageAlias { get; set; }

                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public DescribeAuthorizedAppsResponseBodyAuthorizedAppsAuthorizedAppTag Tag { get; set; }
                public class DescribeAuthorizedAppsResponseBodyAuthorizedAppsAuthorizedAppTag : TeaModel {
                    [NameInMap("TagInfo")]
                    [Validation(Required=false)]
                    public List<DescribeAuthorizedAppsResponseBodyAuthorizedAppsAuthorizedAppTagTagInfo> TagInfo { get; set; }
                    public class DescribeAuthorizedAppsResponseBodyAuthorizedAppsAuthorizedAppTagTagInfo : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6E46F10-F26C-4AA0-BB69-FE2743D9AE62</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
