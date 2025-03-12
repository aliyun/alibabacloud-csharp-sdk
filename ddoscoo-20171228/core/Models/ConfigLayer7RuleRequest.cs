// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class ConfigLayer7RuleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-XXXXXX</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;ProxyPorts&quot;:[80,8080],&quot;ProxyType&quot;:&quot;http&quot;},{&quot;ProxyPorts&quot;:[443],&quot;ProxyType&quot;:&quot;https&quot;}]rts\&quot;:[443],\&quot;ProxyType\&quot;:\&quot;https\&quot;}]</para>
        /// </summary>
        [NameInMap("ProxyTypeList")]
        [Validation(Required=false)]
        public string ProxyTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;ProxyPorts&quot;:[80,8080],&quot;ProxyType&quot;:&quot;http&quot;},{&quot;ProxyPorts&quot;:[443],&quot;ProxyType&quot;:&quot;https&quot;}]rts\&quot;:[443],\&quot;ProxyType\&quot;:\&quot;https\&quot;}]</para>
        /// </summary>
        [NameInMap("ProxyTypes")]
        [Validation(Required=false)]
        public List<string> ProxyTypes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("RealServers")]
        [Validation(Required=false)]
        public List<string> RealServers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RsType")]
        [Validation(Required=false)]
        public int? RsType { get; set; }

    }

}
