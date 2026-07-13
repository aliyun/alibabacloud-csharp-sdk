// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDnsGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// <para>A list of addresses in the address pool.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<UpdateDnsGtmAddressPoolRequestAddr> Addr { get; set; }
        public class UpdateDnsGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// <para>The address.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.XX.XX</para>
            /// </summary>
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public string Addr { get; set; }

            /// <summary>
            /// <para>The source region of the address. This parameter is a JSON string.</para>
            /// <list type="bullet">
            /// <item><description><para>LineCode: The line code of the source region. This parameter is deprecated. Use lineCodes instead.</para>
            /// </description></item>
            /// <item><description><para>lineCodes: A list of line codes for the source regions.</para>
            /// </description></item>
            /// <item><description><para>lineCodeRectifyType: The type of line code rectification. Default value: AUTO. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>NO_NEED: No rectification is required.</para>
            /// </description></item>
            /// <item><description><para>RECTIFIED: The line code is rectified.</para>
            /// </description></item>
            /// <item><description><para>AUTO: The line code is automatically rectified.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Linecode: default
            /// lineCodes： [&quot;default&quot;]
            /// lineCodeRectifyType: AUTO</para>
            /// </summary>
            [NameInMap("AttributeInfo")]
            [Validation(Required=false)]
            public string AttributeInfo { get; set; }

            /// <summary>
            /// <para>The weight.</para>
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
            /// <item><description><para>SMART: Smart return</para>
            /// </description></item>
            /// <item><description><para>ONLINE: Always online</para>
            /// </description></item>
            /// <item><description><para>OFFLINE: Always offline</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SMART</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>The ID of the address pool. For more information, see <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describednsgtminstanceaddresspools">DescribeDnsGtmInstanceAddressPools</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testp******</para>
        /// </summary>
        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        /// <summary>
        /// <para>The language of the response. Default value: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The load balancing policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ALL_RR: Returns all addresses.</para>
        /// </description></item>
        /// <item><description><para>RATIO: Returns addresses by weight.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_RR</para>
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// <para>The name of the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpoolname</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
