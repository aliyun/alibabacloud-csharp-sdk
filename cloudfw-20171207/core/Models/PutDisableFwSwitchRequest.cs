// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class PutDisableFwSwitchRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The IP addresses.</para>
        /// <remarks>
        /// <para> You must specify at least one of the IpaddrList, RegionList, and ResourceTypeList parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;192.0.XX.XX&quot;,&quot;192.0.XX.XX&quot;]</para>
        /// </summary>
        [NameInMap("IpaddrList")]
        [Validation(Required=false)]
        public List<string> IpaddrList { get; set; }

        /// <summary>
        /// <para>The language of the content within the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The regions.</para>
        /// <remarks>
        /// <para> You must specify at least one of the IpaddrList, RegionList, and ResourceTypeList parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;,&quot;cn-shanghai&quot;]</para>
        /// </summary>
        [NameInMap("RegionList")]
        [Validation(Required=false)]
        public List<string> RegionList { get; set; }

        /// <summary>
        /// <para>The types of the assets.</para>
        /// <remarks>
        /// <para>You must specify at least one of the IpaddrList, RegionList, and ResourceTypeList parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;EcsPublicIp&quot;,&quot;NatEip&quot;]</para>
        /// </summary>
        [NameInMap("ResourceTypeList")]
        [Validation(Required=false)]
        public List<string> ResourceTypeList { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

    }

}
