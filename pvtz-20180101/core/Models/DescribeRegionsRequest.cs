// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The supported language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>en-US: English</description></item>
        /// </list>
        /// <para>Default value: en-US.</para>
        /// <remarks>
        /// <para> AcceptLanguage has a higher priority than Lang.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the permissions on the resources are granted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>141339776561****</para>
        /// </summary>
        [NameInMap("AuthorizedUserId")]
        [Validation(Required=false)]
        public long? AuthorizedUserId { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// <remarks>
        /// <para> Lang has a lower priority than AcceptLanguage.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AUTH: the built-in authoritative module</description></item>
        /// <item><description>FWD: the forward module</description></item>
        /// <item><description>RA: the traffic analysis module</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUTH</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The VPC type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>STANDARD: standard VPC</description></item>
        /// <item><description>EDS: Elastic Desktop Service (EDS) workspace VPC</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("VpcType")]
        [Validation(Required=false)]
        public string VpcType { get; set; }

    }

}
