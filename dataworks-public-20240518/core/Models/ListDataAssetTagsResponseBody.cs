// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataAssetTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated query results for the tag list.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataAssetTagsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataAssetTagsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("DataAssetTags")]
            [Validation(Required=false)]
            public List<ListDataAssetTagsResponseBodyPagingInfoDataAssetTags> DataAssetTags { get; set; }
            public class ListDataAssetTagsResponseBodyPagingInfoDataAssetTags : TeaModel {
                /// <summary>
                /// <para>The tag type.</para>
                /// <list type="bullet">
                /// <item><description>Normal</description></item>
                /// <item><description>System</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The creation time of the tag.</para>
                /// <para>The value is a 13-digit number, such as <c>1735890003000</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735890003000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The creator of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The list of tag administrators.</para>
                /// </summary>
                [NameInMap("Managers")]
                [Validation(Required=false)]
                public List<string> Managers { get; set; }

                /// <summary>
                /// <para>The last modification time of the tag.</para>
                /// <para>The value is a 13-digit number, such as <c>1735890003000</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735890003000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The user who last modified the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>The type of the tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>String</para>
                /// </summary>
                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

                /// <summary>
                /// <para>The list of tag values.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2524</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1ec92159376****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
