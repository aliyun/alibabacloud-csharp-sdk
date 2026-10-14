// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEipInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The peak bandwidth of the EIP. Default value: 5. Valid values: 5 to 10000. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// <para>Ensures the idempotence of the request to prevent duplicate operations caused by multiple retries.</para>
        /// <list type="bullet">
        /// <item><description><para>Generate a parameter value from your client and make sure that the value is unique among different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </description></item>
        /// <item><description><para>If you use a ClientToken that has been used before and the other request parameters remain unchanged, the client receives the same result as the first submission, without affecting the server-side state.</para>
        /// </description></item>
        /// <item><description><para>You can retry when the API times out or returns the PROCESSING error code. Idempotence is effective in this case. If the response returns an HTTP 200 status code, the retry returns the same result as the previous call without affecting the server-side state. If the response returns an HTTP 4xx status code and the error code is not PROCESSING, idempotence is not effective.</para>
        /// </description></item>
        /// <item><description><para>The ClientToken is valid for 10 minutes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>26C28756-2586-17AF-B802-0DC50D8FDEBB</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the Edge Node Service (ENS) edge zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-suzhou-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>Billable methods of the EIP. Currently, only <b>PostPaid</b> (pay-as-you-go billing method) is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance ID of the EIP.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Billable methods of the EIP. Currently, only <b>95BandwidthByMonth</b> (monthly 95th percentile bandwidth billing) is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95BandwidthByMonth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The IP address.</para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para>The Internet service provider (ISP). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cmcc</b>: China Mobile.</description></item>
        /// <item><description><b>unicom</b>: China Unicom.</description></item>
        /// <item><description><b>telecom</b>: China Telecom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cmcc</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The name of the EIP instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EIP1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The resource tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateEipInstanceRequestTag> Tag { get; set; }
        public class CreateEipInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. Valid values of N: <b>1</b> to <b>20</b>.</para>
            /// <list type="bullet">
            /// <item><description>Cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</description></item>
            /// <item><description>Can be up to 64 characters in length.</description></item>
            /// <item><description>Cannot be an empty string.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>team</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
