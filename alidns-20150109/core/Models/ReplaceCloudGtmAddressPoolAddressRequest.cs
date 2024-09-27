// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ReplaceCloudGtmAddressPoolAddressRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh-CN</b>: Chinese</description></item>
        /// <item><description><b>en-US (default)</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the address pool for which you want to replace addresses. This ID uniquely identifies the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool-89618921167339**24</para>
        /// </summary>
        [NameInMap("AddressPoolId")]
        [Validation(Required=false)]
        public string AddressPoolId { get; set; }

        /// <summary>
        /// <para>The addresses.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<ReplaceCloudGtmAddressPoolAddressRequestAddresses> Addresses { get; set; }
        public class ReplaceCloudGtmAddressPoolAddressRequestAddresses : TeaModel {
            /// <summary>
            /// <para>The ID of the new address. This ID uniquely identifies the address.</para>
            /// <list type="bullet">
            /// <item><description>If you specify this parameter, the original addresses in the address pool will be deleted and replaced with new addresses.</description></item>
            /// <item><description>If you do not specify this parameter, all addresses in the address pool will be deleted and the address pool will be left empty.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>addr-89636516932803**44</para>
            /// </summary>
            [NameInMap("AddressId")]
            [Validation(Required=false)]
            public string AddressId { get; set; }

            /// <summary>
            /// <para>The DNS request sources.</para>
            /// </summary>
            [NameInMap("RequestSource")]
            [Validation(Required=false)]
            public List<string> RequestSource { get; set; }

            /// <summary>
            /// <para>The sequence number that specifies the priority for returning the new address. A smaller sequence number specifies a higher priority. This setting takes effect for new addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public int? SerialNumber { get; set; }

            /// <summary>
            /// <para>The weight value of the new address. You can set a different weight value for each address. This way, addresses are returned based on the weight values for Domain Name System (DNS) requests. A weight value must be an integer that ranges from 1 to 100. This setting takes effect for new addresses.</para>
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

    }

}
