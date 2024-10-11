// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class CreateCampaignRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;beginTime&quot;:&quot;00:00:00&quot;,&quot;endTime&quot;:&quot;23:00:00&quot; }]</para>
        /// </summary>
        [NameInMap("CallableTime")]
        [Validation(Required=false)]
        public string CallableTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ccc-test/namelist.csv</para>
        /// </summary>
        [NameInMap("CaseFileKey")]
        [Validation(Required=false)]
        public string CaseFileKey { get; set; }

        [NameInMap("CaseList")]
        [Validation(Required=false)]
        public List<CreateCampaignRequestCaseList> CaseList { get; set; }
        public class CreateCampaignRequestCaseList : TeaModel {
            [NameInMap("CustomVariables")]
            [Validation(Required=false)]
            public string CustomVariables { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1888888888</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("ReferenceId")]
            [Validation(Required=false)]
            public string ReferenceId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1f2bc75-422e-43c7-9c9d9d95633a</para>
        /// </summary>
        [NameInMap("ContactFlowId")]
        [Validation(Required=false)]
        public string ContactFlowId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634313600000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ExecutingUntilTimeout")]
        [Validation(Required=false)]
        public bool? ExecutingUntilTimeout { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxAttemptCount")]
        [Validation(Required=false)]
        public long? MaxAttemptCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinAttemptInterval")]
        [Validation(Required=false)]
        public long? MinAttemptInterval { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-campaign</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skillgroup@ccc-test</para>
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        [NameInMap("Simulation")]
        [Validation(Required=false)]
        public bool? Simulation { get; set; }

        [NameInMap("SimulationParameters")]
        [Validation(Required=false)]
        public string SimulationParameters { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634140800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ratio&quot;:1}</para>
        /// </summary>
        [NameInMap("StrategyParameters")]
        [Validation(Required=false)]
        public string StrategyParameters { get; set; }

        /// <summary>
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
