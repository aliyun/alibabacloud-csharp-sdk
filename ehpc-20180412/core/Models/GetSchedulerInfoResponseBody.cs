// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetSchedulerInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBC2F93D-003A-49C4-850C-B826EECF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The settings of the scheduler.</para>
        /// </summary>
        [NameInMap("SchedInfo")]
        [Validation(Required=false)]
        public List<GetSchedulerInfoResponseBodySchedInfo> SchedInfo { get; set; }
        public class GetSchedulerInfoResponseBodySchedInfo : TeaModel {
            /// <summary>
            /// <para>The detailed settings of the scheduler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AclInfo&quot;:[{&quot;AclEnable&quot;: false,&quot;UntrackUser&quot;: [],&quot;User&quot;: [],&quot;QueueName&quot;: &quot;workq&quot;}],&quot;JobHistory&quot;: &quot;&quot;,&quot;SchedIteration&quot;: &quot;60&quot;,&quot;QueueResource&quot;: [{&quot;UntrackUser&quot;: [],&quot;User&quot;: [],&quot;QueueName&quot;: &quot;workq&quot;}]}</para>
            /// </summary>
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public string Configuration { get; set; }

            /// <summary>
            /// <para>The type of the scheduler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pbs</para>
            /// </summary>
            [NameInMap("SchedName")]
            [Validation(Required=false)]
            public string SchedName { get; set; }

        }

    }

}
