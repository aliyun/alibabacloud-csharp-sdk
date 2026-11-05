// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOperationCheckRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// <remarks>
        /// <para>Call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to retrieve this parameter.
        /// This parameter is required. If this parameter is not provided, the operation returns the CspmParamIllegal (invalid parameter) error.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The timestamp of the end time of the queried task. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719923175001</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: zh. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The information about the instances to be operated.</para>
        /// <remarks>
        /// <para>The information about each instance must include Vendor, RegionId, and InstanceId. You must provide at least one instance. If no instance is provided or the value is empty, the operation returns the CspmParamIllegal (invalid parameter) error.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OperationTaskInstances")]
        [Validation(Required=false)]
        public List<ListOperationCheckRequestOperationTaskInstances> OperationTaskInstances { get; set; }
        public class ListOperationCheckRequestOperationTaskInstances : TeaModel {
            /// <summary>
            /// <para>The instance ID of the cloud asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-bp1642ib4bg2bm****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The vendor of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALIYUN</b>: Alibaba Cloud</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The timestamp of the start time of the queried task. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719923175000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>REPAIR</b>: repair task</description></item>
        /// <item><description><b>ROLLBACK</b>: rollback task</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the value is invalid, the default value REPAIR is used.</para>
        /// </remarks>
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
