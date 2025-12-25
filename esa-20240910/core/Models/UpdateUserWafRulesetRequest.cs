// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateUserWafRulesetRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ip.src == 1.1.1.1</para>
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-xxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public long? Position { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[
        ///   {
        ///     &quot;Id&quot;: 20000001,
        ///     &quot;Name&quot;: &quot;rule1&quot;,
        ///     &quot;Expression&quot;: &quot;ip.src eq 1.1.1.1&quot;,
        ///     &quot;Action&quot;: &quot;deny&quot;
        ///   }</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<WafRuleConfig> Rules { get; set; }

        [NameInMap("Shared")]
        [Validation(Required=false)]
        public WafBatchRuleShared Shared { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
