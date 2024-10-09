// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCommandsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried commands.</para>
        /// </summary>
        [NameInMap("Commands")]
        [Validation(Required=false)]
        public List<DescribeCommandsResponseBodyCommands> Commands { get; set; }
        public class DescribeCommandsResponseBodyCommands : TeaModel {
            /// <summary>
            /// <para>The content of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cat /etc/ssh/sshd_config</para>
            /// </summary>
            [NameInMap("CommandContent")]
            [Validation(Required=false)]
            public string CommandContent { get; set; }

            /// <summary>
            /// <para>The command ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-gov1k1tqwi9****</para>
            /// </summary>
            [NameInMap("CommandId")]
            [Validation(Required=false)]
            public string CommandId { get; set; }

            /// <summary>
            /// <para>The time when the command was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-05T06:38:53Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the custom parameter feature is enabled for the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableParameter")]
            [Validation(Required=false)]
            public bool? EnableParameter { get; set; }

            /// <summary>
            /// <para>The name of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Details of the custom parameter.</para>
            /// </summary>
            [NameInMap("ParameterDefinitions")]
            [Validation(Required=false)]
            public List<DescribeCommandsResponseBodyCommandsParameterDefinitions> ParameterDefinitions { get; set; }
            public class DescribeCommandsResponseBodyCommandsParameterDefinitions : TeaModel {
                /// <summary>
                /// <para>The default value of the custom parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://aliyun-client-assist.oss-accelerate.aliyuncs.com/linux/aliyun_assist_latest.rpm">https://aliyun-client-assist.oss-accelerate.aliyuncs.com/linux/aliyun_assist_latest.rpm</a></para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The description of the custom parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Command Assistant Agent Installation Package Path</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the custom parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DownloadUrl</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The valid values of the custom parameter.</para>
                /// </summary>
                [NameInMap("PossibleValues")]
                [Validation(Required=false)]
                public List<string> PossibleValues { get; set; }

                /// <summary>
                /// <para>Indicates whether the custom parameter is required. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

            }

            /// <summary>
            /// <para>The custom parameter names that are parsed from the command content specified when the command was created. The custom parameter names are returned in the list format. If the custom parameter feature is disabled, an empty list is returned.</para>
            /// </summary>
            [NameInMap("ParameterNames")]
            [Validation(Required=false)]
            public List<string> ParameterNames { get; set; }

            /// <summary>
            /// <para>The provider of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("Provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2bti7cf7****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The tags that are bound to the command.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeCommandsResponseBodyCommandsTags> Tags { get; set; }
            public class DescribeCommandsResponseBodyCommandsTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The timeout period of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

            /// <summary>
            /// <para>The type of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RunShellScript</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The execution path of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home</para>
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of commands.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
