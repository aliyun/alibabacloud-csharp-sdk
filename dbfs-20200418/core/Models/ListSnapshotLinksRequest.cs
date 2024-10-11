// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListSnapshotLinksRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FsId</para>
        /// </summary>
        [NameInMap("FilterKey")]
        [Validation(Required=false)]
        public string FilterKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dbfs-kwziq4dpsle********</para>
        /// </summary>
        [NameInMap("FilterValue")]
        [Validation(Required=false)]
        public string FilterValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;dbfs-kwziq4dpsle********&quot;,&quot;dbfs-vuaqvfcjqsg********&quot;]</para>
        /// </summary>
        [NameInMap("FsIds")]
        [Validation(Required=false)]
        public string FsIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;sl-bp1grgphbcc9brb5****&quot;,&quot;sl-bp1c4izumvq0i5bs****&quot;,&quot;sl-bp1akk7isz866dds****&quot;]</para>
        /// </summary>
        [NameInMap("LinkIds")]
        [Validation(Required=false)]
        public string LinkIds { get; set; }

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

    }

}
