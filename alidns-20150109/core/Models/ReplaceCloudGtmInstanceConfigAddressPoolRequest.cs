// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ReplaceCloudGtmInstanceConfigAddressPoolRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>en-US (default): English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The address pools.</para>
        /// </summary>
        [NameInMap("AddressPools")]
        [Validation(Required=false)]
        public List<ReplaceCloudGtmInstanceConfigAddressPoolRequestAddressPools> AddressPools { get; set; }
        public class ReplaceCloudGtmInstanceConfigAddressPoolRequestAddressPools : TeaModel {
            /// <summary>
            /// <para>The ID of the address pool. This ID uniquely identifies the address pool.</para>
            /// <list type="bullet">
            /// <item><description>If you specify this parameter, the address pools that are associated with the desired instance are removed and the instance is associated with new address pools.</description></item>
            /// <item><description>If this parameter is left empty, the address pools that are associated with the desired instance are removed and no address pool is associated with the instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pool-89564542105737**12</para>
            /// </summary>
            [NameInMap("AddressPoolId")]
            [Validation(Required=false)]
            public string AddressPoolId { get; set; }

            /// <summary>
            /// <para>The DNS request sources.</para>
            /// </summary>
            [NameInMap("RequestSource")]
            [Validation(Required=false)]
            public List<string> RequestSource { get; set; }

            /// <summary>
            /// <para>The sequence number of the new address pool. The address pool with the smallest sequence number is preferentially returned for DNS requests from any source. The sequence number specifies the priority for returning the address pool. A smaller sequence number specifies a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public int? SerialNumber { get; set; }

            /// <summary>
            /// <para>The weight value of the new address pool. You can set a different weight value for each address pool. This way, address pools are returned based on the weight values for Domain Name System (DNS) requests. A weight value must be an integer that ranges from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WeightValue")]
            [Validation(Required=false)]
            public int? WeightValue { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configuration ID of the access domain name. Two configuration IDs exist when the access domain name is bound to the same GTM instance but an A record and an AAAA record are configured for the access domain name. The configuration ID uniquely identifies a configuration.</para>
        /// <para>You can call the <a href="~~ListCloudGtmInstanceConfigs~~">ListCloudGtmInstanceConfigs</a> operation to query the configuration ID of the access domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Config-000**11</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The ID of the GTM 3.0 instance for which you want to change address pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3hbz**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
