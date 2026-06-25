// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of configurations deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deleted")]
        [Validation(Required=false)]
        public int? Deleted { get; set; }

        /// <summary>
        /// <para>A message indicating the operation result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successfully deleted 1 configs</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
