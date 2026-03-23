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
                /// <para>当前的版本。若传DBInstanceId，则返回实例版本。若未传DBInstanceId，但传了EngineVersion，则返回EngineVersion。</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016_web</para>
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public string CurrentVersion { get; set; }

                /// <summary>
                /// <para>一个列表，显示是否支持升级到目标版本</para>
                /// </summary>
                [NameInMap("SQLServerUpgradeVersions")]
                [Validation(Required=false)]
                public DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersions SQLServerUpgradeVersions { get; set; }
                public class DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersions : TeaModel {
                    [NameInMap("SQLServerUpgradeVersion")]
                    [Validation(Required=false)]
                    public List<DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersionsSQLServerUpgradeVersion> SQLServerUpgradeVersion { get; set; }
                    public class DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersionsSQLServerUpgradeVersion : TeaModel {
                        /// <summary>
                        /// <para>一个列表，描述了每个版本是否可以成为升级目标</para>
                        /// </summary>
                        [NameInMap("DBInstanceClassItems")]
                        [Validation(Required=false)]
                        public DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersionsSQLServerUpgradeVersionDBInstanceClassItems DBInstanceClassItems { get; set; }
                        public class DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersionsSQLServerUpgradeVersionDBInstanceClassItems : TeaModel {
                            [NameInMap("DBInstanceClassItem")]
                            [Validation(Required=false)]
                            public List<DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersionsSQLServerUpgradeVersionDBInstanceClassItemsDBInstanceClassItem> DBInstanceClassItem { get; set; }
                            public class DescribeSQLServerUpgradeVersionsResponseBodyItemsItemSQLServerUpgradeVersionsSQLServerUpgradeVersionDBInstanceClassItemsDBInstanceClassItem : TeaModel {
                                /// <summary>
                                /// <para>可升级的版本规格的CPU大小</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2</para>
                                /// </summary>
                                [NameInMap("CPU")]
                                [Validation(Required=false)]
                                public string CPU { get; set; }

                                /// <summary>
                                /// <para>可升级的版本规格</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>mssql.x4.medium.s2</para>
                                /// </summary>
                                [NameInMap("DBInstanceClass")]
                                [Validation(Required=false)]
                                public string DBInstanceClass { get; set; }

                                /// <summary>
                                /// <para>可升级的版本规格的类型</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>独享型</para>
                                /// </summary>
                                [NameInMap("DBInstanceClassType")]
                                [Validation(Required=false)]
                                public string DBInstanceClassType { get; set; }

                                /// <summary>
                                /// <para>组类型</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2</para>
                                /// </summary>
                                [NameInMap("Group")]
                                [Validation(Required=false)]
                                public string Group { get; set; }

                                /// <summary>
                                /// <para>可升级的版本规格的内存大小</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>8GB</para>
                                /// </summary>
                                [NameInMap("Memory")]
                                [Validation(Required=false)]
                                public string Memory { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>是否支持升级到该版本</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NO/YES</para>
                        /// </summary>
                        [NameInMap("EnableUpgrade")]
                        [Validation(Required=false)]
                        public string EnableUpgrade { get; set; }

                        /// <summary>
                        /// <para>版本值</para>
                        /// 
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
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>866F5EB8-4650-4061-87F0-379F6F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
