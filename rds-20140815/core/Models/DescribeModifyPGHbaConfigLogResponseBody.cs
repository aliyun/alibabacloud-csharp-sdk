// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeModifyPGHbaConfigLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1lymyn1v3i****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>An array that consists of the modifications to the pg_hba.conf file.</para>
        /// </summary>
        [NameInMap("HbaLogItems")]
        [Validation(Required=false)]
        public DescribeModifyPGHbaConfigLogResponseBodyHbaLogItems HbaLogItems { get; set; }
        public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItems : TeaModel {
            [NameInMap("HbaLogItem")]
            [Validation(Required=false)]
            public List<DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItem> HbaLogItem { get; set; }
            public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItem : TeaModel {
                /// <summary>
                /// <para>The configurations of the pg_hba.conf file after modification.</para>
                /// </summary>
                [NameInMap("AfterHbaItems")]
                [Validation(Required=false)]
                public DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemAfterHbaItems AfterHbaItems { get; set; }
                public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemAfterHbaItems : TeaModel {
                    [NameInMap("HbaItem")]
                    [Validation(Required=false)]
                    public List<DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemAfterHbaItemsHbaItem> HbaItem { get; set; }
                    public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemAfterHbaItemsHbaItem : TeaModel {
                        /// <summary>
                        /// <para>The IP address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.0.0.0/0</para>
                        /// </summary>
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// <para>The name of the database.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>all</para>
                        /// </summary>
                        [NameInMap("Database")]
                        [Validation(Required=false)]
                        public string Database { get; set; }

                        /// <summary>
                        /// <para>The mask of the IP address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("Mask")]
                        [Validation(Required=false)]
                        public string Mask { get; set; }

                        /// <summary>
                        /// <para>The authentication method.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ldap</para>
                        /// </summary>
                        [NameInMap("Method")]
                        [Validation(Required=false)]
                        public string Method { get; set; }

                        /// <summary>
                        /// <para>The value of this parameter was set based on the value of the Method parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("Option")]
                        [Validation(Required=false)]
                        public string Option { get; set; }

                        /// <summary>
                        /// <para>The priority.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("PriorityId")]
                        [Validation(Required=false)]
                        public int? PriorityId { get; set; }

                        /// <summary>
                        /// <para>The connection type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>host</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The username of the account.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ldapuser</para>
                        /// </summary>
                        [NameInMap("User")]
                        [Validation(Required=false)]
                        public string User { get; set; }

                    }

                }

                /// <summary>
                /// <para>The configurations of the pg_hba.conf file before modification.</para>
                /// </summary>
                [NameInMap("BeforeHbaItems")]
                [Validation(Required=false)]
                public DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemBeforeHbaItems BeforeHbaItems { get; set; }
                public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemBeforeHbaItems : TeaModel {
                    [NameInMap("HbaItem")]
                    [Validation(Required=false)]
                    public List<DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemBeforeHbaItemsHbaItem> HbaItem { get; set; }
                    public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemBeforeHbaItemsHbaItem : TeaModel {
                        /// <summary>
                        /// <para>The IP address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.0.0.0/0</para>
                        /// </summary>
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// <para>The name of the database.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>all</para>
                        /// </summary>
                        [NameInMap("Database")]
                        [Validation(Required=false)]
                        public string Database { get; set; }

                        /// <summary>
                        /// <para>The mask of the IP address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("Mask")]
                        [Validation(Required=false)]
                        public string Mask { get; set; }

                        /// <summary>
                        /// <para>The authentication method.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>md5</para>
                        /// </summary>
                        [NameInMap("Method")]
                        [Validation(Required=false)]
                        public string Method { get; set; }

                        /// <summary>
                        /// <para>The value of this parameter varies based on the value of the Method parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("Option")]
                        [Validation(Required=false)]
                        public string Option { get; set; }

                        /// <summary>
                        /// <para>The priority.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("PriorityId")]
                        [Validation(Required=false)]
                        public int? PriorityId { get; set; }

                        /// <summary>
                        /// <para>The connection type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>host</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The username of the account.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>all</para>
                        /// </summary>
                        [NameInMap("User")]
                        [Validation(Required=false)]
                        public string User { get; set; }

                    }

                }

                /// <summary>
                /// <para>The status of the modification.</para>
                /// <list type="bullet">
                /// <item><description><b>success</b>: The modification is successful.</description></item>
                /// <item><description><b>failed</b>: The modification failed.</description></item>
                /// <item><description><b>setting</b>: The modification is being applied.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("ModifyStatus")]
                [Validation(Required=false)]
                public string ModifyStatus { get; set; }

                /// <summary>
                /// <para>The time when the pg_hba.conf file was modified. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-25T06:00:40Z</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The reason why the modification failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("StatusReason")]
                [Validation(Required=false)]
                public string StatusReason { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of modification records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LogItemCount")]
        [Validation(Required=false)]
        public int? LogItemCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D797E6B-E157-510C-A27F-6F9E6DA40633</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
