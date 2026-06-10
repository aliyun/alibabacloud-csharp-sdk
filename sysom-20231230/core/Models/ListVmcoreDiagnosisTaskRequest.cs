// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListVmcoreDiagnosisTaskRequest : TeaModel {
        /// <summary>
        /// <para>Indicates jobs from the past days days, up to a maximum of 30 days</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("days")]
        [Validation(Required=false)]
        public long? Days { get; set; }

    }

}
