// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class CategoryMatchRequest : TeaModel {
        /// <summary>
        /// <para>The product description.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Silk, new spring style</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The product attributes that describe the characteristics of the product, such as material. Provide the attribute names and values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>材质:涤纶,适用对象:通用,品牌:艾马逊AMASON PET</para>
        /// </summary>
        [NameInMap("ItemSpec")]
        [Validation(Required=false)]
        public string ItemSpec { get; set; }

        /// <summary>
        /// <para>The product SKU title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0:0:颜色:黑(不含定位器);0:1:颜色:智能定位(不含项圈);0:2:颜色:范围定位(不含项圈);0:3:颜色:蓝(不含定位器);0:4:颜色:橙(不含定位器);0:5:颜色:粉(不含定位器);0:6:颜色:红(不含定位器);0:7:颜色:黄(不含定位器);0:8:颜色:紫(不含定位器)</para>
        /// </summary>
        [NameInMap("Sku")]
        [Validation(Required=false)]
        public string Sku { get; set; }

        /// <summary>
        /// <para>The product category on the source platform.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Clothing</para>
        /// </summary>
        [NameInMap("SourceCategory")]
        [Validation(Required=false)]
        public string SourceCategory { get; set; }

        /// <summary>
        /// <para>The source platform where products are sourced from.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1688</para>
        /// </summary>
        [NameInMap("SourcePlatform")]
        [Validation(Required=false)]
        public string SourcePlatform { get; set; }

        /// <summary>
        /// <para>The target listing platform. Currently only temu is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>temu</para>
        /// </summary>
        [NameInMap("TargetPlatform")]
        [Validation(Required=false)]
        public string TargetPlatform { get; set; }

        /// <summary>
        /// <para>The product title.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Women\&quot;s new spring clothing</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
