// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLivePackageChannelGroupsResponseBody : TeaModel {
        [NameInMap("LivePackageChannelGroups")]
        [Validation(Required=false)]
        public List<ListLivePackageChannelGroupsResponseBodyLivePackageChannelGroups> LivePackageChannelGroups { get; set; }
        public class ListLivePackageChannelGroupsResponseBodyLivePackageChannelGroups : TeaModel {
            /// <summary>
            /// <para>创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>代表资源一级ID的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>testChannelGroup</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>修改时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-02T12:00:00Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>源站域名</para>
            /// 
            /// <b>Example:</b>
            /// <para>origin.example.com</para>
            /// </summary>
            [NameInMap("OriginDomain")]
            [Validation(Required=false)]
            public string OriginDomain { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
