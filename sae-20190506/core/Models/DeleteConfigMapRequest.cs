// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DeleteConfigMapRequest : TeaModel {
        /// <summary>
        /// <para>1</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConfigMapId")]
        [Validation(Required=false)]
        public long? ConfigMapId { get; set; }

    }

}
