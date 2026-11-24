// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class CategoryMatchRequest : TeaModel {
        /// <summary>
        /// <para>The product details.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Silk, spring new arrival</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The product attributes and feature descriptions, such as the product material. Specify the attribute names and values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Material:Polyester,Target audience:Universal,Brand:AMASON PET</para>
        /// </summary>
        [NameInMap("ItemSpec")]
        [Validation(Required=false)]
        public string ItemSpec { get; set; }

        /// <summary>
        /// <para>The product SKU title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0:0:Color:Black (without tracker);0:1:Color:Smart tracking (without collar);0:2:Color:Range tracking (without collar);0:3:Color:Blue (without tracker);0:4:Color:Orange (without tracker);0:5:Color:Pink (without tracker);0:6:Color:Red (without tracker);0:7:Color:Yellow (without tracker);0:8:Color:Purple (without tracker)</para>
        /// </summary>
        [NameInMap("Sku")]
        [Validation(Required=false)]
        public string Sku { get; set; }

        /// <summary>
        /// <para>The product category.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Clothing</para>
        /// </summary>
        [NameInMap("SourceCategory")]
        [Validation(Required=false)]
        public string SourceCategory { get; set; }

        /// <summary>
        /// <para>The source platform.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1688</para>
        /// </summary>
        [NameInMap("SourcePlatform")]
        [Validation(Required=false)]
        public string SourcePlatform { get; set; }

        /// <summary>
        /// <para>The target platform. Currently, only TEMU is supported.</para>
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
        /// <para>Women\&quot;s spring new arrival clothing</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
