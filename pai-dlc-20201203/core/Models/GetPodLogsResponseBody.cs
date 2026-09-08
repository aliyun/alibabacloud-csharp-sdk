// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetPodLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The container information that may be associated with the node.</para>
        /// </summary>
        [NameInMap("ContainerInfo")]
        [Validation(Required=false)]
        public ContainerInfo ContainerInfo { get; set; }

        /// <summary>
        /// <para>The containers used to filter logs. Separate multiple container names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>pytorch,aimaster-worker</para>
        /// </summary>
        [NameInMap("Containers")]
        [Validation(Required=false)]
        public string Containers { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-******</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The log list.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<string> Logs { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-****-chief-0</para>
        /// </summary>
        [NameInMap("PodId")]
        [Validation(Required=false)]
        public string PodId { get; set; }

        /// <summary>
        /// <para>The instance UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94a7cc7c-0033-48b5-85bd-71c63592c268</para>
        /// </summary>
        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

        /// <summary>
        /// <para>The request ID for this call, used for diagnostics and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
