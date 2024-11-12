// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class GetMetadataAmountResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetadataAmountResponseBodyData Data { get; set; }
        public class GetMetadataAmountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of created exchanges on the ApsaraMQ for RabbitMQ instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("CurrentExchanges")]
            [Validation(Required=false)]
            public int? CurrentExchanges { get; set; }

            /// <summary>
            /// <para>The number of created queues on the ApsaraMQ for RabbitMQ instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentQueues")]
            [Validation(Required=false)]
            public int? CurrentQueues { get; set; }

            /// <summary>
            /// <para>The number of created vhosts on the ApsaraMQ for RabbitMQ instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentVirtualHosts")]
            [Validation(Required=false)]
            public int? CurrentVirtualHosts { get; set; }

            /// <summary>
            /// <para>The maximum number of exchanges that can be created on the ApsaraMQ for RabbitMQ instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxExchanges")]
            [Validation(Required=false)]
            public int? MaxExchanges { get; set; }

            /// <summary>
            /// <para>The maximum number of queues that can be created on the ApsaraMQ for RabbitMQ instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxQueues")]
            [Validation(Required=false)]
            public int? MaxQueues { get; set; }

            /// <summary>
            /// <para>The maximum number of vhosts that can be created on the ApsaraMQ for RabbitMQ instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxVirtualHosts")]
            [Validation(Required=false)]
            public int? MaxVirtualHosts { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B75ACF23-2BEB-44AC-A0B6-AE14EDCA***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
