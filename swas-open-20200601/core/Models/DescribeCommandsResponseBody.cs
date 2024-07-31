// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCommandsResponseBody : TeaModel {
        /// <summary>
        /// The queried commands.
        /// </summary>
        [NameInMap("Commands")]
        [Validation(Required=false)]
        public List<DescribeCommandsResponseBodyCommands> Commands { get; set; }
        public class DescribeCommandsResponseBodyCommands : TeaModel {
            /// <summary>
            /// The content of the command.
            /// </summary>
            [NameInMap("CommandContent")]
            [Validation(Required=false)]
            public string CommandContent { get; set; }

            /// <summary>
            /// The command ID.
            /// </summary>
            [NameInMap("CommandId")]
            [Validation(Required=false)]
            public string CommandId { get; set; }

            /// <summary>
            /// The time when the command was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the command.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether the custom parameter feature is enabled for the command.
            /// </summary>
            [NameInMap("EnableParameter")]
            [Validation(Required=false)]
            public bool? EnableParameter { get; set; }

            /// <summary>
            /// The name of the command.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Details of the custom parameter.
            /// </summary>
            [NameInMap("ParameterDefinitions")]
            [Validation(Required=false)]
            public List<DescribeCommandsResponseBodyCommandsParameterDefinitions> ParameterDefinitions { get; set; }
            public class DescribeCommandsResponseBodyCommandsParameterDefinitions : TeaModel {
                /// <summary>
                /// The default value of the custom parameter.
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// The description of the custom parameter.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the custom parameter.
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// The valid values of the custom parameter.
                /// </summary>
                [NameInMap("PossibleValues")]
                [Validation(Required=false)]
                public List<string> PossibleValues { get; set; }

                /// <summary>
                /// Indicates whether the custom parameter is required. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// Default value: false.
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

            }

            /// <summary>
            /// The custom parameter names that are parsed from the command content specified when the command was created. The custom parameter names are returned in the list format. If the custom parameter feature is disabled, an empty list is returned.
            /// </summary>
            [NameInMap("ParameterNames")]
            [Validation(Required=false)]
            public List<string> ParameterNames { get; set; }

            /// <summary>
            /// The provider of the command.
            /// </summary>
            [NameInMap("Provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// The resource group ID.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The tags that are bound to the command.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeCommandsResponseBodyCommandsTags> Tags { get; set; }
            public class DescribeCommandsResponseBodyCommandsTags : TeaModel {
                /// <summary>
                /// The tag key of the command.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value of the command.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The timeout period of the command.
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

            /// <summary>
            /// The type of the command.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The execution path of the command.
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of commands.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
