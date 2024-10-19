// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyApiGroupNetworkPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b0162c75d7d34ff48506f1aff878b05e</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The HTTPS security policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTPS1_1_TLS1_0</para>
        /// </summary>
        [NameInMap("HttpsPolicy")]
        [Validation(Required=false)]
        public string HttpsPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the public second-level domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InnerDomainEnable")]
        [Validation(Required=false)]
        public bool? InnerDomainEnable { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the virtual private cloud (VPC) second-level domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InternetEnable")]
        [Validation(Required=false)]
        public bool? InternetEnable { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable IPv6. Valid values: <b>true</b> and <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InternetIPV6Enable")]
        [Validation(Required=false)]
        public bool? InternetIPV6Enable { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the VPC domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TRUE</description></item>
        /// <item><description>FALSE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VpcIntranetEnable")]
        [Validation(Required=false)]
        public bool? VpcIntranetEnable { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the self-calling domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VpcSlbIntranetEnable")]
        [Validation(Required=false)]
        public bool? VpcSlbIntranetEnable { get; set; }

    }

}
