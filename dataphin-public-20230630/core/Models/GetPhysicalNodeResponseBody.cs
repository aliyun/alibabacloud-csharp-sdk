// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetPhysicalNodeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NodeInfo")]
        [Validation(Required=false)]
        public GetPhysicalNodeResponseBodyNodeInfo NodeInfo { get; set; }
        public class GetPhysicalNodeResponseBodyNodeInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1717343597000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public GetPhysicalNodeResponseBodyNodeInfoCreator Creator { get; set; }
            public class GetPhysicalNodeResponseBodyNodeInfoCreator : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>101312</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0 0 10 * * *</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DataSourceSchema")]
            [Validation(Required=false)]
            public string DataSourceSchema { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DATA_PROCESS</para>
            /// </summary>
            [NameInMap("From")]
            [Validation(Required=false)]
            public string From { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n_232132</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1717343597000</para>
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public long? LastModifiedTime { get; set; }

            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public GetPhysicalNodeResponseBodyNodeInfoModifier Modifier { get; set; }
            public class GetPhysicalNodeResponseBodyNodeInfoModifier : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>101312</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SHELL</para>
            /// </summary>
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

            [NameInMap("OutputNameList")]
            [Validation(Required=false)]
            public List<string> OutputNameList { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public GetPhysicalNodeResponseBodyNodeInfoOwner Owner { get; set; }
            public class GetPhysicalNodeResponseBodyNodeInfoOwner : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>101312</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MIDDLE</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("ProjectInfo")]
            [Validation(Required=false)]
            public GetPhysicalNodeResponseBodyNodeInfoProjectInfo ProjectInfo { get; set; }
            public class GetPhysicalNodeResponseBodyNodeInfoProjectInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>102132</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;expression&quot;:&quot;any_success&quot;}</para>
            /// </summary>
            [NameInMap("TriggerConfig")]
            [Validation(Required=false)]
            public string TriggerConfig { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
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
