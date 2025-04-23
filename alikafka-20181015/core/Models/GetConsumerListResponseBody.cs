// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20181015.Models
{
    public class GetConsumerListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ConsumerList")]
        [Validation(Required=false)]
        public GetConsumerListResponseBodyConsumerList ConsumerList { get; set; }
        public class GetConsumerListResponseBodyConsumerList : TeaModel {
            [NameInMap("ConsumerVO")]
            [Validation(Required=false)]
            public List<GetConsumerListResponseBodyConsumerListConsumerVO> ConsumerVO { get; set; }
            public class GetConsumerListResponseBodyConsumerListConsumerVO : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CID_c34a6f44915f80d70cb42c4b14ee40c3_4</para>
                /// </summary>
                [NameInMap("ConsumerId")]
                [Validation(Required=false)]
                public string ConsumerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alikafka_post-cn-v0h18sav0001</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>808F042B-CB9A-4FBC-9009-00E7DDB6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
