// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetDeploymentsByNameRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to exclude job summary information, such as jobName and status, from the response. Set this to true to return only the JobId and improve performance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ignoreJobSummary")]
        [Validation(Required=false)]
        public bool? IgnoreJobSummary { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude resource configuration information, such as parallelism and the number of CUs, to reduce the response size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ignoreResourceSetting")]
        [Validation(Required=false)]
        public bool? IgnoreResourceSetting { get; set; }

    }

}
