// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SearchImageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Color</para>
        /// 
        /// <b>Example:</b>
        /// <para>#B0B0B0</para>
        /// </summary>
        [NameInMap("ColorHex")]
        [Validation(Required=false)]
        public string ColorHex { get; set; }

        /// <summary>
        /// <para>Indicates whether the image contains a person.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasPerson")]
        [Validation(Required=false)]
        public bool? HasPerson { get; set; }

        /// <summary>
        /// <para>Image category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: Illustrations or article images.</description></item>
        /// <item><description>banner: Background images or image carousels.</description></item>
        /// <item><description>goods: Product or service images.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WindowsWithMssqlStdLicense</para>
        /// </summary>
        [NameInMap("ImageCategory")]
        [Validation(Required=false)]
        public string ImageCategory { get; set; }

        /// <summary>
        /// <para>Image aspect ratio, including:
        /// &quot;16:9&quot;
        /// &quot;4:3&quot;
        /// &quot;2:1&quot;
        /// &quot;1:1&quot;
        /// &quot;3:4&quot;
        /// &quot;9:16&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>16:9</para>
        /// </summary>
        [NameInMap("ImageRatio")]
        [Validation(Required=false)]
        public string ImageRatio { get; set; }

        /// <summary>
        /// <para>Maximum image height.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4000</para>
        /// </summary>
        [NameInMap("MaxHeight")]
        [Validation(Required=false)]
        public int? MaxHeight { get; set; }

        /// <summary>
        /// <para>Number of items per page in a paged query. Maximum value is 100. Default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Maximum image width (inclusive).</para>
        /// 
        /// <b>Example:</b>
        /// <para>4000</para>
        /// </summary>
        [NameInMap("MaxWidth")]
        [Validation(Required=false)]
        public int? MaxWidth { get; set; }

        /// <summary>
        /// <para>Minimum image height</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MinHeight")]
        [Validation(Required=false)]
        public int? MinHeight { get; set; }

        /// <summary>
        /// <para>Minimum image width (inclusive).</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MinWidth")]
        [Validation(Required=false)]
        public int? MinWidth { get; set; }

        /// <summary>
        /// <para>Query credential (Token). Set this parameter to the NextToken value returned in the previous API call. You do not need to set this parameter for the initial API call. If NextToken is specified, the request parameters PageSize and PageNumber become invalid, and the TotalCount in the returned data is also invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFh3Xqm+JgZ/U9Jyb7wdVr9LWk80Tghn5UZjbcWEVEderBcbVF+Y6PS0i8PpCL4PQZ3e0C9oEH0Asd4tJEuGtkl2WuKdiWZpEwadNydQdJPFM=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Osskey。</para>
        /// 
        /// <b>Example:</b>
        /// <para>backend/detection/objects/r-0008ujvfksltf5j45n81/task-000hckiuwyau0gwn17vq.jpg</para>
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        /// <summary>
        /// <para>Number of results to return. Default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>Starting position of the return result. Valid values: 0 to 499. Default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

        /// <summary>
        /// <para>Tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>Description text for searching images.</para>
        /// <remarks>
        /// <para>Supports up to 512 characters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>卫浴五金产品，表面采用拉丝不锈钢材质，整体色调为现代银灰色，呈现简约且富有质感的风格。产品包括淋浴花洒、水龙头及毛巾架等配件，均具备防锈、耐腐蚀性能，适用于潮湿环境。各部件连接处设计精密，配有隐藏式螺丝结构，提升整体美观度。水龙头和花洒喷头支持多模式出水，把手操作顺滑，符合人体工学设计。所有五金件通过国家节水认证，支持冷热水接入，安装方式为壁挂式。</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
