// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOperationCheckRequest : TeaModel {
        /// <summary>
        /// <para>Check item ID.</para>
        /// <remarks>
        /// <para>Obtain this parameter by calling the <a href="~~ListCheckResult~~">ListCheckResult</a> interface.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>Timestamp (in milliseconds) of the end time of the queried task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719923175001</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Language type for request and response messages, default value is zh. Values:</para>
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
        /// <para>Information about the operated instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OperationTaskInstances")]
        [Validation(Required=false)]
        public List<ListOperationCheckRequestOperationTaskInstances> OperationTaskInstances { get; set; }
        public class ListOperationCheckRequestOperationTaskInstances : TeaModel {
            /// <summary>
            /// <para>Cloud asset instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-bp1642ib4bg2bm****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Asset vendor. Values:</para>
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
        /// <para>Timestamp (in milliseconds) of the start time of the queried task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719923175000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Task type corresponding to the task:</para>
        /// <list type="bullet">
        /// <item><description><b>REPAIR</b>: Repair task</description></item>
        /// <item><description><b>ROLLBACK</b>: Rollback task</description></item>
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
