// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOperationCheckResponseBody : TeaModel {
        [NameInMap("OperationTaskInstanceDetails")]
        [Validation(Required=false)]
        public List<ListOperationCheckResponseBodyOperationTaskInstanceDetails> OperationTaskInstanceDetails { get; set; }
        public class ListOperationCheckResponseBodyOperationTaskInstanceDetails : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>58</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lb-2zefdwrre8ey8ewr0****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Repair")]
            [Validation(Required=false)]
            public List<ListOperationCheckResponseBodyOperationTaskInstanceDetailsRepair> Repair { get; set; }
            public class ListOperationCheckResponseBodyOperationTaskInstanceDetailsRepair : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1719923175000</para>
                /// </summary>
                [NameInMap("OperateTime")]
                [Validation(Required=false)]
                public long? OperateTime { get; set; }

                [NameInMap("RepairConfigs")]
                [Validation(Required=false)]
                public List<ListOperationCheckResponseBodyOperationTaskInstanceDetailsRepairRepairConfigs> RepairConfigs { get; set; }
                public class ListOperationCheckResponseBodyOperationTaskInstanceDetailsRepairRepairConfigs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cd7c4d34c1034de08308535d6cee***</para>
                    /// </summary>
                    [NameInMap("FlowId")]
                    [Validation(Required=false)]
                    public string FlowId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>IpList</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>IP List</para>
                    /// </summary>
                    [NameInMap("ShowName")]
                    [Validation(Required=false)]
                    public string ShowName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{\&quot;type\&quot;:\&quot;STRING\&quot;,\&quot;range\&quot;:[0,64]}</para>
                    /// </summary>
                    [NameInMap("TypeDefine")]
                    [Validation(Required=false)]
                    public string TypeDefine { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>192.168.1XX.1XX</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>REPAIR_SUCCESS_VERIFIED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>repair success verified</para>
                /// </summary>
                [NameInMap("StatusShowName")]
                [Validation(Required=false)]
                public string StatusShowName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6a829841e335b0fb6e0014463284****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>REPAIR</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A3D7C47D-3F11-57BB-90E8-E5C20C61****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
