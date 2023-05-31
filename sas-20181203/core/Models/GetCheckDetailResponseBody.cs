// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckDetailResponseBody : TeaModel {
        /// <summary>
        /// The help information about the check item.
        /// </summary>
        [NameInMap("AssistInfo")]
        [Validation(Required=false)]
        public GetCheckDetailResponseBodyAssistInfo AssistInfo { get; set; }
        public class GetCheckDetailResponseBodyAssistInfo : TeaModel {
            /// <summary>
            /// The link to the help information about the risk item when the Type parameter is set to link.
            /// </summary>
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// The type of the help information about the risk item. Valid values:
            /// 
            /// *   **text**
            /// *   **link**
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The content in the help information about the risk item when the Type parameter is set to text.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The custom configuration items of the check item.
        /// </summary>
        [NameInMap("CustomConfigs")]
        [Validation(Required=false)]
        public List<GetCheckDetailResponseBodyCustomConfigs> CustomConfigs { get; set; }
        public class GetCheckDetailResponseBodyCustomConfigs : TeaModel {
            /// <summary>
            /// The default value of the custom configuration item. The value is a string.
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// The name of the custom configuration item. The name of a custom configuration item is unique in a check item.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The keyword that identifies the custom configuration item for internationalization.
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// The type of the custom configuration item. The value is a JSON string.
            /// </summary>
            [NameInMap("TypeDefine")]
            [Validation(Required=false)]
            public string TypeDefine { get; set; }

            /// <summary>
            /// The value of the custom configuration item. The value is a string.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The description of the check item.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public GetCheckDetailResponseBodyDescription Description { get; set; }
        public class GetCheckDetailResponseBodyDescription : TeaModel {
            /// <summary>
            /// The link to the description of the check item.
            /// </summary>
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// The type of the description of the check item. The value is fixed as text.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The content in the description of the check item.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The solution to handle the risk item.
        /// </summary>
        [NameInMap("Solution")]
        [Validation(Required=false)]
        public GetCheckDetailResponseBodySolution Solution { get; set; }
        public class GetCheckDetailResponseBodySolution : TeaModel {
            /// <summary>
            /// The link to the solution to handle the risk item when the Type parameter is set to link.
            /// </summary>
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// The type of the solution to handle the risk item. Valid values:
            /// 
            /// *   **text**
            /// *   **link**
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The content of the solution to handle the risk item when the Type parameter is set to text.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
