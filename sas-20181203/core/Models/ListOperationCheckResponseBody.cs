// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOperationCheckResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the operation instances.</para>
        /// </summary>
        [NameInMap("OperationTaskInstanceDetails")]
        [Validation(Required=false)]
        public List<ListOperationCheckResponseBodyOperationTaskInstanceDetails> OperationTaskInstanceDetails { get; set; }
        public class ListOperationCheckResponseBodyOperationTaskInstanceDetails : TeaModel {
            /// <summary>
            /// <para>The check item ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>58</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-2zefdwrre8ey8ewr0****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The information about the fix task.</para>
            /// </summary>
            [NameInMap("Repair")]
            [Validation(Required=false)]
            public List<ListOperationCheckResponseBodyOperationTaskInstanceDetailsRepair> Repair { get; set; }
            public class ListOperationCheckResponseBodyOperationTaskInstanceDetailsRepair : TeaModel {
                /// <summary>
                /// <para>The timestamp when the risk was handled. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719923175000</para>
                /// </summary>
                [NameInMap("OperateTime")]
                [Validation(Required=false)]
                public long? OperateTime { get; set; }

                /// <summary>
                /// <para>The configuration information for the fix.</para>
                /// </summary>
                [NameInMap("RepairConfigs")]
                [Validation(Required=false)]
                public List<ListOperationCheckResponseBodyOperationTaskInstanceDetailsRepairRepairConfigs> RepairConfigs { get; set; }
                public class ListOperationCheckResponseBodyOperationTaskInstanceDetailsRepairRepairConfigs : TeaModel {
                    /// <summary>
                    /// <para>The ID of the fix flow corresponding to the fix operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cd7c4d34c1034de08308535d6cee***</para>
                    /// </summary>
                    [NameInMap("FlowId")]
                    [Validation(Required=false)]
                    public string FlowId { get; set; }

                    /// <summary>
                    /// <para>The name of the fix parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IpList</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The display name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IP List</para>
                    /// </summary>
                    [NameInMap("ShowName")]
                    [Validation(Required=false)]
                    public string ShowName { get; set; }

                    /// <summary>
                    /// <para>The JSON string of the custom configuration item type for the check item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;type\&quot;:\&quot;STRING\&quot;,\&quot;range\&quot;:[0,64]}</para>
                    /// </summary>
                    [NameInMap("TypeDefine")]
                    [Validation(Required=false)]
                    public string TypeDefine { get; set; }

                    /// <summary>
                    /// <para>The real-time value of the parameter for the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.1XX.1XX</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The status of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REPAIR_SUCCESS_VERIFIED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The display name of the fix task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>repair success verified</para>
                /// </summary>
                [NameInMap("StatusShowName")]
                [Validation(Required=false)]
                public string StatusShowName { get; set; }

                /// <summary>
                /// <para>The task ID of the operation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6a829841e335b0fb6e0014463284****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <para>The operation type of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>REPAIR</b>: fix task</description></item>
            /// <item><description><b>ROLLBACK</b>: rollback task</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REPAIR</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3D7C47D-3F11-57BB-90E8-E5C20C61****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
