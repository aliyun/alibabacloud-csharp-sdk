// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetJobResponseBody : TeaModel {
        [NameInMap("JobInfo")]
        [Validation(Required=false)]
        public GetJobResponseBodyJobInfo JobInfo { get; set; }
        public class GetJobResponseBodyJobInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ArrayJobId")]
            [Validation(Required=false)]
            public string ArrayJobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ArrayJobSubId")]
            [Validation(Required=false)]
            public string ArrayJobSubId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1-5:2</para>
            /// </summary>
            [NameInMap("ArrayRequest")]
            [Validation(Required=false)]
            public string ArrayRequest { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/home/huangsf/ehpc/job_meta.pbs</para>
            /// </summary>
            [NameInMap("CommandLine")]
            [Validation(Required=false)]
            public string CommandLine { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-16T10:52:48</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/home/xxx/STDIN.e1</para>
            /// </summary>
            [NameInMap("ErrorLog")]
            [Validation(Required=false)]
            public string ErrorLog { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.manager</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testJob</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workq</para>
            /// </summary>
            [NameInMap("JobQueue")]
            [Validation(Required=false)]
            public string JobQueue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-16T10:52:48</para>
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public string LastModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>compute000</para>
            /// </summary>
            [NameInMap("NodeList")]
            [Validation(Required=false)]
            public string NodeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/home/xxx/STDIN.o1</para>
            /// </summary>
            [NameInMap("OutputLog")]
            [Validation(Required=false)]
            public string OutputLog { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("Resources")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobInfoResources Resources { get; set; }
            public class GetJobResponseBodyJobInfoResources : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public string Cores { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Gpus")]
                [Validation(Required=false)]
                public string Gpus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1gb</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public string Nodes { get; set; }

            }

            [NameInMap("ResourcesUsed")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobInfoResourcesUsed ResourcesUsed { get; set; }
            public class GetJobResponseBodyJobInfoResourcesUsed : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public string Cores { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>512mb</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public string Nodes { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testuser</para>
            /// </summary>
            [NameInMap("RunasUser")]
            [Validation(Required=false)]
            public string RunasUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-16T10:52:48</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyJobInfoVariables> Variables { get; set; }
            public class GetJobResponseBodyJobInfoVariables : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ProxyIP</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.x.x.x</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>04F0****-1335-<b><b>-A1D7-6C044FE7</b></b></para>
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
        public string Success { get; set; }

    }

}
