// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class CheckCreatedByEnabledResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OpenStatus")]
        [Validation(Required=false)]
        public bool? OpenStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>682DD9E1-F530-5D14-A839-A6787FA82B74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
