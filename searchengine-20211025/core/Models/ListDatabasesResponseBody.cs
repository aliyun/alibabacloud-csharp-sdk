// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListDatabasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E45380E8-994A-5402-9806-F114B3295FCF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListDatabasesResponseBodyResult Result { get; set; }
        public class ListDatabasesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>A list of databases.</para>
            /// </summary>
            [NameInMap("databases")]
            [Validation(Required=false)]
            public List<ListDatabasesResponseBodyResultDatabases> Databases { get; set; }
            public class ListDatabasesResponseBodyResultDatabases : TeaModel {
                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The information about the functions.</para>
                /// </summary>
                [NameInMap("functions")]
                [Validation(Required=false)]
                public Dictionary<string, List<ResultDatabasesFunctionsValue>> Functions { get; set; }

                /// <summary>
                /// <para>The information about the SQL instances.</para>
                /// </summary>
                [NameInMap("sqlInstances")]
                [Validation(Required=false)]
                public List<ListDatabasesResponseBodyResultDatabasesSqlInstances> SqlInstances { get; set; }
                public class ListDatabasesResponseBodyResultDatabasesSqlInstances : TeaModel {
                    /// <summary>
                    /// <para>The information about the subdirectories.</para>
                    /// </summary>
                    [NameInMap("children")]
                    [Validation(Required=false)]
                    public List<object> Children { get; set; }

                    /// <summary>
                    /// <para>The primary key ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12190</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public long? InstanceId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the item is a folder. A value of 1 indicates that the item is a folder. A value of 0 indicates that it is not a folder.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("isDir")]
                    [Validation(Required=false)]
                    public int? IsDir { get; set; }

                    /// <summary>
                    /// <para>The name of the SQL instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>general</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the parent node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-1</para>
                    /// </summary>
                    [NameInMap("parent")]
                    [Validation(Required=false)]
                    public long? Parent { get; set; }

                    /// <summary>
                    /// <para>The template ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("templateId")]
                    [Validation(Required=false)]
                    public long? TemplateId { get; set; }

                    /// <summary>
                    /// <para>table, instance, template, function</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>instance</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The information about the tables.</para>
                /// </summary>
                [NameInMap("tables")]
                [Validation(Required=false)]
                public List<ListDatabasesResponseBodyResultDatabasesTables> Tables { get; set; }
                public class ListDatabasesResponseBodyResultDatabasesTables : TeaModel {
                    /// <summary>
                    /// <para>The information about the subdirectories.</para>
                    /// </summary>
                    [NameInMap("children")]
                    [Validation(Required=false)]
                    public List<object> Children { get; set; }

                    /// <summary>
                    /// <para>The primary key ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>56</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public long? InstanceId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the item is a folder. A value of 1 indicates that the item is a folder. A value of 0 indicates that it is not a folder.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("isDir")]
                    [Validation(Required=false)]
                    public int? IsDir { get; set; }

                    /// <summary>
                    /// <para>The name of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>general</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the parent node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-1</para>
                    /// </summary>
                    [NameInMap("parent")]
                    [Validation(Required=false)]
                    public long? Parent { get; set; }

                    /// <summary>
                    /// <para>The template ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("templateId")]
                    [Validation(Required=false)]
                    public long? TemplateId { get; set; }

                    /// <summary>
                    /// <para>table, instance, template, function</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>table</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The information about the templates.</para>
                /// </summary>
                [NameInMap("templates")]
                [Validation(Required=false)]
                public List<ListDatabasesResponseBodyResultDatabasesTemplates> Templates { get; set; }
                public class ListDatabasesResponseBodyResultDatabasesTemplates : TeaModel {
                    /// <summary>
                    /// <para>The information about the subdirectories.</para>
                    /// </summary>
                    [NameInMap("children")]
                    [Validation(Required=false)]
                    public List<object> Children { get; set; }

                    /// <summary>
                    /// <para>The primary key ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public long? InstanceId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the item is a folder. A value of 1 indicates that the item is a folder. A value of 0 indicates that it is not a folder.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("isDir")]
                    [Validation(Required=false)]
                    public int? IsDir { get; set; }

                    /// <summary>
                    /// <para>The name of the template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>c26_schema</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the parent node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-1</para>
                    /// </summary>
                    [NameInMap("parent")]
                    [Validation(Required=false)]
                    public long? Parent { get; set; }

                    /// <summary>
                    /// <para>The template ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("templateId")]
                    [Validation(Required=false)]
                    public long? TemplateId { get; set; }

                    /// <summary>
                    /// <para>table, instance, template, function</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>template</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

    }

}
