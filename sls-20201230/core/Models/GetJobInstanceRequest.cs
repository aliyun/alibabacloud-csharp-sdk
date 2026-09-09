// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetJobInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The owner of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12312</para>
        /// </summary>
        [NameInMap("callerOwner")]
        [Validation(Required=false)]
        public string CallerOwner { get; set; }

    }

}
