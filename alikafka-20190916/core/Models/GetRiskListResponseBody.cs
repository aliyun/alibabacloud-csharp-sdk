// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetRiskListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRiskListResponseBodyData Data { get; set; }
        public class GetRiskListResponseBodyData : TeaModel {
            [NameInMap("RiskList")]
            [Validation(Required=false)]
            public List<GetRiskListResponseBodyDataRiskList> RiskList { get; set; }
            public class GetRiskListResponseBodyDataRiskList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1702545932000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("GradeType")]
                [Validation(Required=false)]
                public string GradeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Health")]
                [Validation(Required=false)]
                public bool? Health { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alikafka_pre-cn-m7r1tzxxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1683270264</para>
                /// </summary>
                [NameInMap("LastAlarmTime")]
                [Validation(Required=false)]
                public long? LastAlarmTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LevelType")]
                [Validation(Required=false)]
                public long? LevelType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1637719920000</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public long? ModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>inputIo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0123123123xxx</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("RelationList")]
                [Validation(Required=false)]
                public List<string> RelationList { get; set; }

                [NameInMap("ReportTips")]
                [Validation(Required=false)]
                public string ReportTips { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>doc</para>
                /// </summary>
                [NameInMap("ReportType")]
                [Validation(Required=false)]
                public string ReportType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ReportValue")]
                [Validation(Required=false)]
                public string ReportValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>inputIo</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>44</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>06084011-E093-46F3-A51F-4B19A8AD****</para>
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
