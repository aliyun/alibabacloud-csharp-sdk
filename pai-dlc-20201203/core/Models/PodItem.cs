// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class PodItem : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T15:36:05Z</para>
        /// </summary>
        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:05Z</para>
        /// </summary>
        [NameInMap("GmtStartTime")]
        [Validation(Required=false)]
        public string GmtStartTime { get; set; }

        [NameInMap("HistoryPods")]
        [Validation(Required=false)]
        public List<PodItem> HistoryPods { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.0.1.2</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-mtl37ge7gkvdz-worker-0</para>
        /// </summary>
        [NameInMap("PodId")]
        [Validation(Required=false)]
        public string PodId { get; set; }

        [NameInMap("PodIp")]
        [Validation(Required=false)]
        public string PodIp { get; set; }

        [NameInMap("PodIps")]
        [Validation(Required=false)]
        public List<PodNetworkInterface> PodIps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fe846462-af2c-4521-bd6f-96787a57591d</para>
        /// </summary>
        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Stopped</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubStatus")]
        [Validation(Required=false)]
        public string SubStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Worker</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
