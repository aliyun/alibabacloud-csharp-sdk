// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaByFaceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("CustomFilters")]
        [Validation(Required=false)]
        public string CustomFilters { get; set; }

        /// <summary>
        /// <para>The ID of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2d3bf1e35a1e42b5ab338d701efa****</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The token that is used to identify the query. You can use this parameter in the SearchMediaClipByFace operation to specify the same query conditions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zxtest-huangxuan-2023-3-7-V1</para>
        /// </summary>
        [NameInMap("FaceSearchToken")]
        [Validation(Required=false)]
        public string FaceSearchToken { get; set; }

        /// <summary>
        /// <para>The type of the media asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>image</description></item>
        /// <item><description>video</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The URL of the face image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://<b><b>.oss-cn-shanghai.aliyuncs.com/input/huangxuan</b></b>.jpg</para>
        /// </summary>
        [NameInMap("PersonImageUrl")]
        [Validation(Required=false)]
        public string PersonImageUrl { get; set; }

        /// <summary>
        /// <para>The name of the search library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("UtcCreate")]
        [Validation(Required=false)]
        public string UtcCreate { get; set; }

    }

}
