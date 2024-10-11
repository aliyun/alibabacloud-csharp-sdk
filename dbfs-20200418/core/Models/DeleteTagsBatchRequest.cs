// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class DeleteTagsBatchRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;dbfs-nUy1tb<b><b><b><b>BQ4X8Gpw&quot;,&quot;dbfs-v0WvA</b></b></b></b>tVEVcgJLg&quot;]</para>
        /// </summary>
        [NameInMap("DbfsList")]
        [Validation(Required=false)]
        public string DbfsList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;TagKey&quot;:&quot;k1&quot;,&quot;TagValue&quot;:&quot;v1&quot;},{&quot;TagKey&quot;:&quot;k2&quot;,&quot;TagValue&quot;:&quot;v2&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
