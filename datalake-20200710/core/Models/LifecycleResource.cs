// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class LifecycleResource : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("Database")]
        [Validation(Required=false)]
        public LifecycleResourceDatabase Database { get; set; }
        public class LifecycleResourceDatabase : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("LocationUri")]
            [Validation(Required=false)]
            public string LocationUri { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("DatabaseProfile")]
        [Validation(Required=false)]
        public DatabaseProfile DatabaseProfile { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("LifecycleRuleBizId")]
        [Validation(Required=false)]
        public string LifecycleRuleBizId { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public long? Owner { get; set; }

        [NameInMap("Table")]
        [Validation(Required=false)]
        public LifecycleResourceTable Table { get; set; }
        public class LifecycleResourceTable : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

            [NameInMap("Sd")]
            [Validation(Required=false)]
            public LifecycleResourceTableSd Sd { get; set; }
            public class LifecycleResourceTableSd : TeaModel {
                [NameInMap("BucketCols")]
                [Validation(Required=false)]
                public List<string> BucketCols { get; set; }

                [NameInMap("InputFormat")]
                [Validation(Required=false)]
                public string InputFormat { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("OutputFormat")]
                [Validation(Required=false)]
                public string OutputFormat { get; set; }

                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public Dictionary<string, string> Parameters { get; set; }

                [NameInMap("SerDeInfo")]
                [Validation(Required=false)]
                public LifecycleResourceTableSdSerDeInfo SerDeInfo { get; set; }
                public class LifecycleResourceTableSdSerDeInfo : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Parameters")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Parameters { get; set; }

                    [NameInMap("SerializationLib")]
                    [Validation(Required=false)]
                    public string SerializationLib { get; set; }

                }

            }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("TableType")]
            [Validation(Required=false)]
            public string TableType { get; set; }

        }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("TableProfile")]
        [Validation(Required=false)]
        public TableProfile TableProfile { get; set; }

    }

}
