// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class CreateLayer7RuleRequest : TeaModel {
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
        /// <para>ddoscoo-cn-XXXXX</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ProxyRules&quot;:[{&quot;ProxyPort&quot;:443,&quot;RealServers&quot;:[&quot;1.1.1.1:443&quot;]}],&quot;ProxyType&quot;:&quot;https&quot;},{&quot;ProxyRules&quot;:[{&quot;ProxyPort&quot;:80,&quot;RealServers&quot;:[&quot;1.1.1.1:80&quot;]}],&quot;ProxyType&quot;:&quot;http&quot;}]</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

    }

}
