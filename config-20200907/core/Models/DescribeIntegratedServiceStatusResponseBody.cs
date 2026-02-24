// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DescribeIntegratedServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The event type for cross-account integration. The supported event type is:</para>
        /// <list type="bullet">
        /// <item><description>NonCompliantNotification: non-compliance events.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NonCompliantNotification</para>
        /// </summary>
        [NameInMap("AggregatorDeliveryDataType")]
        [Validation(Required=false)]
        public string AggregatorDeliveryDataType { get; set; }

        /// <summary>
        /// <para>The enabling status of the integrated service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2E265A38-84D9-5083-A333-B33A2B46D139</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
