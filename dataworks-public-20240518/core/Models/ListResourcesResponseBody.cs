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
            /// <para>The returned resource list.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyPagingInfoResources> Resources { get; set; }
            public class ListResourcesResponseBodyPagingInfoResources : TeaModel {
                /// <summary>
                /// <para>The time when the file resource was created. This value is a UNIX timestamp.</para>
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
                    /// <para>The data source name.</para>
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
                /// <para> Prior to SDK version 8.0.0, this field is of type Long. In SDK version 8.0.0 and later, it is of type String. This change does not affect the normal use of the SDK. The parameter is returned based on the type defined in the SDK. Compilation failures caused by the type change may occur only when you upgrade the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
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
                /// <para>The resource name.</para>
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
                /// <para>The ID of the DataWorks workspace. To obtain the workspace ID, log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and navigate to the workspace configuration page.</para>
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
                    /// <para>Script ID.</para>
                    /// <remarks>
                    /// <para> Prior to SDK version 8.0.0, this field is of type Long. In SDK version 8.0.0 and later, it is of type String. This change does not affect the normal use of the SDK. The parameter is returned based on the type defined in the SDK. Compilation failures caused by the type change may occur only when you upgrade the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123348864897630XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The script path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>root/demo</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>Runtime</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListResourcesResponseBodyPagingInfoResourcesScriptRuntime Runtime { get; set; }
                    public class ListResourcesResponseBodyPagingInfoResourcesScriptRuntime : TeaModel {
                        /// <summary>
                        /// <para>Command. This parameter indicates the file type.</para>
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
                /// <para>Source path of the file resource. This parameter is empty if the type is Local.</para>
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
                /// <item><description>Local: Local storage</description></item>
                /// <item><description>OSS: Object Storage Service</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>local</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The destination storage path</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX/unknown/ide/1/XXX/20240820200851_963a9da676de44ef8d06a6576a8c4d6a.py</para>
                /// </summary>
                [NameInMap("TargetPath")]
                [Validation(Required=false)]
                public string TargetPath { get; set; }

                /// <summary>
                /// <para>The destination storage type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Gateway</description></item>
                /// <item><description>OSS</description></item>
                /// <item><description>HDFS</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Python</description></item>
                /// <item><description>Jar</description></item>
                /// <item><description>Archive</description></item>
                /// <item><description>File</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>jar</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99EBE7CF-69C0-5089-BE3E-79563C31XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
