// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenInterRegionTrafficQosQueueResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-queue-irqhi8k5fdyuu5****</para>
        /// </summary>
        [NameInMap("QosQueueId")]
        [Validation(Required=false)]
        public string QosQueueId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>845F66F6-5C27-53A1-9428-B859086237B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
