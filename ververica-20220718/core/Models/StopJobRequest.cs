// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StopJobRequest : TeaModel {
        /// <summary>
        /// <para>The parameters to stop the job instance.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public StopJobRequestBody Body { get; set; }

    }

}
