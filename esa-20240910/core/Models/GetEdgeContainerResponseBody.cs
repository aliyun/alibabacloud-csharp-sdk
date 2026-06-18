// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>container_95</para>
        /// </summary>
        [NameInMap("BillingMode")]
        [Validation(Required=false)]
        public string BillingMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>esa-cn-jea67jfbs0x</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9BEB8659-9CDE-5F2C-83E9-50F55277E844</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
