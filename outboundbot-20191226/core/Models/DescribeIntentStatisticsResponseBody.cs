// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeIntentStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>API status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Total count of global intents</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("GlobalIntentNum")]
        [Validation(Required=false)]
        public int? GlobalIntentNum { get; set; }

        /// <summary>
        /// <para>Global intent array</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("GlobalIntents")]
        [Validation(Required=false)]
        public List<DescribeIntentStatisticsResponseBodyGlobalIntents> GlobalIntents { get; set; }
        public class DescribeIntentStatisticsResponseBodyGlobalIntents : TeaModel {
            /// <summary>
            /// <para>Task group ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>0c3f352f-d045-491d-9ce7-11f2d2b7775d</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>Hit after no acknowledgement</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HitAfterNoAnswer")]
            [Validation(Required=false)]
            public int? HitAfterNoAnswer { get; set; }

            /// <summary>
            /// <para>Hit count</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("HitNum")]
            [Validation(Required=false)]
            public int? HitNum { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>a4274627-265f-4e14-b2d6-4ee7d4f8593e</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Intent ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>21343425</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public string IntentId { get; set; }

            /// <summary>
            /// <para>Intent name</para>
            /// 
            /// <b>Example:</b>
            /// <para>请假意图</para>
            /// </summary>
            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            /// <summary>
            /// <para>Type</para>
            /// <para>GlobalIntent(0): Global intent</para>
            /// <para>ProcessIntent(1): Flow intent</para>
            /// 
            /// <b>Example:</b>
            /// <para>GlobalIntent</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Group ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c3f352f-d045-491d-9ce7-11f2d2b7775d</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>a4274627-265f-4e14-b2d6-4ee7d4f8593e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Rejected intent information list</para>
        /// </summary>
        [NameInMap("IntentsAfterNoAnswer")]
        [Validation(Required=false)]
        public List<DescribeIntentStatisticsResponseBodyIntentsAfterNoAnswer> IntentsAfterNoAnswer { get; set; }
        public class DescribeIntentStatisticsResponseBodyIntentsAfterNoAnswer : TeaModel {
            /// <summary>
            /// <para>Task group ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>b24d321a-2a74-4dd1-a0ba-4ab09cef6652</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>No acknowledgement is received after a hit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HitAfterNoAnswer")]
            [Validation(Required=false)]
            public int? HitAfterNoAnswer { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>a4274627-265f-4e14-b2d6-4ee7d4f8593e</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Intent ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10398032</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public string IntentId { get; set; }

            /// <summary>
            /// <para>Intent name</para>
            /// 
            /// <b>Example:</b>
            /// <para>请假意图</para>
            /// </summary>
            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

        }

        /// <summary>
        /// <para>API message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Total count of flow intents</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ProcessIntentNum")]
        [Validation(Required=false)]
        public int? ProcessIntentNum { get; set; }

        /// <summary>
        /// <para>Intent information list</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("ProcessIntents")]
        [Validation(Required=false)]
        public List<DescribeIntentStatisticsResponseBodyProcessIntents> ProcessIntents { get; set; }
        public class DescribeIntentStatisticsResponseBodyProcessIntents : TeaModel {
            /// <summary>
            /// <para>Task group ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>0c3f352f-d045-491d-9ce7-11f2d2b7775d</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>Hit after no acknowledgement</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HitAfterNoAnswer")]
            [Validation(Required=false)]
            public int? HitAfterNoAnswer { get; set; }

            /// <summary>
            /// <para>Hit count</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("HitNum")]
            [Validation(Required=false)]
            public int? HitNum { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>a4274627-265f-4e14-b2d6-4ee7d4f8593e</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Intent ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>12343</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public string IntentId { get; set; }

            /// <summary>
            /// <para>Intent name</para>
            /// 
            /// <b>Example:</b>
            /// <para>请假意图</para>
            /// </summary>
            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            /// <summary>
            /// <para>Percentage</para>
            /// 
            /// <b>Example:</b>
            /// <para>33.33%</para>
            /// </summary>
            [NameInMap("RateDisplay")]
            [Validation(Required=false)]
            public string RateDisplay { get; set; }

            /// <summary>
            /// <para>Type</para>
            /// <list type="bullet">
            /// <item><description><para>GlobalIntent(0): Global intent</para>
            /// </description></item>
            /// <item><description><para>ProcessIntent(1): Flow intent</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ProcessIntent</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Success</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
