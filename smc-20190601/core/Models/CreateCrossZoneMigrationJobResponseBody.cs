// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class CreateCrossZoneMigrationJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the migration job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>j-bp17bclvg344jlyt****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A9DBD2F8-DE5A-5844-BA6F-957A996CBD78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
