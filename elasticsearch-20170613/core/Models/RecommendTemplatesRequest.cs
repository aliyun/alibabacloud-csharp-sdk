// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class RecommendTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The scenario-specific templatetype used by the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>general: general-purpose scenario</description></item>
        /// <item><description>analysisVisualization: data analytics scenario</description></item>
        /// <item><description>dbAcceleration: database acceleration scenario</description></item>
        /// <item><description>search: search scenario</description></item>
        /// <item><description>log: log scenario</description></item>
        /// </list>
        /// <remarks>
        /// <para>Commercial model instances support the general-purpose, data analytics, database acceleration, and search scenarios. Advanced Edition instances support only the log scenario.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>general</para>
        /// </summary>
        [NameInMap("usageScenario")]
        [Validation(Required=false)]
        public string UsageScenario { get; set; }

    }

}
