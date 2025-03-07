// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateProgramResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the program.</para>
        /// </summary>
        [NameInMap("Program")]
        [Validation(Required=false)]
        public ChannelAssemblyProgram Program { get; set; }

        /// <summary>
        /// <para><b>Request ID</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-xxxx-xxxxx-xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
