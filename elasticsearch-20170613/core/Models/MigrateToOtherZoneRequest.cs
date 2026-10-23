// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class MigrateToOtherZoneRequest : TeaModel {
        /// <summary>
        /// <para>The zone migration configuration, including the source zone, destination zone, and destination vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fromZoneId&quot;:&quot;cn-hangzhou-e&quot;,&quot;toZoneId&quot;:&quot;cn-hangzhou-f&quot;,&quot;toVswitchId&quot;:&quot;vsw-bp16t5hpc689dgkgc****&quot;}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>Specifies whether to precheck the node migration across zones. A value of true indicates that only a precheck is performed and the migration task is not executed. A value of false indicates that the migration task is executed after the precheck succeeds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
