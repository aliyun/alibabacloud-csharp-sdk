// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowTimeVariablesResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TimeVariables")]
        [Validation(Required=false)]
        public ListTaskFlowTimeVariablesResponseBodyTimeVariables TimeVariables { get; set; }
        public class ListTaskFlowTimeVariablesResponseBodyTimeVariables : TeaModel {
            [NameInMap("TimeVariable")]
            [Validation(Required=false)]
            public List<ListTaskFlowTimeVariablesResponseBodyTimeVariablesTimeVariable> TimeVariable { get; set; }
            public class ListTaskFlowTimeVariablesResponseBodyTimeVariablesTimeVariable : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

            }

        }

    }

}
