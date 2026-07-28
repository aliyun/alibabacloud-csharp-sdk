// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class DeleteStackRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to synchronously clean up resources managed by the stack. By default, resources are not cleaned up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("cleanResources")]
        [Validation(Required=false)]
        public bool? CleanResources { get; set; }

    }

}
