// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetTrafficControlTaskRequest : TeaModel {
        /// <summary>
        /// <para>The filter for traffic control targets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("ControlTargetFilter")]
        [Validation(Required=false)]
        public string ControlTargetFilter { get; set; }

        /// <summary>
        /// <para>The environment to which the parameter belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Daily: daily environment</description></item>
        /// <item><description>Pre: staging environment</description></item>
        /// <item><description>Prod: production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-1324***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Latest</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
