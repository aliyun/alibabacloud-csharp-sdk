// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetApplicationVariablesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetApplicationVariablesResponseBodyData> Data { get; set; }
        public class GetApplicationVariablesResponseBodyData : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("VariableList")]
            [Validation(Required=false)]
            public List<GetApplicationVariablesResponseBodyDataVariableList> VariableList { get; set; }
            public class GetApplicationVariablesResponseBodyDataVariableList : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("Variable")]
                [Validation(Required=false)]
                public string Variable { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
