// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SubmitHotExpandTaskRequest : TeaModel {
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TaskDesc")]
        [Validation(Required=false)]
        public string TaskDesc { get; set; }

        [NameInMap("InstanceDbMapping")]
        [Validation(Required=false)]
        public List<SubmitHotExpandTaskRequestInstanceDbMapping> InstanceDbMapping { get; set; }
        public class SubmitHotExpandTaskRequestInstanceDbMapping : TeaModel {
            [NameInMap("DbList")]
            [Validation(Required=false)]
            public string DbList { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        [NameInMap("Mapping")]
        [Validation(Required=false)]
        public List<SubmitHotExpandTaskRequestMapping> Mapping { get; set; }
        public class SubmitHotExpandTaskRequestMapping : TeaModel {
            [NameInMap("HotDbName")]
            [Validation(Required=false)]
            public string HotDbName { get; set; }

            [NameInMap("ShardTbValue")]
            [Validation(Required=false)]
            public string ShardTbValue { get; set; }

            [NameInMap("HotTableName")]
            [Validation(Required=false)]
            public string HotTableName { get; set; }

            [NameInMap("ShardDbValue")]
            [Validation(Required=false)]
            public string ShardDbValue { get; set; }

            [NameInMap("TbShardColumn")]
            [Validation(Required=false)]
            public string TbShardColumn { get; set; }

            [NameInMap("DbShardColumn")]
            [Validation(Required=false)]
            public string DbShardColumn { get; set; }

            [NameInMap("LogicTable")]
            [Validation(Required=false)]
            public string LogicTable { get; set; }

        }

        [NameInMap("SupperAccountMapping")]
        [Validation(Required=false)]
        public List<SubmitHotExpandTaskRequestSupperAccountMapping> SupperAccountMapping { get; set; }
        public class SubmitHotExpandTaskRequestSupperAccountMapping : TeaModel {
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("SupperAccount")]
            [Validation(Required=false)]
            public string SupperAccount { get; set; }

            [NameInMap("SupperPassword")]
            [Validation(Required=false)]
            public string SupperPassword { get; set; }

        }

        [NameInMap("ExtendedMapping")]
        [Validation(Required=false)]
        public List<SubmitHotExpandTaskRequestExtendedMapping> ExtendedMapping { get; set; }
        public class SubmitHotExpandTaskRequestExtendedMapping : TeaModel {
            [NameInMap("SrcDb")]
            [Validation(Required=false)]
            public string SrcDb { get; set; }

            [NameInMap("SrcInstanceId")]
            [Validation(Required=false)]
            public string SrcInstanceId { get; set; }

        }

    }

}
