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
        /// <item><description><para>zh-CN: Chinese</para>
        /// </description></item>
        /// <item><description><para>en-US: English</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: en-US.</para>
        /// <remarks>
        /// <para>This parameter has a higher priority than Lang.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the authorized resources belong.</para>
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
        /// <item><description><para><b>zh</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// <remarks>
        /// <para>This parameter has a lower priority than AcceptLanguage.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AUTH: built-in authoritative server</para>
        /// </description></item>
        /// <item><description><para>FWD: forwarding management</para>
        /// </description></item>
        /// <item><description><para>RA: traffic analysis</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUTH</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The IP address of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The type of the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>STANDARD: standard VPC.</para>
        /// </description></item>
        /// <item><description><para>EDS: Elastic Desktop Service (EDS) VPC.</para>
        /// </description></item>
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
