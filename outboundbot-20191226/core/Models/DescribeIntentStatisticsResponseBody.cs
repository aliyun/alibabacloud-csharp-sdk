// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeIntentStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("GlobalIntentNum")]
        [Validation(Required=false)]
        public int? GlobalIntentNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("GlobalIntents")]
        [Validation(Required=false)]
        public List<DescribeIntentStatisticsResponseBodyGlobalIntents> GlobalIntents { get; set; }
        public class DescribeIntentStatisticsResponseBodyGlobalIntents : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0c3f352f-d045-491d-9ce7-11f2d2b7775d</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HitAfterNoAnswer")]
            [Validation(Required=false)]
            public int? HitAfterNoAnswer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("HitNum")]
            [Validation(Required=false)]
            public int? HitNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a4274627-265f-4e14-b2d6-4ee7d4f8593e</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21343425</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public string IntentId { get; set; }

            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GlobalIntent</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0c3f352f-d045-491d-9ce7-11f2d2b7775d</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a4274627-265f-4e14-b2d6-4ee7d4f8593e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IntentsAfterNoAnswer")]
        [Validation(Required=false)]
        public List<DescribeIntentStatisticsResponseBodyIntentsAfterNoAnswer> IntentsAfterNoAnswer { get; set; }
        public class DescribeIntentStatisticsResponseBodyIntentsAfterNoAnswer : TeaModel {
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("HitAfterNoAnswer")]
            [Validation(Required=false)]
            public int? HitAfterNoAnswer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a4274627-265f-4e14-b2d6-4ee7d4f8593e</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public string IntentId { get; set; }

            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ProcessIntentNum")]
        [Validation(Required=false)]
        public int? ProcessIntentNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("ProcessIntents")]
        [Validation(Required=false)]
        public List<DescribeIntentStatisticsResponseBodyProcessIntents> ProcessIntents { get; set; }
        public class DescribeIntentStatisticsResponseBodyProcessIntents : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0c3f352f-d045-491d-9ce7-11f2d2b7775d</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HitAfterNoAnswer")]
            [Validation(Required=false)]
            public int? HitAfterNoAnswer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("HitNum")]
            [Validation(Required=false)]
            public int? HitNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a4274627-265f-4e14-b2d6-4ee7d4f8593e</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12343</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public string IntentId { get; set; }

            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            [NameInMap("RateDisplay")]
            [Validation(Required=false)]
            public string RateDisplay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ProcessIntent</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
