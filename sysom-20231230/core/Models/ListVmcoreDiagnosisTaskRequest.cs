// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListVmcoreDiagnosisTaskRequest : TeaModel {
        /// <summary>
        /// <para>The number of past days for which to query tasks. Maximum value: 30.</para>
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
