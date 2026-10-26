// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetFeatureConsistencyCheckJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The ID of the feature consistency check configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("FeatureConsistencyCheckJobConfigId")]
        [Validation(Required=false)]
        public string FeatureConsistencyCheckJobConfigId { get; set; }

        /// <summary>
        /// <para>The name of the feature consistency check task configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature_consistency_check_1</para>
        /// </summary>
        [NameInMap("FeatureConsistencyCheckJobConfigName")]
        [Validation(Required=false)]
        public string FeatureConsistencyCheckJobConfigName { get; set; }

        /// <summary>
        /// <para>The end time. The time is in ISO 8601 format and includes a time zone offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtEndTime")]
        [Validation(Required=false)]
        public string GmtEndTime { get; set; }

        /// <summary>
        /// <para>The start time. The time is in ISO 8601 format and includes a time zone offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtStartTime")]
        [Validation(Required=false)]
        public string GmtStartTime { get; set; }

        /// <summary>
        /// <para>The log information.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<string> Logs { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A04CB8C0-E74A-5E83-BC61-64D153574EC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ToRun: Pending.</description></item>
        /// <item><description>Running: Running.</description></item>
        /// <item><description>Success: Succeeded.</description></item>
        /// <item><description>Failure: Failed.</description></item>
        /// <item><description>Terminated: Stopped or canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
