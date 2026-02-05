// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLServerUpgradeVersionsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSQLServerUpgradeVersionsResponseBodyItems Items { get; set; }
        public class DescribeSQLServerUpgradeVersionsResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeSQLServerUpgradeVersionsResponseBodyItemsItem> Item { get; set; }
            public class DescribeSQLServerUpgradeVersionsResponseBodyItemsItem : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2016_web</para>
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public string CurrentVersion { get; set; }

                [NameInMap("SQLServerUpgradeVersions")]
                [Validation(Required=false)]
                public DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersions SQLServerUpgradeVersions { get; set; }
                public class DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersions : TeaModel {
                    [NameInMap("SQLServerUpgradeVersion")]
                    [Validation(Required=false)]
                    public List<DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersionsSQLServerUpgradeVersion> SQLServerUpgradeVersion { get; set; }
                    public class DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersionsSQLServerUpgradeVersion : TeaModel {
                        [NameInMap("DBInstanceClassItems")]
                        [Validation(Required=false)]
                        public DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersionsSQLServerUpgradeVersionDBInstanceClassItems DBInstanceClassItems { get; set; }
                        public class DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersionsSQLServerUpgradeVersionDBInstanceClassItems : TeaModel {
                            [NameInMap("DBInstanceClassItem")]
                            [Validation(Required=false)]
                            public List<DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersionsSQLServerUpgradeVersionDBInstanceClassItemsDBInstanceClassItem> DBInstanceClassItem { get; set; }
                            public class DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersionsSQLServerUpgradeVersionDBInstanceClassItemsDBInstanceClassItem : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>2</para>
                                /// </summary>
                                [NameInMap("CPU")]
                                [Validation(Required=false)]
                                public string CPU { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>mssql.x4.medium.s2</para>
                                /// </summary>
                                [NameInMap("DBInstanceClass")]
                                [Validation(Required=false)]
                                public string DBInstanceClass { get; set; }

                                [NameInMap("DBInstanceClassType")]
                                [Validation(Required=false)]
                                public string DBInstanceClassType { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>2</para>
                                /// </summary>
                                [NameInMap("Group")]
                                [Validation(Required=false)]
                                public string Group { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>8GB</para>
                                /// </summary>
                                [NameInMap("Memory")]
                                [Validation(Required=false)]
                                public string Memory { get; set; }

                            }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>NO/YES</para>
                        /// </summary>
                        [NameInMap("EnableUpgrade")]
                        [Validation(Required=false)]
                        public string EnableUpgrade { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2016_std</para>
                        /// </summary>
                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>866F5EB8-4650-4061-87F0-379F6F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
