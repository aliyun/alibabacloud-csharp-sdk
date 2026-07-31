// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListSparkAppsRequest : TeaModel {
        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The ID of the Data Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The filter conditions defined as a JSON-formatted string. The following valid KEY values and their meanings are supported in the JSON string:</para>
        /// <list type="bullet">
        /// <item><description>SubmittedTimeRange: the start time.</description></item>
        /// <item><description>TerminatedTimeRange: the end time.</description></item>
        /// <item><description>AppStates: the status of the Spark job.</description></item>
        /// <item><description>AppId: the ID of the Spark job.</description></item>
        /// <item><description>AppNameRegex: the regular expression for the name of the Spark job.</description></item>
        /// <item><description>Tag: the tag information.</description></item>
        /// <item><description>ResourceGroupName: the name of the resource group.</description></item>
        /// </list>
        /// <para>For the start time and end time filter conditions, specify the range by using the following substructure:</para>
        /// <list type="bullet">
        /// <item><description>Min: the lower bound of the time range. A value of null indicates no limit.</description></item>
        /// <item><description>Max: the upper bound of the time range. A value of null indicates no limit.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;SubmittedTimeRang&quot;: {
        ///     &quot;Max&quot;: 10000,
        ///     &quot;Min&quot;: 0
        ///   },
        ///   &quot;TerminatedTimeRange&quot;: {
        ///     &quot;Max&quot;: 10000,
        ///     &quot;Min&quot;: 0
        ///   },
        ///   &quot;AppStates&quot;: [&quot;STARTING&quot;],
        ///   &quot;AppId&quot;: &quot;adc&quot;,
        ///   &quot;AppNameRegex&quot;: &quot;cde&quot;,
        ///   &quot;AttemptId&quot;: &quot;abc-001&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer. Default value: <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>10</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the job resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_instance</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

    }

}
