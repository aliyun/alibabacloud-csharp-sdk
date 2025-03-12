// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class ConfigLayer4RuleAttributeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Slimit&quot;:{&quot;CpsEnable&quot;:1,&quot;MaxconnEnable&quot;:1,&quot;Cps&quot;:1,&quot;Maxconn&quot;:1},&quot;Sla&quot;:{&quot;CpsEnable&quot;:1,&quot;MaxconnEnable&quot;:1,&quot;Cps&quot;:100,&quot;Maxconn&quot;:1000},&quot;PayloadLen&quot;:{&quot;Min&quot;:0,&quot;Max&quot;:6000}}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("ForwardProtocol")]
        [Validation(Required=false)]
        public string ForwardProtocol { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233</para>
        /// </summary>
        [NameInMap("FrontendPort")]
        [Validation(Required=false)]
        public int? FrontendPort { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-XXXXX</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
