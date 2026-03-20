// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceInstanceTokenRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>WorkBench</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>worker0</para>
        /// </summary>
        [NameInMap("WorkerName")]
        [Validation(Required=false)]
        public string WorkerName { get; set; }

    }

}
