// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppAttributesResponseBody : TeaModel {
        /// <summary>
        /// The returned app information. It is an array that consists of AppAttribute data.
        /// </summary>
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public DescribeAppAttributesResponseBodyApps Apps { get; set; }
        public class DescribeAppAttributesResponseBodyApps : TeaModel {
            [NameInMap("AppAttribute")]
            [Validation(Required=false)]
            public List<DescribeAppAttributesResponseBodyAppsAppAttribute> AppAttribute { get; set; }
            public class DescribeAppAttributesResponseBodyAppsAppAttribute : TeaModel {
                /// <summary>
                /// The ID of the app.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// The name of the app.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The creation time (UTC) of the app.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The description of the app.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 扩展信息
                /// </summary>
                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

                /// <summary>
                /// The modification time (UTC) of the app.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeAppAttributesResponseBodyAppsAppAttributeTags Tags { get; set; }
                public class DescribeAppAttributesResponseBodyAppsAppAttributeTags : TeaModel {
                    [NameInMap("TagInfo")]
                    [Validation(Required=false)]
                    public List<DescribeAppAttributesResponseBodyAppsAppAttributeTagsTagInfo> TagInfo { get; set; }
                    public class DescribeAppAttributesResponseBodyAppsAppAttributeTagsTagInfo : TeaModel {
                        /// <summary>
                        /// The key of the tag.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
