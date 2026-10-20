// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetAutomaticFrequencyControlConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The action to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>observe</b>: Monitor.</description></item>
        /// <item><description><b>deny</b>: Block.</description></item>
        /// <item><description><b>js</b>: JavaScript Challenge.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>js</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>The protection level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>loose</b>: Loose.</description></item>
        /// <item><description><b>normal</b>: Medium.</description></item>
        /// <item><description><b>strict</b>: Strict.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F32C57AA-7BF8-49AE-A2CC-9F42390F5A19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
