// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetAutomaticFrequencyControlConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The action taken on requests that trigger the control. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>observe</b>: Requests are monitored.</para>
        /// </description></item>
        /// <item><description><para><b>deny</b>: Requests are blocked.</para>
        /// </description></item>
        /// <item><description><para><b>js</b>: JS challenges are issued.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>js</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic frequency control is enabled. Valid values:</para>
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
        /// <item><description><para><b>loose</b>: Loose protection.</para>
        /// </description></item>
        /// <item><description><para><b>normal</b>: Normal protection.</para>
        /// </description></item>
        /// <item><description><para><b>strict</b>: Strict protection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F32C57AA-7BF8-49AE-A2CC-9F42390F5A19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
