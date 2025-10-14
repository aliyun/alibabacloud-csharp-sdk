// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeRplInspectionTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeRplInspectionTaskResponseBodyData Data { get; set; }
        public class DescribeRplInspectionTaskResponseBodyData : TeaModel {
            [NameInMap("InspectionTaskList")]
            [Validation(Required=false)]
            public List<DescribeRplInspectionTaskResponseBodyDataInspectionTaskList> InspectionTaskList { get; set; }
            public class DescribeRplInspectionTaskResponseBodyDataInspectionTaskList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-09-25T02:36:20.000+0000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>For database: wms ,Found SIMPLE sequences in 1.0. PolarDB-X 2.0 does not support SIMPLE sequence any more， please use show sequence to check them.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10142</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>slinktaskid。</para>
                /// 
                /// <b>Example:</b>
                /// <para>etx-hzrez23btmb6aq</para>
                /// </summary>
                [NameInMap("SlinkTaskId")]
                [Validation(Required=false)]
                public string SlinkTaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CONNECTIVITY</para>
                /// </summary>
                [NameInMap("Stage")]
                [Validation(Required=false)]
                public string Stage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SUCCEEDED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-09-23T03:25:21.000+0000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PRE_CHECK</para>
            /// </summary>
            [NameInMap("SlinkStage")]
            [Validation(Required=false)]
            public string SlinkStage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
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
