// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class DashscopeAsyncTaskFinishEventHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is part of a stress test</para>
        /// </summary>
        [NameInMap("X-Load-Test")]
        [Validation(Required=false)]
        public bool? XLoadTest { get; set; }

    }

}
