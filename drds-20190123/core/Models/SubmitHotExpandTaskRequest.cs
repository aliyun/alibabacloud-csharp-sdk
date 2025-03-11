// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SubmitHotExpandTaskRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drdshbga1138****</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>The information about the database on which you want to perform hot-spot scale-out.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ExtendedMapping")]
        [Validation(Required=false)]
        public List<SubmitHotExpandTaskRequestExtendedMapping> ExtendedMapping { get; set; }
        public class SubmitHotExpandTaskRequestExtendedMapping : TeaModel {
            /// <summary>
            /// <para>The name of the source physical database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SrcDb")]
            [Validation(Required=false)]
            public string SrcDb { get; set; }

            /// <summary>
            /// <para>The ID of the ApsaraDB RDS instance to which the source physical database belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1t1mk5a5bdj****</para>
            /// </summary>
            [NameInMap("SrcInstanceId")]
            [Validation(Required=false)]
            public string SrcInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The information about the instance to which the hot-spot database belongs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceDbMapping")]
        [Validation(Required=false)]
        public List<SubmitHotExpandTaskRequestInstanceDbMapping> InstanceDbMapping { get; set; }
        public class SubmitHotExpandTaskRequestInstanceDbMapping : TeaModel {
            /// <summary>
            /// <para>The name of the hot-spot database.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hot_test_****_****</para>
            /// </summary>
            [NameInMap("DbList")]
            [Validation(Required=false)]
            public string DbList { get; set; }

            /// <summary>
            /// <para>The name of the ApsaraDB RDS instance to which the hot-spot database belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1t1mk5a5bdj****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        /// <summary>
        /// <para>The information about the hot-spot database.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mapping")]
        [Validation(Required=false)]
        public List<SubmitHotExpandTaskRequestMapping> Mapping { get; set; }
        public class SubmitHotExpandTaskRequestMapping : TeaModel {
            /// <summary>
            /// <para>The shard key used to split the database to which the associated table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>platform</para>
            /// </summary>
            [NameInMap("DbShardColumn")]
            [Validation(Required=false)]
            public string DbShardColumn { get; set; }

            /// <summary>
            /// <para>The name of the hot-spot database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hot_test_****_****</para>
            /// </summary>
            [NameInMap("HotDbName")]
            [Validation(Required=false)]
            public string HotDbName { get; set; }

            /// <summary>
            /// <para>The name of the hot-spot table. The name must be prefixed with the name of a logical table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_table_*****</para>
            /// </summary>
            [NameInMap("HotTableName")]
            [Validation(Required=false)]
            public string HotTableName { get; set; }

            /// <summary>
            /// <para>The name of the logical table on which you want to perform hot-spot scale-out.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_table</para>
            /// </summary>
            [NameInMap("LogicTable")]
            [Validation(Required=false)]
            public string LogicTable { get; set; }

            /// <summary>
            /// <para>The value of the shard key used to split a database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ShardDbValue")]
            [Validation(Required=false)]
            public string ShardDbValue { get; set; }

            /// <summary>
            /// <para>The value of the shard key used to split a table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ShardTbValue")]
            [Validation(Required=false)]
            public string ShardTbValue { get; set; }

            /// <summary>
            /// <para>The shard key used to split an associated table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>platform</para>
            /// </summary>
            [NameInMap("TbShardColumn")]
            [Validation(Required=false)]
            public string TbShardColumn { get; set; }

        }

        /// <summary>
        /// <para>The information about the privileged account.</para>
        /// </summary>
        [NameInMap("SupperAccountMapping")]
        [Validation(Required=false)]
        public List<SubmitHotExpandTaskRequestSupperAccountMapping> SupperAccountMapping { get; set; }
        public class SubmitHotExpandTaskRequestSupperAccountMapping : TeaModel {
            /// <summary>
            /// <para>The ID of the ApsaraDB RDS instance that has the privileged account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1t1mk5a5bdj****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The name of the privileged account of the ApsaraDB RDS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SupperAccount")]
            [Validation(Required=false)]
            public string SupperAccount { get; set; }

            /// <summary>
            /// <para>The password of the privileged account of the ApsaraDB RDS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11111111</para>
            /// </summary>
            [NameInMap("SupperPassword")]
            [Validation(Required=false)]
            public string SupperPassword { get; set; }

        }

        /// <summary>
        /// <para>The description of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TaskDesc")]
        [Validation(Required=false)]
        public string TaskDesc { get; set; }

        /// <summary>
        /// <para>The name of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
