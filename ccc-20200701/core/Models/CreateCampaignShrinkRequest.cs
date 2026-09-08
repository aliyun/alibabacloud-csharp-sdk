// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class CreateCampaignShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The callable time window for the predictive outbound dialing activity, formatted as a JSON object containing two properties: beginTime and endTime. Example: [{&quot;beginTime&quot;:&quot;00:00:00&quot;,&quot;endTime&quot;:&quot;23:00:00&quot;}].</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;beginTime&quot;:&quot;00:00:00&quot;,&quot;endTime&quot;:&quot;23:00:00&quot; }]</para>
        /// </summary>
        [NameInMap("CallableTime")]
        [Validation(Required=false)]
        public string CallableTime { get; set; }

        /// <summary>
        /// <para>Predictive outbound dialing contact file, specified as the key of an OSS object. Obtain this key by calling the GetCaseFileUploadUrl API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test/namelist.csv</para>
        /// </summary>
        [NameInMap("CaseFileKey")]
        [Validation(Required=false)]
        public string CaseFileKey { get; set; }

        /// <summary>
        /// <para>List of predictive outbound dialing contacts. This parameter cannot be used together with CaseFileKey (import from file). You must choose either file import or list import.</para>
        /// </summary>
        [NameInMap("CaseList")]
        [Validation(Required=false)]
        public string CaseListShrink { get; set; }

        /// <summary>
        /// <para>The contact flow ID associated with the predictive outbound dialing activity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1f2bc75-422e-43c7-9c9d9d95633a</para>
        /// </summary>
        [NameInMap("ContactFlowId")]
        [Validation(Required=false)]
        public string ContactFlowId { get; set; }

        /// <summary>
        /// <para>The end time of the predictive outbound calling activity, formatted as a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634313600000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Whether to keep the activity in the executing state until it expires. The default value is false. If false, the activity automatically transitions to the completed state after all contacts have been called. If true, the activity remains in the executing state even after all contacts have been called, allowing you to append additional contacts and continue dialing until the activity expires or is manually stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExecutingUntilTimeout")]
        [Validation(Required=false)]
        public bool? ExecutingUntilTimeout { get; set; }

        /// <summary>
        /// <para>Flash SMS parameters</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;applicationId&quot;:&quot;08e6b63a-<b><b>-</b></b>-****-689a288cdbb5&quot;,&quot;templateId&quot;:&quot;325&quot;}</para>
        /// </summary>
        [NameInMap("FlashSmsParameters")]
        [Validation(Required=false)]
        public string FlashSmsParameters { get; set; }

        /// <summary>
        /// <para>Phone number collection ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0d368091-2c70-4d26-979a-6997ddc9c34f</para>
        /// </summary>
        [NameInMap("InstGroupId")]
        [Validation(Required=false)]
        public string InstGroupId { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of attempts for the predictive outbound calling activity. This specifies how many times a number can be redialed if the initial call fails.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxAttemptCount")]
        [Validation(Required=false)]
        public long? MaxAttemptCount { get; set; }

        /// <summary>
        /// <para>The minimum redial interval for the predictive outbound calling activity, which specifies the minimum time interval between redial attempts after a failed call, in minutes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinAttemptInterval")]
        [Validation(Required=false)]
        public long? MinAttemptInterval { get; set; }

        /// <summary>
        /// <para>Name of the predictive outbound dialing activity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-campaign</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>List of caller numbers</para>
        /// </summary>
        [NameInMap("NumberList")]
        [Validation(Required=false)]
        public string NumberListShrink { get; set; }

        /// <summary>
        /// <para>The skill group ID associated with the predictive outbound dialing activity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skillgroup@ccc-test</para>
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        /// <summary>
        /// <para>Indicates whether this is a simulation activity used for testing. Regular customers do not need to concern themselves with this.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Simulation")]
        [Validation(Required=false)]
        public bool? Simulation { get; set; }

        /// <summary>
        /// <para>Simulation parameters used for testing. Regular customers do not need to concern themselves with this.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("SimulationParameters")]
        [Validation(Required=false)]
        public string SimulationParameters { get; set; }

        /// <summary>
        /// <para>The start time of the predictive outbound dialing activity, in Unix timestamp format with millisecond precision.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634140800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Strategy parameters for the predictive outbound dialing activity. For PID strategy, an example format is: {&quot;abandonRate&quot;:&quot;5&quot;,&quot;historicalConnectedRate&quot;:&quot;35&quot;}. For PACING strategy, an example format is: {&quot;ratio&quot;:1}. abandonRate represents the desired abandonment rate, historicalConnectedRate represents the historical reference connection rate, and ratio represents the fixed dialing ratio.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ratio&quot;:1}</para>
        /// </summary>
        [NameInMap("StrategyParameters")]
        [Validation(Required=false)]
        public string StrategyParameters { get; set; }

        /// <summary>
        /// <para>The strategy pattern for the predictive outbound calling activity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PACING</para>
        /// </summary>
        [NameInMap("StrategyType")]
        [Validation(Required=false)]
        public string StrategyType { get; set; }

    }

}
