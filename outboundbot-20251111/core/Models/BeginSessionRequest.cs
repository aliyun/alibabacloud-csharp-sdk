// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class BeginSessionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use the draft version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DraftVersion")]
        [Validation(Required=false)]
        public bool? DraftVersion { get; set; }

        /// <summary>
        /// <para>The instance identity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance-example-001</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>script-example-001</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The accompanying variables for the scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;city&quot;:&quot;Tangshan&quot;}</para>
        /// </summary>
        [NameInMap("VendorParams")]
        [Validation(Required=false)]
        public string VendorParams { get; set; }

    }

}
