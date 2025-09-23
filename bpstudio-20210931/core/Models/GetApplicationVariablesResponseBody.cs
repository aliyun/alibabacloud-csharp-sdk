// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetApplicationVariablesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetApplicationVariablesResponseBodyData> Data { get; set; }
        public class GetApplicationVariablesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ob5epf79uv****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("VariableList")]
            [Validation(Required=false)]
            public List<GetApplicationVariablesResponseBodyDataVariableList> VariableList { get; set; }
            public class GetApplicationVariablesResponseBodyDataVariableList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs.c6.4xlarge</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>${instance_type}</para>
                /// </summary>
                [NameInMap("Variable")]
                [Validation(Required=false)]
                public string Variable { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7036DDBE-0ABA-52D7-A39D-75E511970F07</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
