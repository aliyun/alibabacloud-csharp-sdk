// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SubmitHotExpandTaskRequest : TeaModel {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The information about the database on which you want to perform hot-spot scale-out.
        /// </summary>
        [NameInMap("ExtendedMapping")]
        [Validation(Required=false)]
        public List<SubmitHotExpandTaskRequestExtendedMapping> ExtendedMapping { get; set; }
        public class SubmitHotExpandTaskRequestExtendedMapping : TeaModel {
            /// <summary>
            /// The name of the source physical database.
            /// </summary>
            [NameInMap("SrcDb")]
            [Validation(Required=false)]
            public string SrcDb { get; set; }

            /// <summary>
            /// The ID of the ApsaraDB RDS instance to which the source physical database belongs.
            /// </summary>
            [NameInMap("SrcInstanceId")]
            [Validation(Required=false)]
            public string SrcInstanceId { get; set; }

        }

        /// <summary>
        /// The information about the instance to which the hot-spot database belongs.
        /// </summary>
        [NameInMap("InstanceDbMapping")]
        [Validation(Required=false)]
        public List<SubmitHotExpandTaskRequestInstanceDbMapping> InstanceDbMapping { get; set; }
        public class SubmitHotExpandTaskRequestInstanceDbMapping : TeaModel {
            /// <summary>
            /// The name of the hot-spot database.
            /// </summary>
            [NameInMap("DbList")]
            [Validation(Required=false)]
            public string DbList { get; set; }

            /// <summary>
            /// The name of the ApsaraDB RDS instance to which the hot-spot database belongs.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        /// <summary>
        /// The information about the hot-spot database.
        /// </summary>
        [NameInMap("Mapping")]
        [Validation(Required=false)]
        public List<SubmitHotExpandTaskRequestMapping> Mapping { get; set; }
        public class SubmitHotExpandTaskRequestMapping : TeaModel {
            /// <summary>
            /// The shard key used to split the database to which the associated table belongs.
            /// </summary>
            [NameInMap("DbShardColumn")]
            [Validation(Required=false)]
            public string DbShardColumn { get; set; }

            /// <summary>
            /// The name of the hot-spot database.
            /// </summary>
            [NameInMap("HotDbName")]
            [Validation(Required=false)]
            public string HotDbName { get; set; }

            /// <summary>
            /// The name of the hot-spot table. The name must be prefixed with the name of a logical table.
            /// </summary>
            [NameInMap("HotTableName")]
            [Validation(Required=false)]
            public string HotTableName { get; set; }

            /// <summary>
            /// The name of the logical table on which you want to perform hot-spot scale-out.
            /// </summary>
            [NameInMap("LogicTable")]
            [Validation(Required=false)]
            public string LogicTable { get; set; }

            /// <summary>
            /// The value of the shard key used to split a database.
            /// </summary>
            [NameInMap("ShardDbValue")]
            [Validation(Required=false)]
            public string ShardDbValue { get; set; }

            /// <summary>
            /// The value of the shard key used to split a table.
            /// </summary>
            [NameInMap("ShardTbValue")]
            [Validation(Required=false)]
            public string ShardTbValue { get; set; }

            /// <summary>
            /// The shard key used to split an associated table.
            /// </summary>
            [NameInMap("TbShardColumn")]
            [Validation(Required=false)]
            public string TbShardColumn { get; set; }

        }

        /// <summary>
        /// The information about the privileged account.
        /// </summary>
        [NameInMap("SupperAccountMapping")]
        [Validation(Required=false)]
        public List<SubmitHotExpandTaskRequestSupperAccountMapping> SupperAccountMapping { get; set; }
        public class SubmitHotExpandTaskRequestSupperAccountMapping : TeaModel {
            /// <summary>
            /// The ID of the ApsaraDB RDS instance that has the privileged account.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The name of the privileged account of the ApsaraDB RDS instance.
            /// </summary>
            [NameInMap("SupperAccount")]
            [Validation(Required=false)]
            public string SupperAccount { get; set; }

            /// <summary>
            /// The password of the privileged account of the ApsaraDB RDS instance.
            /// </summary>
            [NameInMap("SupperPassword")]
            [Validation(Required=false)]
            public string SupperPassword { get; set; }

        }

        /// <summary>
        /// The description of the task.
        /// </summary>
        [NameInMap("TaskDesc")]
        [Validation(Required=false)]
        public string TaskDesc { get; set; }

        /// <summary>
        /// The name of the task.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
