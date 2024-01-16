// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSophonCommandsResponseBody : TeaModel {
        /// <summary>
        /// The commands.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSophonCommandsResponseBodyData> Data { get; set; }
        public class DescribeSophonCommandsResponseBodyData : TeaModel {
            /// <summary>
            /// The description of the command.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The display name of the command.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The name of the command.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The parameter configurations.
            /// </summary>
            [NameInMap("ParamConfig")]
            [Validation(Required=false)]
            public List<DescribeSophonCommandsResponseBodyDataParamConfig> ParamConfig { get; set; }
            public class DescribeSophonCommandsResponseBodyDataParamConfig : TeaModel {
                /// <summary>
                /// The regular expression that is used to check the format of the parameter value. If the parameter is left empty, the check is not performed.
                /// </summary>
                [NameInMap("CheckField")]
                [Validation(Required=false)]
                public string CheckField { get; set; }

                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("Field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                /// <summary>
                /// Indicates whether the parameter is required. Valid values:
                /// 
                /// *   **true** (default)
                /// *   **false**
                /// </summary>
                [NameInMap("Necessary")]
                [Validation(Required=false)]
                public bool? Necessary { get; set; }

                /// <summary>
                /// The value of the parameter.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
