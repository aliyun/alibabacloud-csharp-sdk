// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaByFaceRequest : TeaModel {
        /// <summary>
        /// <para>The custom filter. JSON string. Supported fields include integer field intField1 and string fields strField1 and strField2. Each field supports only one matching mode. Filters on different fields are combined with an AND relationship.</para>
        /// <list type="bullet">
        /// <item><description>Exact match, such as {&quot;intField1&quot;:12,&quot;strField1&quot;:&quot;abc&quot;}</description></item>
        /// <item><description>Multi-value match, such as {&quot;intField1&quot;:[12,13],&quot;strField1&quot;:[&quot;abc&quot;,&quot;cd&quot;]}</description></item>
        /// <item><description>Range match, such as {&quot;intField1&quot;:{&quot;gte&quot;:12,&quot;lte&quot;:13}}</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;intField1&quot;:{&quot;gte&quot;:12,&quot;lte&quot;:13},&quot;strField2&quot;:[&quot;cd&quot;,&quot;de&quot;],&quot;strField1&quot;:&quot;abc&quot;}</para>
        /// </summary>
        [NameInMap("CustomFilters")]
        [Validation(Required=false)]
        public string CustomFilters { get; set; }

        /// <summary>
        /// <para>The entity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2d3bf1e35a1e42b5ab338d701efa****</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The token used to identify paginated results under the same search condition. Use this parameter together with the FaceSearchToken parameter in the <a href="https://help.aliyun.com/document_detail/612891.html">refined search operation</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zxtest-huangxuan-2023-3-7-V1</para>
        /// </summary>
        [NameInMap("FaceSearchToken")]
        [Validation(Required=false)]
        public string FaceSearchToken { get; set; }

        /// <summary>
        /// <para>The media asset type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>image: image</description></item>
        /// <item><description>video: video</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name-1</para>
        /// </summary>
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
        /// <para>The creation time, in millisecond-precision timestamp. gte specifies greater than or equal to, and lte specifies less than or equal to.</para>
        /// <list type="bullet">
        /// <item><description>Range, such as {&quot;gte&quot;:1761205662998,&quot;lte&quot;:1771205662998}</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;gte&quot;:1761205662998,&quot;lte&quot;:1771205662998}</para>
        /// </summary>
        [NameInMap("UtcCreate")]
        [Validation(Required=false)]
        public string UtcCreate { get; set; }

    }

}
