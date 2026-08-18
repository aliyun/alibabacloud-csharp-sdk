// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListResourcesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListResourcesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The page number of the request, used for pagination.</para>
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
            /// <para>The list of resources returned by the query.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyPagingInfoResources> Resources { get; set; }
            public class ListResourcesResponseBodyPagingInfoResources : TeaModel {
                /// <summary>
                /// <para>The timestamp when the file resource was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724505917000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The data source.</para>
                /// </summary>
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public ListResourcesResponseBodyPagingInfoResourcesDataSource DataSource { get; set; }
                public class ListResourcesResponseBodyPagingInfoResourcesDataSource : TeaModel {
                    /// <summary>
                    /// <para>The name of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps_first</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The unique identifier of the file resource.</para>
                /// <remarks>
                /// <para>Notice: This field was of the Long type in SDK versions earlier than 8.0.0 and is of the String type in SDK 8.0.0 and later. <b>This change does not affect normal SDK usage. The parameter is still returned in the type defined in the SDK</b>. Only when you upgrade across SDK version 8.0.0, the type change may cause project compilation failures, and you need to manually correct the data type.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>631478864897630XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The timestamp when the file resource was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724505917000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The name of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>math.py</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The owner of the file resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110755000425XXXX</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace configuration page to obtain the workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>344247</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The script information.</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public ListResourcesResponseBodyPagingInfoResourcesScript Script { get; set; }
                public class ListResourcesResponseBodyPagingInfoResourcesScript : TeaModel {
                    /// <summary>
                    /// <para>The script ID.</para>
                    /// <remarks>
                    /// <para>Notice: This field was of the Long type in SDK versions earlier than 8.0.0 and is of the String type in SDK 8.0.0 and later. <b>This change does not affect normal SDK usage. The parameter is still returned in the type defined in the SDK</b>. Only when you upgrade across SDK version 8.0.0, the type change may cause project compilation failures, and you need to manually correct the data type.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123348864897630XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The path of the script.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>root/demo</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The runtime.</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListResourcesResponseBodyPagingInfoResourcesScriptRuntime Runtime { get; set; }
                    public class ListResourcesResponseBodyPagingInfoResourcesScriptRuntime : TeaModel {
                        /// <summary>
                        /// <para>The command, which indicates the file type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ODPS_PYTHON</para>
                        /// </summary>
                        [NameInMap("Command")]
                        [Validation(Required=false)]
                        public string Command { get; set; }

                    }

                }

                /// <summary>
                /// <para>The source path of the file resource. This field is empty when the type is Local.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX/unknown/ide/1/XXX/20240820200851_963a9da676de44ef8d06a6576a8c4d6a.py</para>
                /// </summary>
                [NameInMap("SourcePath")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

                /// <summary>
                /// <para>The source storage type of the file resource.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Local: local storage.</description></item>
                /// <item><description>Oss: Object Storage Service.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Local</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The target storage path of the file resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX/unknown/ide/1/XXX/20240820200851_963a9da676de44ef8d06a6576a8c4d6a.py</para>
                /// </summary>
                [NameInMap("TargetPath")]
                [Validation(Required=false)]
                public string TargetPath { get; set; }

                /// <summary>
                /// <para>The target storage type of the file resource.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Gateway: gateway.</description></item>
                /// <item><description>Oss: Object Storage Service.</description></item>
                /// <item><description>Hdfs: HDFS file storage system.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Oss</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

                /// <summary>
                /// <para>The resource file type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Python</description></item>
                /// <item><description>Jar</description></item>
                /// <item><description>Archive</description></item>
                /// <item><description>File</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Jar</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries that meet the filter conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of this request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99EBE7CF-69C0-5089-BE3E-79563C31XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
