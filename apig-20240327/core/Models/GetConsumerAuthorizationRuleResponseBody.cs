// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetConsumerAuthorizationRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The API information.</para>
        /// </summary>
        [NameInMap("apiInfo")]
        [Validation(Required=false)]
        public HttpApiApiInfo ApiInfo { get; set; }

        /// <summary>
        /// <para>Filters the list of operations by a specific consumer authorization rule ID. Only authorized operations are returned in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>car-ctgdn8em1hko5krqq03g</para>
        /// </summary>
        [NameInMap("consumerAuthorizationRuleId")]
        [Validation(Required=false)]
        public string ConsumerAuthorizationRuleId { get; set; }

        /// <summary>
        /// <para>The consumer ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-ctgdn2um1hkossul8gvg</para>
        /// </summary>
        [NameInMap("consumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// <para>The creation timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750852089975</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The publishing status of the API in the current environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("deployStatus")]
        [Validation(Required=false)]
        public string DeployStatus { get; set; }

        /// <summary>
        /// <para>The environment information.</para>
        /// </summary>
        [NameInMap("environmentInfo")]
        [Validation(Required=false)]
        public EnvironmentInfo EnvironmentInfo { get; set; }

        /// <summary>
        /// <para>The expiry mode. Valid values: LongTerm and ShortTerm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LongTerm</para>
        /// </summary>
        [NameInMap("expireMode")]
        [Validation(Required=false)]
        public string ExpireMode { get; set; }

        /// <summary>
        /// <para>The rule status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("expireStatus")]
        [Validation(Required=false)]
        public string ExpireStatus { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750852089975</para>
        /// </summary>
        [NameInMap("expireTimestamp")]
        [Validation(Required=false)]
        public long? ExpireTimestamp { get; set; }

        /// <summary>
        /// <para>The gateway information.</para>
        /// </summary>
        [NameInMap("gatewayInfo")]
        [Validation(Required=false)]
        public GatewayInfo GatewayInfo { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53102737-1E4E-5A8B-8E0A-4184B0959B84</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The update timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750852089975</para>
        /// </summary>
        [NameInMap("updateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
