// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class TableExtended : TeaModel {
        [NameInMap("Cascade")]
        [Validation(Required=false)]
        public bool? Cascade { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("LastAccessTime")]
        [Validation(Required=false)]
        public int? LastAccessTime { get; set; }

        [NameInMap("LastAnalyzedTime")]
        [Validation(Required=false)]
        public int? LastAnalyzedTime { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        [NameInMap("PartitionKeys")]
        [Validation(Required=false)]
        public List<FieldSchema> PartitionKeys { get; set; }

        [NameInMap("Privileges")]
        [Validation(Required=false)]
        public TableExtendedPrivileges Privileges { get; set; }
        public class TableExtendedPrivileges : TeaModel {
            [NameInMap("RolePrivileges")]
            [Validation(Required=false)]
            public Dictionary<string, List<TableExtendedPrivilegesRolePrivilegesValue>> RolePrivileges { get; set; }

            [NameInMap("UserPrivileges")]
            [Validation(Required=false)]
            public Dictionary<string, List<TableExtendedPrivilegesUserPrivilegesValue>> UserPrivileges { get; set; }

            [NameInMap("groupPrivileges")]
            [Validation(Required=false)]
            public Dictionary<string, List<TableExtendedPrivilegesGroupPrivilegesValue>> GroupPrivileges { get; set; }

        }

        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        [NameInMap("RewriteEnabled")]
        [Validation(Required=false)]
        public bool? RewriteEnabled { get; set; }

        [NameInMap("Sd")]
        [Validation(Required=false)]
        public TableExtendedSd Sd { get; set; }
        public class TableExtendedSd : TeaModel {
            [NameInMap("BucketCols")]
            [Validation(Required=false)]
            public List<string> BucketCols { get; set; }

            [NameInMap("Cols")]
            [Validation(Required=false)]
            public List<FieldSchema> Cols { get; set; }

            [NameInMap("Compressed")]
            [Validation(Required=false)]
            public bool? Compressed { get; set; }

            [NameInMap("InputFormat")]
            [Validation(Required=false)]
            public string InputFormat { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("NumBuckets")]
            [Validation(Required=false)]
            public int? NumBuckets { get; set; }

            [NameInMap("OutputFormat")]
            [Validation(Required=false)]
            public string OutputFormat { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

            [NameInMap("SerDeInfo")]
            [Validation(Required=false)]
            public TableExtendedSdSerDeInfo SerDeInfo { get; set; }
            public class TableExtendedSdSerDeInfo : TeaModel {
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

            [NameInMap("SkewedInfo")]
            [Validation(Required=false)]
            public TableExtendedSdSkewedInfo SkewedInfo { get; set; }
            public class TableExtendedSdSkewedInfo : TeaModel {
                [NameInMap("SkewedColNames")]
                [Validation(Required=false)]
                public List<string> SkewedColNames { get; set; }

                [NameInMap("SkewedColValueLocationMaps")]
                [Validation(Required=false)]
                public Dictionary<string, string> SkewedColValueLocationMaps { get; set; }

                [NameInMap("SkewedColValues")]
                [Validation(Required=false)]
                public List<List<string>> SkewedColValues { get; set; }

            }

            [NameInMap("SortCols")]
            [Validation(Required=false)]
            public List<Order> SortCols { get; set; }

            [NameInMap("StoredAsSubDirectories")]
            [Validation(Required=false)]
            public bool? StoredAsSubDirectories { get; set; }

        }

        [NameInMap("TableFormat")]
        [Validation(Required=false)]
        public string TableFormat { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        [NameInMap("Temporary")]
        [Validation(Required=false)]
        public bool? Temporary { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public int? UpdateTime { get; set; }

        [NameInMap("ViewExpandedText")]
        [Validation(Required=false)]
        public string ViewExpandedText { get; set; }

        [NameInMap("ViewOriginalText")]
        [Validation(Required=false)]
        public string ViewOriginalText { get; set; }

    }

}
