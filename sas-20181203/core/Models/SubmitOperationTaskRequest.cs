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
        /// <para> You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to obtain the ID of the check item.</para>
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
        /// <para>The dimension of the task that you want to submit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Instance dimension: INSTANCE</description></item>
        /// <item><description>Check item dimension: CHECK_ID</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CHECK_ID</para>
        /// </summary>
        [NameInMap("DimensionType")]
        [Validation(Required=false)]
        public string DimensionType { get; set; }

        /// <summary>
        /// <para>The asset information required to submit the tasks for instances.</para>
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
            /// <para>The ID of the task that you want to roll back</para>
            /// 
            /// <b>Example:</b>
            /// <para>7d0b10e35e80c9e5ebac5f1054****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The service provider of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: an asset provided by Alibaba Cloud.</description></item>
            /// <item><description><b>1</b>: an asset outside Alibaba Cloud.</description></item>
            /// <item><description><b>2</b>: an asset in a data center.</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: an asset from a third-party cloud service provider.</description></item>
            /// <item><description><b>8</b>: a lightweight asset.</description></item>
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
        /// <para>提交操作关联的跨页选择关联Key。</para>
        /// <remarks>
        /// <para>您可调用<a href="~~CreateAssetSelectionConfig~~">CreateAssetSelectionConfig</a>接口BusinessType字段获取关联Key。</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CSPM_OPERATION_RELATION_KEY_173***</para>
        /// </summary>
        [NameInMap("RelationKey")]
        [Validation(Required=false)]
        public string RelationKey { get; set; }

        /// <summary>
        /// <para>The temporary parameters required for the repair task.</para>
        /// </summary>
        [NameInMap("RepairTempParam")]
        [Validation(Required=false)]
        public List<SubmitOperationTaskRequestRepairTempParam> RepairTempParam { get; set; }
        public class SubmitOperationTaskRequestRepairTempParam : TeaModel {
            /// <summary>
            /// <para>The name of the temporary repair parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPPort</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The value of the temporary repair parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1XX.1XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the task that you want to submit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Repair task: REPAIR</description></item>
        /// <item><description>Rollback task: ROLLBACK</description></item>
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
