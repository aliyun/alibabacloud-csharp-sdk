// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeDialogueNodeStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f06f7c9f-2895-4b30-a8c2-6ecccb9c9f89</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("HangUpDialogueNodes")]
        [Validation(Required=false)]
        public List<DescribeDialogueNodeStatisticsResponseBodyHangUpDialogueNodes> HangUpDialogueNodes { get; set; }
        public class DescribeDialogueNodeStatisticsResponseBodyHangUpDialogueNodes : TeaModel {
            [NameInMap("HangUpNum")]
            [Validation(Required=false)]
            public int? HangUpNum { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("RateDisplay")]
            [Validation(Required=false)]
            public string RateDisplay { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e5035654-1745-484a-8c5b-165f7c7bcd79</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("NoAnswerDialogueNodes")]
        [Validation(Required=false)]
        public List<DescribeDialogueNodeStatisticsResponseBodyNoAnswerDialogueNodes> NoAnswerDialogueNodes { get; set; }
        public class DescribeDialogueNodeStatisticsResponseBodyNoAnswerDialogueNodes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>f06f7c9f-2895-4b30-a8c2-6ecccb9c9f89</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HangUpNum")]
            [Validation(Required=false)]
            public int? HangUpNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("HitNum")]
            [Validation(Required=false)]
            public int? HitNum { get; set; }

            /// <summary>
            /// <para>id</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e5035654-1745-484a-8c5b-165f7c7bcd79</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NoAnswerNum")]
            [Validation(Required=false)]
            public int? NoAnswerNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e5035654-1745-484a-8c5b-165f7c7bcd79</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("TotalCompleted")]
        [Validation(Required=false)]
        public int? TotalCompleted { get; set; }

    }

}
