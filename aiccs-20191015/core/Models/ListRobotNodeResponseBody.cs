// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListRobotNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>Request status code. A return value of OK indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>List of robot nodes.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListRobotNodeResponseBodyData> Data { get; set; }
        public class ListRobotNodeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Whether it is an output. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Yes.</description></item>
            /// <item><description><b>0</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsOutput")]
            [Validation(Required=false)]
            public int? IsOutput { get; set; }

            /// <summary>
            /// <para>Model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>模型一</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>Output ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12****</para>
            /// </summary>
            [NameInMap("NodeIdentifier")]
            [Validation(Required=false)]
            public string NodeIdentifier { get; set; }

            /// <summary>
            /// <para>Node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>理财</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>Flow name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>开场白</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the API invocation succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
