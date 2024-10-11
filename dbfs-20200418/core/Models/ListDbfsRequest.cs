// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListDbfsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FsName</para>
        /// </summary>
        [NameInMap("FilterKey")]
        [Validation(Required=false)]
        public string FilterKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dbfs-test-01</para>
        /// </summary>
        [NameInMap("FilterValue")]
        [Validation(Required=false)]
        public string FilterValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <b>Example:</b>
        /// <para>SizeG</para>
        /// </summary>
        [NameInMap("SortKey")]
        [Validation(Required=false)]
        public string SortKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;TagKey&quot;:&quot;k1&quot;,&quot;TagValue&quot;:&quot;v1&quot;},{&quot;TagKey&quot;:&quot;k2&quot;,&quot;TagValue&quot;:&quot;v2&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
