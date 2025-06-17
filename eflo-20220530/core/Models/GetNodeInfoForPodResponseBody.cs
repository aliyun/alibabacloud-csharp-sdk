// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetNodeInfoForPodResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the failed permission verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetNodeInfoForPodResponseBodyContent Content { get; set; }
        public class GetNodeInfoForPodResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster-****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>Lingjun Hdeni Network Interface IPV6 address Quota</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("HdeniIpv6SipQuota")]
            [Validation(Required=false)]
            public int? HdeniIpv6SipQuota { get; set; }

            /// <summary>
            /// <para>Lingjun Gaomi network interface controller quota</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("HdeniQuota")]
            [Validation(Required=false)]
            public int? HdeniQuota { get; set; }

            /// <summary>
            /// <para>Lingjun Hdeni Network Interface IPV4 address Quota</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("HdeniSipQuota")]
            [Validation(Required=false)]
            public int? HdeniSipQuota { get; set; }

            /// <summary>
            /// <para>Lingjun Elastic Network Interface IPV6 address Quota</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LeniIpv6SipQuota")]
            [Validation(Required=false)]
            public int? LeniIpv6SipQuota { get; set; }

            /// <summary>
            /// <para>Lingjun Elastic Network Interface quota, including system type</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LeniQuota")]
            [Validation(Required=false)]
            public int? LeniQuota { get; set; }

            /// <summary>
            /// <para>Lingjun Elastic Network Interface Secondary Private IP Quota</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LeniSipQuota")]
            [Validation(Required=false)]
            public int? LeniSipQuota { get; set; }

            /// <summary>
            /// <para>Lingjun network interface controller Secondary Private IP Quota</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LniSipQuota")]
            [Validation(Required=false)]
            public int? LniSipQuota { get; set; }

            /// <summary>
            /// <para>The ID of the node for this operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node-be70****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>List of VSwitches that can apply for IP addresses on this node</para>
            /// </summary>
            [NameInMap("VSwitches")]
            [Validation(Required=false)]
            public List<string> VSwitches { get; set; }

            /// <summary>
            /// <para>The ID of the Virtual Private Cloud to which the current node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-j6ctp4n75306****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>You don\&quot;t have the permission of this operation, action=eflo:GetNodeInfoForPod, arn=acs:eflo:cn-wulanchabu:1111156667137893:networkinterface/*, resourceGroup=null</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C50C9CD-E799-54DA-BA7A-1FAF3DF80857</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
