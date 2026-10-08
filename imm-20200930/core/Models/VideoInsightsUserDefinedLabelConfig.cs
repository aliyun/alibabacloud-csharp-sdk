// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoInsightsUserDefinedLabelConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable custom labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The list of custom labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<InsightsLabel> Labels { get; set; }

        /// <summary>
        /// <para>The custom label matching mode. The SDK passes this as an optional string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enhanced</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

    }

}
