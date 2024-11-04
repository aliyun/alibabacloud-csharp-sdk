// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteVirtualResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the operation result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successfully deleted virtual resource eas-vr-npovr28onap1xxxxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
