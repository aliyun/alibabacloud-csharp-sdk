// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyQosRuleRequest : TeaModel {
        /// <summary>
        /// <para>The maximum downstream bandwidth. The unit is Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Download")]
        [Validation(Required=false)]
        public int? Download { get; set; }

        /// <summary>
        /// <para>The ID of the QoS rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-5605u0gelk200****</para>
        /// </summary>
        [NameInMap("QosRuleId")]
        [Validation(Required=false)]
        public string QosRuleId { get; set; }

        /// <summary>
        /// <para>The name of the QoS rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("QosRuleName")]
        [Validation(Required=false)]
        public string QosRuleName { get; set; }

        /// <summary>
        /// <para>The maximum upstream bandwidth. The unit is Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Upload")]
        [Validation(Required=false)]
        public int? Upload { get; set; }

    }

}
