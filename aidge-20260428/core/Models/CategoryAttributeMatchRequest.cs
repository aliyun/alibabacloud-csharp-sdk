// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class CategoryAttributeMatchRequest : TeaModel {
        /// <summary>
        /// <para>The product details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>真丝，春季新款</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The product image URLs. A maximum of 10 images are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://frametour-assets.oss-cn-shanghai.aliyuncs.com/user-faces/viid_face/dd0dd06c-9351-4e5f-bc70-24166a754d7f.jpg">https://frametour-assets.oss-cn-shanghai.aliyuncs.com/user-faces/viid_face/dd0dd06c-9351-4e5f-bc70-24166a754d7f.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public List<string> ImageUrl { get; set; }

        /// <summary>
        /// <para>The product attributes that describe the product characteristics.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>例如商品的材质等。输入商品属性名称和属性内容</para>
        /// </summary>
        [NameInMap("ItemSpec")]
        [Validation(Required=false)]
        public string ItemSpec { get; set; }

        /// <summary>
        /// <para>The product SKU title.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>衣服</para>
        /// </summary>
        [NameInMap("SourceCategory")]
        [Validation(Required=false)]
        public string SourceCategory { get; set; }

        /// <summary>
        /// <para>The source platform from which the product originates.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1688</para>
        /// </summary>
        [NameInMap("SourcePlatform")]
        [Validation(Required=false)]
        public string SourcePlatform { get; set; }

        /// <summary>
        /// <para>The target listing platform. Currently, only temu is supported.</para>
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
        /// <para>女士春季新款衣服</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
