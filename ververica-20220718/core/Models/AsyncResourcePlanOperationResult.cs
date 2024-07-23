// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class AsyncResourcePlanOperationResult : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;ssgProfiles&quot;:[{&quot;name&quot;:&quot;default&quot;,&quot;cpu&quot;:1.13,&quot;heap&quot;:&quot;1 gb&quot;,&quot;offHeap&quot;:&quot;32 mb&quot;,&quot;managed&quot;:{},&quot;extended&quot;:{}}],&quot;nodes&quot;:[{&quot;id&quot;:1,&quot;type&quot;:&quot;StreamExecTableSourceScan&quot;,&quot;desc&quot;:&quot;Source: datagen_source[78]&quot;,&quot;profile&quot;:{&quot;group&quot;:&quot;default&quot;,&quot;parallelism&quot;:1,&quot;maxParallelism&quot;:32768,&quot;minParallelism&quot;:1}},{&quot;id&quot;:2,&quot;type&quot;:&quot;StreamExecSink&quot;,&quot;desc&quot;:&quot;Sink: blackhole_sink[79]&quot;,&quot;profile&quot;:{&quot;group&quot;:&quot;default&quot;,&quot;parallelism&quot;:1,&quot;maxParallelism&quot;:32768,&quot;minParallelism&quot;:1}}],&quot;edges&quot;:[{&quot;source&quot;:1,&quot;target&quot;:2,&quot;mode&quot;:&quot;PIPELINED&quot;,&quot;strategy&quot;:&quot;FORWARD&quot;}],&quot;vertices&quot;:{&quot;717c7b8afebbfb7137f6f0f99beb2a94&quot;:[1,2]}}</para>
        /// </summary>
        [NameInMap("plan")]
        [Validation(Required=false)]
        public string Plan { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("ticketStatus")]
        [Validation(Required=false)]
        public string TicketStatus { get; set; }

    }

}
