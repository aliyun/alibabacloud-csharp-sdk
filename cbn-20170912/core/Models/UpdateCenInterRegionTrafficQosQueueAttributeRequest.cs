// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UpdateCenInterRegionTrafficQosQueueAttributeRequest : TeaModel {
        /// <summary>
        /// <para>按带宽绝对值模式分配时，当前队列可使用的跨地域带宽的绝对值，单位Mbps。</para>
        /// <para>输入数字即可，无需输入单位。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The differentiated services code point (DSCP) value used to match packets in the queue.</para>
        /// </summary>
        [NameInMap("Dscps")]
        [Validation(Required=false)]
        public List<int?> Dscps { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The new description of the queue.</para>
        /// <para>The description must be 1 to 256 characters in length, and cannot start with http:// or https://. You can also leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("QosQueueDescription")]
        [Validation(Required=false)]
        public string QosQueueDescription { get; set; }

        /// <summary>
        /// <para>The queue ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-queue-nv2vfzqkewhk4t****</para>
        /// </summary>
        [NameInMap("QosQueueId")]
        [Validation(Required=false)]
        public string QosQueueId { get; set; }

        /// <summary>
        /// <para>The new name of the queue.</para>
        /// <para>The name must be 1 to 128 characters in length, and cannot start with http:// or https://. You can also leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("QosQueueName")]
        [Validation(Required=false)]
        public string QosQueueName { get; set; }

        /// <summary>
        /// <para>The percentage of the inter-region bandwidth that can be used by the queue.</para>
        /// <para>Enter a number. You do not need to enter a percent sign (%).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RemainBandwidthPercent")]
        [Validation(Required=false)]
        public string RemainBandwidthPercent { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
