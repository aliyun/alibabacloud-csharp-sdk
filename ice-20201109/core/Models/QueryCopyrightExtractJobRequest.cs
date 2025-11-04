// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryCopyrightExtractJobRequest : TeaModel {
        /// <summary>
        /// <para>The job ID. You can obtain the value of this parameter from the response of the SubmitCopyrightExtractJob operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2288c6ca184c0e47098a5b665e2a12****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
