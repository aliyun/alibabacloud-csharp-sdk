// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bsn20150512.Models
{
    public class ProductBindBsnRequest : TeaModel {
        /// <summary>
        /// <para>456*******163</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("aliuid")]
        [Validation(Required=false)]
        public long? Aliuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("num")]
        [Validation(Required=false)]
        public int? Num { get; set; }

        /// <summary>
        /// <para>41****34</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

    }

}
