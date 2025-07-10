// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned app information. It is an array that consists of AppAttribute data.</para>
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
                /// <para>The ID of the app.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20112314518278</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// <para>The name of the app.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CreateApptest</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The creation time (UTC) of the app.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-31T04:10:19Z</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The description of the app.</para>
                /// 
                /// <b>Example:</b>
                /// <para>App test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// <para>扩展信息</para>
                /// 
                /// <b>Example:</b>
                /// <para>110461946884</para>
                /// </summary>
                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

                /// <summary>
                /// <para>The modification time (UTC) of the app.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-31T04:10:19Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The tags.</para>
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
                        /// <para>The key of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>appid</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
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
