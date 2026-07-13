// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// <para>The list of addresses in the address pool.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<UpdateGtmAddressPoolRequestAddr> Addr { get; set; }
        public class UpdateGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// <para>The weight of the address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

            /// <summary>
            /// <para>The mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>SMART</b>: Intelligent return</para>
            /// </description></item>
            /// <item><description><para><b>ONLINE</b>: Always online</para>
            /// </description></item>
            /// <item><description><para><b>OFFLINE</b>: Always offline</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SMART</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.XX.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the address pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234abc</para>
        /// </summary>
        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The minimum number of active addresses in the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? MinAvailableAddrNum { get; set; }

        /// <summary>
        /// <para>The name of the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>名称</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IP: IPv4 addresses</para>
        /// </description></item>
        /// <item><description><para>DOMAIN: Domain names</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IP</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
