// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListDatabasesResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// NodeTreeVO
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListDatabasesResponseBodyResult Result { get; set; }
        public class ListDatabasesResponseBodyResult : TeaModel {
            [NameInMap("databases")]
            [Validation(Required=false)]
            public List<ListDatabasesResponseBodyResultDatabases> Databases { get; set; }
            public class ListDatabasesResponseBodyResultDatabases : TeaModel {
                [NameInMap("database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("functions")]
                [Validation(Required=false)]
                public Dictionary<string, List<ResultDatabasesFunctionsValue>> Functions { get; set; }

                [NameInMap("sqlInstances")]
                [Validation(Required=false)]
                public List<ListDatabasesResponseBodyResultDatabasesSqlInstances> SqlInstances { get; set; }
                public class ListDatabasesResponseBodyResultDatabasesSqlInstances : TeaModel {
                    [NameInMap("children")]
                    [Validation(Required=false)]
                    public List<object> Children { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public long? InstanceId { get; set; }

                    [NameInMap("isDir")]
                    [Validation(Required=false)]
                    public int? IsDir { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("parent")]
                    [Validation(Required=false)]
                    public long? Parent { get; set; }

                    [NameInMap("templateId")]
                    [Validation(Required=false)]
                    public long? TemplateId { get; set; }

                    /// <summary>
                    /// table, instance, template, function
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("tables")]
                [Validation(Required=false)]
                public List<ListDatabasesResponseBodyResultDatabasesTables> Tables { get; set; }
                public class ListDatabasesResponseBodyResultDatabasesTables : TeaModel {
                    [NameInMap("children")]
                    [Validation(Required=false)]
                    public List<object> Children { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public long? InstanceId { get; set; }

                    [NameInMap("isDir")]
                    [Validation(Required=false)]
                    public int? IsDir { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("parent")]
                    [Validation(Required=false)]
                    public long? Parent { get; set; }

                    [NameInMap("templateId")]
                    [Validation(Required=false)]
                    public long? TemplateId { get; set; }

                    /// <summary>
                    /// table, instance, template, function
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("templates")]
                [Validation(Required=false)]
                public List<ListDatabasesResponseBodyResultDatabasesTemplates> Templates { get; set; }
                public class ListDatabasesResponseBodyResultDatabasesTemplates : TeaModel {
                    [NameInMap("children")]
                    [Validation(Required=false)]
                    public List<object> Children { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public long? InstanceId { get; set; }

                    [NameInMap("isDir")]
                    [Validation(Required=false)]
                    public int? IsDir { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("parent")]
                    [Validation(Required=false)]
                    public long? Parent { get; set; }

                    [NameInMap("templateId")]
                    [Validation(Required=false)]
                    public long? TemplateId { get; set; }

                    /// <summary>
                    /// table, instance, template, function
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

    }

}
