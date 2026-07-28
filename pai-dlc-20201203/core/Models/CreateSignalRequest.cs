// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CreateSignalRequest : TeaModel {
        /// <summary>
        /// <para>The signal code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SIGUSR1</para>
        /// </summary>
        [NameInMap("Signal")]
        [Validation(Required=false)]
        public string Signal { get; set; }

        /// <summary>
        /// <para>The signal delivery scope.</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public SignalTarget Target { get; set; }

    }

}
