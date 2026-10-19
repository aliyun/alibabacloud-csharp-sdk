// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class TransformInstanceChargeTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The expiration time of the instance.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the billing method of the instance is changed from pay-as-you-go to subscription.</para>
        /// </remarks>
        /// <para>The time is displayed in the YYYY-MM-DDTHH:mm:ssZ format in UTC.</para>
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
