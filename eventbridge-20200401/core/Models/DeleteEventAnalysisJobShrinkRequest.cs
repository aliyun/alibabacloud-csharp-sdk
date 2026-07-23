// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class DeleteEventAnalysisJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The identifier of the source resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Kafka&quot;:{&quot;RegionId&quot;:&quot;cn-hangzhou&quot;,&quot;InstanceId&quot;:&quot;alikafka_post-cn-xxx&quot;,&quot;Topic&quot;:&quot;my_topic&quot;}}</para>
        /// </summary>
        [NameInMap("SourceResource")]
        [Validation(Required=false)]
        public string SourceResourceShrink { get; set; }

    }

}
