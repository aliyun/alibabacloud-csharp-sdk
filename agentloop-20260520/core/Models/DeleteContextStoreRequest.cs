// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class DeleteContextStoreRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to simultaneously delete the memory output dataset (memory type). Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("deleteOutputDataset")]
        [Validation(Required=false)]
        public bool? DeleteOutputDataset { get; set; }

    }

}
