// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The container application that is protected from being tampered with.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ContainerWebDefenseApplicationDTOS")]
        [Validation(Required=false)]
        public List<OperateApplicationRequestContainerWebDefenseApplicationDTOS> ContainerWebDefenseApplicationDTOS { get; set; }
        public class OperateApplicationRequestContainerWebDefenseApplicationDTOS : TeaModel {
            /// <summary>
            /// <para>The ID of the cluster to which the container belongs.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to query the cluster ID.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ceb68cc58234141828677e383bd21ff0c</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>Specifies whether to apply the configuration to the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>add</b>: applied</description></item>
            /// <item><description><b>del</b>: not applied</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// <para>The application ID. If the application is newly added, you do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>196</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The value of the application tag.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app:app-003</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The ID of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300566</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
