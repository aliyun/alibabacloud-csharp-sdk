// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCommandsResponseBody : TeaModel {
        [NameInMap("Commands")]
        [Validation(Required=false)]
        public DescribeCommandsResponseBodyCommands Commands { get; set; }
        public class DescribeCommandsResponseBodyCommands : TeaModel {
            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<DescribeCommandsResponseBodyCommandsCommand> Command { get; set; }
            public class DescribeCommandsResponseBodyCommandsCommand : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CommandContent")]
                [Validation(Required=false)]
                public string CommandContent { get; set; }

                [NameInMap("CommandId")]
                [Validation(Required=false)]
                public string CommandId { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EnableParameter")]
                [Validation(Required=false)]
                public bool? EnableParameter { get; set; }

                [NameInMap("InvokeTimes")]
                [Validation(Required=false)]
                public int? InvokeTimes { get; set; }

                [NameInMap("Latest")]
                [Validation(Required=false)]
                public bool? Latest { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ParameterDefinitions")]
                [Validation(Required=false)]
                public DescribeCommandsResponseBodyCommandsCommandParameterDefinitions ParameterDefinitions { get; set; }
                public class DescribeCommandsResponseBodyCommandsCommandParameterDefinitions : TeaModel {
                    [NameInMap("ParameterDefinition")]
                    [Validation(Required=false)]
                    public List<DescribeCommandsResponseBodyCommandsCommandParameterDefinitionsParameterDefinition> ParameterDefinition { get; set; }
                    public class DescribeCommandsResponseBodyCommandsCommandParameterDefinitionsParameterDefinition : TeaModel {
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                        [NameInMap("PossibleValues")]
                        [Validation(Required=false)]
                        public DescribeCommandsResponseBodyCommandsCommandParameterDefinitionsParameterDefinitionPossibleValues PossibleValues { get; set; }
                        public class DescribeCommandsResponseBodyCommandsCommandParameterDefinitionsParameterDefinitionPossibleValues : TeaModel {
                            [NameInMap("PossibleValue")]
                            [Validation(Required=false)]
                            public List<string> PossibleValue { get; set; }

                        }

                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                    }

                }

                [NameInMap("ParameterNames")]
                [Validation(Required=false)]
                public DescribeCommandsResponseBodyCommandsCommandParameterNames ParameterNames { get; set; }
                public class DescribeCommandsResponseBodyCommandsCommandParameterNames : TeaModel {
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public List<string> ParameterName { get; set; }

                }

                [NameInMap("Provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCommandsResponseBodyCommandsCommandTags Tags { get; set; }
                public class DescribeCommandsResponseBodyCommandsCommandTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCommandsResponseBodyCommandsCommandTagsTag> Tag { get; set; }
                    public class DescribeCommandsResponseBodyCommandsCommandTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
