// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateInstanceSyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ips_server</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D19D8F70-D64B-5A95-905A-6073BF4A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
