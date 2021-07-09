// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ParseAppInputsResponseBody : TeaModel {
        /// <summary>
        /// 主机 ID
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// 请求 ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 应用输入参数
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public List<ParseAppInputsResponseBodyInputs> Inputs { get; set; }
        public class ParseAppInputsResponseBodyInputs : TeaModel {
            /// <summary>
            /// 参数名称
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            [NameInMap("StepOrder")]
            [Validation(Required=false)]
            public long? StepOrder { get; set; }

        }

    }

}
