// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StartJobWithParamsRequest : TeaModel {
        /// <summary>
        /// <para>The parameter that is used to start the job.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public JobStartParameters Body { get; set; }

    }

}
