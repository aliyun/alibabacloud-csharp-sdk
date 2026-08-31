// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAssetDirectoriesRequest : TeaModel {
        /// <summary>
        /// <para>The query parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListAssetDirectoriesRequestListQuery ListQuery { get; set; }
        public class ListAssetDirectoriesRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The folder name keyword. Maximum length: 128 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Core Metrics</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The maximum number of expansion levels. This parameter takes effect only in browse mode. Valid values: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6470568</para>
            /// </summary>
            [NameInMap("MaxLevel")]
            [Validation(Required=false)]
            public int? MaxLevel { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>696844</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 50. Valid values: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7576639</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The parent folder ID. This parameter takes effect only in browse mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>466096149777</para>
            /// </summary>
            [NameInMap("ParentDirectoryId")]
            [Validation(Required=false)]
            public long? ParentDirectoryId { get; set; }

            /// <summary>
            /// <para>The topic ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>796027234512</para>
            /// </summary>
            [NameInMap("TopicId")]
            [Validation(Required=false)]
            public long? TopicId { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
