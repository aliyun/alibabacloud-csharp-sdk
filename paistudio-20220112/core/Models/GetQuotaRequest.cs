// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetQuotaRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return detailed information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the metadata of nodes that are attached to the resource quota.</para>
        /// </summary>
        [NameInMap("WithNodeMeta")]
        [Validation(Required=false)]
        public bool? WithNodeMeta { get; set; }

    }

}
