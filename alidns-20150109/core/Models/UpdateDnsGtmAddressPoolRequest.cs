// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDnsGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// <para>The address pools.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<UpdateDnsGtmAddressPoolRequestAddr> Addr { get; set; }
        public class UpdateDnsGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// <para>The address in the address pool.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public string Addr { get; set; }

            /// <summary>
            /// <para>The information about the source region of the address. The value of the parameter is a string in the JSON format. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>LineCode: the line code of the source region. This parameter is deprecated. Use lineCodes instead.</para>
            /// </description></item>
            /// <item><description><para>lineCodes: the line codes of the source region</para>
            /// </description></item>
            /// <item><description><para>lineCodeRectifyType: the rectification type of the line code. Default value: AUTO. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NO_NEED: no need for rectification</description></item>
            /// <item><description>RECTIFIED: rectified</description></item>
            /// <item><description>AUTO: automatic rectification</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Linecode:default,lineCodes:[&quot;default&quot;],lineCodeRectifyType:&quot;NO_NEED&quot;</para>
            /// </summary>
            [NameInMap("AttributeInfo")]
            [Validation(Required=false)]
            public string AttributeInfo { get; set; }

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
            /// <para>The return mode of the addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SMART: smart return</description></item>
            /// <item><description>ONLINE: always online</description></item>
            /// <item><description>OFFLINE: always offline</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The description of the address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>The ID of the address pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpool1</para>
        /// </summary>
        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        /// <summary>
        /// <para>The language of the values of specific response parameters. Default value: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The load balancing policy of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL_RR: returns all addresses.</description></item>
        /// <item><description>RATIO: returns addresses by weight.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all_rr</para>
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
