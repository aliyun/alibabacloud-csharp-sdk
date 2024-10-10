// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SubmitOperationTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CHECK_ID</para>
        /// </summary>
        [NameInMap("DimensionType")]
        [Validation(Required=false)]
        public string DimensionType { get; set; }

        [NameInMap("OperationTaskInstances")]
        [Validation(Required=false)]
        public List<SubmitOperationTaskRequestOperationTaskInstances> OperationTaskInstances { get; set; }
        public class SubmitOperationTaskRequestOperationTaskInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>i-uf6533m4vuo3oa33****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7d0b10e35e80c9e5ebac5f1054****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        [NameInMap("RelationKey")]
        [Validation(Required=false)]
        public string RelationKey { get; set; }

        [NameInMap("RepairTempParam")]
        [Validation(Required=false)]
        public List<SubmitOperationTaskRequestRepairTempParam> RepairTempParam { get; set; }
        public class SubmitOperationTaskRequestRepairTempParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>IPPort</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.1XX.1XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REPAIR</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
