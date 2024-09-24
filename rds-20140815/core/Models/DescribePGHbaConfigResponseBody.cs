// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribePGHbaConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1*****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The default configuration items of the pg_hba.conf file.</para>
        /// </summary>
        [NameInMap("DefaultHbaItems")]
        [Validation(Required=false)]
        public DescribePGHbaConfigResponseBodyDefaultHbaItems DefaultHbaItems { get; set; }
        public class DescribePGHbaConfigResponseBodyDefaultHbaItems : TeaModel {
            [NameInMap("HbaItem")]
            [Validation(Required=false)]
            public List<DescribePGHbaConfigResponseBodyDefaultHbaItemsHbaItem> HbaItem { get; set; }
            public class DescribePGHbaConfigResponseBodyDefaultHbaItemsHbaItem : TeaModel {
                /// <summary>
                /// <para>The IP addresses from which the specified users can access the specified databases. The value is fixed as 0.0.0.0/0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0.0/0</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The names of the databases that the specified users are allowed to access. The value is fixed as all or replication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The mask of the instance. The value is fixed as null.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                /// <summary>
                /// <para>The authentication method. The value is fixed as md5.</para>
                /// 
                /// <b>Example:</b>
                /// <para>md5</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The value of this parameter is based on the value of the Method parameter. The value is fixed as null.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Option")]
                [Validation(Required=false)]
                public string Option { get; set; }

                /// <summary>
                /// <para>The priority of the configuration items in the pg_hba.conf file. This value is automatically generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PriorityId")]
                [Validation(Required=false)]
                public int? PriorityId { get; set; }

                /// <summary>
                /// <para>The type of connection to the instance. The value is fixed as host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>host</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The user that is allowed to access the instance. The value is fixed as all.</para>
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
        /// <para>The time when the previous modification was made to the pg_hba.conf file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-25T06:00:40Z</para>
        /// </summary>
        [NameInMap("HbaModifyTime")]
        [Validation(Required=false)]
        public string HbaModifyTime { get; set; }

        /// <summary>
        /// <para>The status of the previous modification to the pg_hba.conf file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b></description></item>
        /// <item><description><b>setting</b></description></item>
        /// <item><description><b>failed</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("LastModifyStatus")]
        [Validation(Required=false)]
        public string LastModifyStatus { get; set; }

        /// <summary>
        /// <para>The reason why the previous modification was made to the pg_hba.conf file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified users (testuser) is not exist.</para>
        /// </summary>
        [NameInMap("ModifyStatusReason")]
        [Validation(Required=false)]
        public string ModifyStatusReason { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A147A124-A147-5CCF-9609-B73C028848DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The current configuration items of the pg_hba.conf file.</para>
        /// </summary>
        [NameInMap("RunningHbaItems")]
        [Validation(Required=false)]
        public DescribePGHbaConfigResponseBodyRunningHbaItems RunningHbaItems { get; set; }
        public class DescribePGHbaConfigResponseBodyRunningHbaItems : TeaModel {
            [NameInMap("HbaItem")]
            [Validation(Required=false)]
            public List<DescribePGHbaConfigResponseBodyRunningHbaItemsHbaItem> HbaItem { get; set; }
            public class DescribePGHbaConfigResponseBodyRunningHbaItemsHbaItem : TeaModel {
                /// <summary>
                /// <para>The IP address of the client.</para>
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
                /// <para>The value of this parameter varies based on the value of the Method parameter. The value is fixed as null.</para>
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
                /// <para>3</para>
                /// </summary>
                [NameInMap("PriorityId")]
                [Validation(Required=false)]
                public int? PriorityId { get; set; }

                /// <summary>
                /// <para>The connection type. Valor:</para>
                /// <list type="bullet">
                /// <item><description><b>host</b>: The record matches TCP/IP connections, including SSL connections and non-SSL connections.</description></item>
                /// <item><description><b>hostssl</b>: The record matches only TCP/IP connections that are established over SSL.</description></item>
                /// <item><description><b>hostnossl</b>: The record matches only TCP/IP connections that are not established over SSL connections.</description></item>
                /// </list>
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

    }

}
