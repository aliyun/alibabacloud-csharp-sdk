// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeImageCachesRequest : TeaModel {
        /// <summary>
        /// <para>The container images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nginx</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The IDs of the image caches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imc-bp195erqe9o2pb09****</para>
        /// </summary>
        [NameInMap("ImageCacheId")]
        [Validation(Required=false)]
        public string ImageCacheId { get; set; }

        /// <summary>
        /// <para>The names of the image caches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testcache</para>
        /// </summary>
        [NameInMap("ImageCacheName")]
        [Validation(Required=false)]
        public string ImageCacheName { get; set; }

        /// <summary>
        /// <para>Specifies whether the image layers of the image caches must contain all image layers of the container image.\
        /// If you configure MatchImage, you can configure this parameter to further filter query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ImageFullMatch")]
        [Validation(Required=false)]
        public bool? ImageFullMatch { get; set; }

        /// <summary>
        /// <para>The quantity of image caches whose image layers contain all image layers of the container image.\
        /// If you configure MatchImage, you can configure this parameter to further filter query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ImageMatchCountRequest")]
        [Validation(Required=false)]
        public int? ImageMatchCountRequest { get; set; }

        /// <summary>
        /// <para>The maximum entries of query results that are allowed to be displayed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The container images used to match the image caches that you want to query. You can specify a maximum of 100 container images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/eci_open/nginx:1.15.10-perl</para>
        /// </summary>
        [NameInMap("MatchImage")]
        [Validation(Required=false)]
        public List<string> MatchImage { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the image caches.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the image caches belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-2df3isufhi38****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The IDs of the snapshots that correspond to the image caches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-2zec5oj8e1yhxijt****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The tags to add to the image caches.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeImageCachesRequestTag> Tag { get; set; }
        public class DescribeImageCachesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imc</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
