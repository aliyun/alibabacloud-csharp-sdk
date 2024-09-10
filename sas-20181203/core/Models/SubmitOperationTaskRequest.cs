// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SubmitOperationTaskRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        [NameInMap("DimensionType")]
        [Validation(Required=false)]
        public string DimensionType { get; set; }

        [NameInMap("OperationTaskInstances")]
        [Validation(Required=false)]
        public List<SubmitOperationTaskRequestOperationTaskInstances> OperationTaskInstances { get; set; }
        public class SubmitOperationTaskRequestOperationTaskInstances : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        [NameInMap("RepairTempParam")]
        [Validation(Required=false)]
        public List<SubmitOperationTaskRequestRepairTempParam> RepairTempParam { get; set; }
        public class SubmitOperationTaskRequestRepairTempParam : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
