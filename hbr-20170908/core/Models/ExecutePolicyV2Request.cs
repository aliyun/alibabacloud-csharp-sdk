// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class ExecutePolicyV2Request : TeaModel {
        /// <summary>
        /// <para>Data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1************dtv</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>Policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000************hky</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>Rule ID, limited to executing rules of <b>RuleType</b> <b>BACKUP</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-0002*****ux8</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>Data source type, with the value range as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>UDM_ECS</b>: Represents ECS full machine backup.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UDM_ECS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
