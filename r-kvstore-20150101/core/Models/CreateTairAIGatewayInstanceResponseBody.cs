// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateTairAIGatewayInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of instances that failed to be created in a batch. This parameter is not returned when a single instance is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tg-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceResults")]
        [Validation(Required=false)]
        public CreateTairAIGatewayInstanceResponseBodyInstanceResults InstanceResults { get; set; }
        public class CreateTairAIGatewayInstanceResponseBodyInstanceResults : TeaModel {
            [NameInMap("instanceResults")]
            [Validation(Required=false)]
            public List<CreateTairAIGatewayInstanceResponseBodyInstanceResultsInstanceResults> InstanceResults { get; set; }
            public class CreateTairAIGatewayInstanceResponseBodyInstanceResultsInstanceResults : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. The ID of the virtual node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****-db-0</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20881824000****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D622714-AEDD-4609-9167-F5DDD3D1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of instances successfully created in a batch. This parameter is not returned when a single instance is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// <para>The total number of instances created in a batch. This parameter is not returned when a single instance is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. The ID of the virtual cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vc-16965a9267*****-*****</para>
        /// </summary>
        [NameInMap("VClusterId")]
        [Validation(Required=false)]
        public string VClusterId { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. The instance ID of the VCluster virtual cluster where the VNode resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tk-2ze4bba3c8fe****</para>
        /// </summary>
        [NameInMap("VkName")]
        [Validation(Required=false)]
        public string VkName { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-l</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
