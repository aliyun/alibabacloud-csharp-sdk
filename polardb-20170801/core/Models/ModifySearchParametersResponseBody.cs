// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifySearchParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. A successful response indicates that the parameter modification task has been accepted, but does not indicate that the parameters have taken effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e3a24663-eee5-4009-b635-2e9e8d052e74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
