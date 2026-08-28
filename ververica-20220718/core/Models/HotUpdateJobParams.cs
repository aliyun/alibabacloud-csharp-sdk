// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class HotUpdateJobParams : TeaModel {
        /// <summary>
        /// <para>The dynamic update of resources.</para>
        /// </summary>
        [NameInMap("rescaleJobParam")]
        [Validation(Required=false)]
        public RescaleJobParam RescaleJobParam { get; set; }

        /// <summary>
        /// <para>The dynamic update of runtime parameters.</para>
        /// </summary>
        [NameInMap("updateJobConfigParam")]
        [Validation(Required=false)]
        public UpdateJobConfigParam UpdateJobConfigParam { get; set; }

    }

}
