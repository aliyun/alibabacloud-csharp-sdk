// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SubmitOperationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// <remarks>
        /// <para>Call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to obtain the check item ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The task dimension for the submitted operation task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INSTANCE: instance dimension</description></item>
        /// <item><description>CHECK_ID: check item dimension</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CHECK_ID</para>
        /// </summary>
        [NameInMap("DimensionType")]
        [Validation(Required=false)]
        public string DimensionType { get; set; }

        /// <summary>
        /// <para>The asset information required to submit instance tasks.</para>
        /// </summary>
        [NameInMap("OperationTaskInstances")]
        [Validation(Required=false)]
        public List<SubmitOperationTaskRequestOperationTaskInstances> OperationTaskInstances { get; set; }
        public class SubmitOperationTaskRequestOperationTaskInstances : TeaModel {
            /// <summary>
            /// <para>The instance ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-uf6533m4vuo3oa33****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The task ID to roll back when performing a rollback task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7d0b10e35e80c9e5ebac5f1054****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The asset vendor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Alibaba Cloud asset</description></item>
            /// <item><description><b>1</b>: asset outside the cloud</description></item>
            /// <item><description><b>2</b>: IDC asset</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: asset from another cloud provider</description></item>
            /// <item><description><b>8</b>: lightweight asset</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The relation key associated with cross-page selection when submitting the operation.</para>
        /// <remarks>
        /// <para>Call the <a href="~~CreateAssetSelectionConfig~~">CreateAssetSelectionConfig</a> operation and use the BusinessType field to obtain the relation key.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CSPM_OPERATION_RELATION_KEY_173***</para>
        /// </summary>
        [NameInMap("RelationKey")]
        [Validation(Required=false)]
        public string RelationKey { get; set; }

        /// <summary>
        /// <para>The temporary parameters required for the remediation task.</para>
        /// </summary>
        [NameInMap("RepairTempParam")]
        [Validation(Required=false)]
        public List<SubmitOperationTaskRequestRepairTempParam> RepairTempParam { get; set; }
        public class SubmitOperationTaskRequestRepairTempParam : TeaModel {
            /// <summary>
            /// <para>The name of the temporary remediation parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPPort</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The value of the temporary remediation parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1XX.1XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The task type for the submitted task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>REPAIR: remediation task</description></item>
        /// <item><description>ROLLBACK: rollback task</description></item>
        /// </list>
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
