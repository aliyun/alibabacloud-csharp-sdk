// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs_workbench20220220.Models
{
    public class ListInstanceRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidParamter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Parameter is null or invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Root")]
        [Validation(Required=false)]
        public ListInstanceRecordsResponseBodyRoot Root { get; set; }
        public class ListInstanceRecordsResponseBodyRoot : TeaModel {
            [NameInMap("RecordList")]
            [Validation(Required=false)]
            public List<ListInstanceRecordsResponseBodyRootRecordList> RecordList { get; set; }
            public class ListInstanceRecordsResponseBodyRootRecordList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-11-16T02:59:39Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-04-10T12:41:28Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-xxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://ecs-workbench.aliyun.com/view/instance/record/replay/abc">https://ecs-workbench.aliyun.com/view/instance/record/replay/abc</a></para>
                /// </summary>
                [NameInMap("InstanceRecordUrl")]
                [Validation(Required=false)]
                public string InstanceRecordUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("RecordDurationMillis")]
                [Validation(Required=false)]
                public long? RecordDurationMillis { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("TerminalSessionToken")]
                [Validation(Required=false)]
                public string TerminalSessionToken { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
