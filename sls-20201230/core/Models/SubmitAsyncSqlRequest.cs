// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class SubmitAsyncSqlRequest : TeaModel {
        /// <summary>
        /// <para>The format of the response parameters. The value is \<c>protobuf\\</c>.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public SubmitAsyncSqlParams Body { get; set; }

    }

}
