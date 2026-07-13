// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ReplaceCloudGtmAddressPoolAddressRequest : TeaModel {
        /// <summary>
        /// <para>The response language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh-CN</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en-US</b> (Default): English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The unique ID of the address pool to update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool-89618921167339****</para>
        /// </summary>
        [NameInMap("AddressPoolId")]
        [Validation(Required=false)]
        public string AddressPoolId { get; set; }

        /// <summary>
        /// <para>The list of addresses.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<ReplaceCloudGtmAddressPoolAddressRequestAddresses> Addresses { get; set; }
        public class ReplaceCloudGtmAddressPoolAddressRequestAddresses : TeaModel {
            /// <summary>
            /// <para>The unique ID of the address.</para>
            /// <list type="bullet">
            /// <item><description><para>If you specify this parameter, all existing addresses in the address pool are deleted and replaced with the specified addresses.</para>
            /// </description></item>
            /// <item><description><para>If you leave this parameter empty, all existing addresses in the address pool are deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>addr-89636516932803****</para>
            /// </summary>
            [NameInMap("AddressId")]
            [Validation(Required=false)]
            public string AddressId { get; set; }

            /// <summary>
            /// <para>The list of DNS request sources.</para>
            /// </summary>
            [NameInMap("RequestSource")]
            [Validation(Required=false)]
            public List<string> RequestSource { get; set; }

            /// <summary>
            /// <para>The serial number, which determines the priority of the address. A smaller number indicates a higher priority. This setting applies to the updated addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public int? SerialNumber { get; set; }

            /// <summary>
            /// <para>The weight of the address. Valid values: 1 to 100. You can set a different weight for each address. DNS queries are then resolved based on the weight ratio. This setting applies to the updated addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WeightValue")]
            [Validation(Required=false)]
            public int? WeightValue { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Ensure the client token is unique for each request. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
