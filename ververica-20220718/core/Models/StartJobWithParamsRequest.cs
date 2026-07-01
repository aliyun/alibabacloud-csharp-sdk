// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StartJobWithParamsRequest : TeaModel {
        /// <summary>
        /// <para>Parameters to start the job instance.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public JobStartParameters Body { get; set; }

    }

}
