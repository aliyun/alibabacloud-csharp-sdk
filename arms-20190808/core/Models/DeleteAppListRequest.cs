// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteAppListRequest : TeaModel {
        /// <summary>
        /// <para>The PIDs of the applications monitored by ARMS Application Monitoring.</para>
        /// </summary>
        [NameInMap("Pids")]
        [Validation(Required=false)]
        public List<string> Pids { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
