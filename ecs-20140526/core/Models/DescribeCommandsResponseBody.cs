// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCommandsResponseBody : TeaModel {
        /// <summary>
        /// The queried commands.
        /// </summary>
        [NameInMap("Commands")]
        [Validation(Required=false)]
        public DescribeCommandsResponseBodyCommands Commands { get; set; }
        public class DescribeCommandsResponseBodyCommands : TeaModel {
            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<DescribeCommandsResponseBodyCommandsCommand> Command { get; set; }
            public class DescribeCommandsResponseBodyCommandsCommand : TeaModel {
                /// <summary>
                /// The category of the common command.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The content of the command, which is Base64-encoded.
                /// 
                /// *   If ContentEncoding is set to PlainText in the request, the original command content is returned.
                /// *   If ContentEncoding is set to Base64 in the request, the Base64-encoded command content is returned.
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
                /// The number of tasks created by using the command.
                /// </summary>
                [NameInMap("InvokeTimes")]
                [Validation(Required=false)]
                public int? InvokeTimes { get; set; }

                /// <summary>
                /// Indicates whether the common command is of the latest version. If multiple common commands from the same provider (`Provider`) belong to the same category and have the same name, these commands are different versions of the same command. This parameter is not returned for the Cloud Assistant commands that you created.
                /// </summary>
                [NameInMap("Latest")]
                [Validation(Required=false)]
                public bool? Latest { get; set; }

                /// <summary>
                /// The name of the command.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The custom parameters.
                /// </summary>
                [NameInMap("ParameterDefinitions")]
                [Validation(Required=false)]
                public DescribeCommandsResponseBodyCommandsCommandParameterDefinitions ParameterDefinitions { get; set; }
                public class DescribeCommandsResponseBodyCommandsCommandParameterDefinitions : TeaModel {
                    [NameInMap("ParameterDefinition")]
                    [Validation(Required=false)]
                    public List<DescribeCommandsResponseBodyCommandsCommandParameterDefinitionsParameterDefinition> ParameterDefinition { get; set; }
                    public class DescribeCommandsResponseBodyCommandsCommandParameterDefinitionsParameterDefinition : TeaModel {
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
                        /// The valid values of the custom parameter of the enumeration type.
                        /// </summary>
                        [NameInMap("PossibleValues")]
                        [Validation(Required=false)]
                        public DescribeCommandsResponseBodyCommandsCommandParameterDefinitionsParameterDefinitionPossibleValues PossibleValues { get; set; }
                        public class DescribeCommandsResponseBodyCommandsCommandParameterDefinitionsParameterDefinitionPossibleValues : TeaModel {
                            [NameInMap("PossibleValue")]
                            [Validation(Required=false)]
                            public List<string> PossibleValue { get; set; }

                        }

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

                }

                /// <summary>
                /// The custom parameter names that are parsed from the command content specified when the command was created. If the custom parameter feature is disabled, an empty list is returned.
                /// </summary>
                [NameInMap("ParameterNames")]
                [Validation(Required=false)]
                public DescribeCommandsResponseBodyCommandsCommandParameterNames ParameterNames { get; set; }
                public class DescribeCommandsResponseBodyCommandsCommandParameterNames : TeaModel {
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public List<string> ParameterName { get; set; }

                }

                /// <summary>
                /// The provider of the common command.
                /// </summary>
                [NameInMap("Provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                /// <summary>
                /// The ID of the resource group to which the command belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The tags of the command.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCommandsResponseBodyCommandsCommandTags Tags { get; set; }
                public class DescribeCommandsResponseBodyCommandsCommandTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCommandsResponseBodyCommandsCommandTagsTag> Tag { get; set; }
                    public class DescribeCommandsResponseBodyCommandsCommandTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key of the command.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value of the command.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The timeout period. Unit: seconds.
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
                /// The version of the common command. If multiple common commands from the same provider (`Provider`) belong to the same category and have the same name, these commands are different versions of the same command. This parameter is not returned for the Cloud Assistant commands that you created.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

                /// <summary>
                /// The execution path of the command.
                /// </summary>
                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of commands.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
