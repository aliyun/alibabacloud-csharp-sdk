// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppAttributesResponseBody : TeaModel {
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public DescribeAppAttributesResponseBodyApps Apps { get; set; }
        public class DescribeAppAttributesResponseBodyApps : TeaModel {
            [NameInMap("AppAttribute")]
            [Validation(Required=false)]
            public List<DescribeAppAttributesResponseBodyAppsAppAttribute> AppAttribute { get; set; }
            public class DescribeAppAttributesResponseBodyAppsAppAttribute : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeAppAttributesResponseBodyAppsAppAttributeTags Tags { get; set; }
                public class DescribeAppAttributesResponseBodyAppsAppAttributeTags : TeaModel {
                    [NameInMap("TagInfo")]
                    [Validation(Required=false)]
                    public List<DescribeAppAttributesResponseBodyAppsAppAttributeTagsTagInfo> TagInfo { get; set; }
                    public class DescribeAppAttributesResponseBodyAppsAppAttributeTagsTagInfo : TeaModel {
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
        /// <para>8883AC74-259D-4C0B-99FC-0B7F9A588B2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
