// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class TransformInstanceChargeTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the instance expires.</para>
        /// <remarks>
        /// <para> A value is returned for this parameter only if the instance was changed from pay-as-you-go to subscription.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-13T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20881824000****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82C791FB-8979-489E-853D-706D7743****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
