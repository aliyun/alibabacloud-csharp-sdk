// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ImportAgentJobsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>名称</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2027179f-20b1-4e0b-841b-d86f2bc7ebf7</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MigrateStrategy")]
        [Validation(Required=false)]
        public int? MigrateStrategy { get; set; }

    }

}
