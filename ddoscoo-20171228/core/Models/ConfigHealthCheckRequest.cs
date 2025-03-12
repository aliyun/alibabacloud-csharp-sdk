// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class ConfigHealthCheckRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
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
        /// <para>{&quot;Type&quot;:&quot;tcp&quot;,&quot;Timeout&quot;:10,&quot;Port&quot;:80,&quot;Interval&quot;:10,&quot;Up&quot;:10,&quot;Down&quot;:40}&quot;}</para>
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-XXXXXX</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
