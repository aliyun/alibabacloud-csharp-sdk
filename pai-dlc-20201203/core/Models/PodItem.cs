// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class PodItem : TeaModel {
        /// <summary>
        /// <para>The time when the pod was created (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the pod was completed (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T15:36:05Z</para>
        /// </summary>
        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        /// <summary>
        /// <para>The time when the pod was started (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:05Z</para>
        /// </summary>
        [NameInMap("GmtStartTime")]
        [Validation(Required=false)]
        public string GmtStartTime { get; set; }

        /// <summary>
        /// <para>The historical pods.</para>
        /// </summary>
        [NameInMap("HistoryPods")]
        [Validation(Required=false)]
        public List<PodItem> HistoryPods { get; set; }

        /// <summary>
        /// <para>Pod Ip</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.1.2</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The name of the compute node where the pod is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-a</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>Pod Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-mtl37ge7gkvdz-worker-0</para>
        /// </summary>
        [NameInMap("PodId")]
        [Validation(Required=false)]
        public string PodId { get; set; }

        /// <summary>
        /// <para>The IP address of the pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.1.2</para>
        /// </summary>
        [NameInMap("PodIp")]
        [Validation(Required=false)]
        public string PodIp { get; set; }

        /// <summary>
        /// <para>The IP addresses of the pod. For Lingjun AI Computing Service: user VPC net0, management VPC net, and pod-to-pod communication ethx. For general-purpose computing: user VPC eth1 with dedicated gateway default route, management VPC eth0 with public gateway default route, and pod-to-pod communication net eRDMA.</para>
        /// </summary>
        [NameInMap("PodIps")]
        [Validation(Required=false)]
        public List<PodNetworkInterface> PodIps { get; set; }

        /// <summary>
        /// <para>Pod Uid</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe846462-af2c-4521-bd6f-96787a57591d</para>
        /// </summary>
        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

        /// <summary>
        /// <para>The status of the pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Stopped</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The substatus of the pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Restarting</para>
        /// </summary>
        [NameInMap("SubStatus")]
        [Validation(Required=false)]
        public string SubStatus { get; set; }

        /// <summary>
        /// <para>The type of the pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Worker</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The list of supported profiling types, separated by commas, such as sysom. An empty string indicates that profiling is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sysom</para>
        /// </summary>
        [NameInMap("supportedProfilingTypes")]
        [Validation(Required=false)]
        public string SupportedProfilingTypes { get; set; }

    }

}
