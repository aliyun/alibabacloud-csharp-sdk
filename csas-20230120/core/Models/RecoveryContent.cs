// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class RecoveryContent : TeaModel {
        [NameInMap("AuthReportInterval")]
        [Validation(Required=false)]
        public AuthReportInterval AuthReportInterval { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecoveryActions")]
        [Validation(Required=false)]
        public List<string> RecoveryActions { get; set; }

    }

}
