// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ParseBatchTaskDependencyResponseBody : TeaModel {
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

        [NameInMap("ParseResult")]
        [Validation(Required=false)]
        public ParseBatchTaskDependencyResponseBodyParseResult ParseResult { get; set; }
        public class ParseBatchTaskDependencyResponseBodyParseResult : TeaModel {
            [NameInMap("DependNodeList")]
            [Validation(Required=false)]
            public List<ParseBatchTaskDependencyResponseBodyParseResultDependNodeList> DependNodeList { get; set; }
            public class ParseBatchTaskDependencyResponseBodyParseResultDependNodeList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>input</para>
                /// </summary>
                [NameInMap("NodeIoType")]
                [Validation(Required=false)]
                public string NodeIoType { get; set; }

                [NameInMap("ScheduleNodeInfoList")]
                [Validation(Required=false)]
                public List<ParseBatchTaskDependencyResponseBodyParseResultDependNodeListScheduleNodeInfoList> ScheduleNodeInfoList { get; set; }
                public class ParseBatchTaskDependencyResponseBodyParseResultDependNodeListScheduleNodeInfoList : TeaModel {
                    [NameInMap("FieldList")]
                    [Validation(Required=false)]
                    public List<string> FieldList { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>n_11013121</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test11</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>t_test</para>
                    /// </summary>
                    [NameInMap("OutputName")]
                    [Validation(Required=false)]
                    public string OutputName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>201122301</para>
                    /// </summary>
                    [NameInMap("OwnerUserId")]
                    [Validation(Required=false)]
                    public string OwnerUserId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>t_test</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
