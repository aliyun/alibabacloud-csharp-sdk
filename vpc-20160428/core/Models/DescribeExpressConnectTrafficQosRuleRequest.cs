// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeExpressConnectTrafficQosRuleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The QoS policy ID returned by the CreateExpressConnectTrafficQos operation.</para>
        /// <remarks>
        /// <para>This parameter is required. If you do not specify this parameter, the service returns IllegalParam.QosId (400).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>qos-2giu0a6vd5x0mv****</para>
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// <para>The QoS queue ID returned by the CreateExpressConnectTrafficQosQueue operation.</para>
        /// <remarks>
        /// <para>This parameter is required. If you do not specify this parameter, the service returns IllegalParam.QueueId (400).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>qos-queue-9nyx2u7n71s2rc****</para>
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        /// <summary>
        /// <para>The region ID of the QoS policy.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The list of QoS rule IDs.</para>
        /// </summary>
        [NameInMap("RuleIdList")]
        [Validation(Required=false)]
        public List<string> RuleIdList { get; set; }

        /// <summary>
        /// <para>The list of QoS rule names.</para>
        /// </summary>
        [NameInMap("RuleNameList")]
        [Validation(Required=false)]
        public List<string> RuleNameList { get; set; }

    }

}
