// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class UpdateEventsAttentionRequest : TeaModel {
        /// <summary>
        /// <para>Sensitivity of the anomalous activity. Valid values are -1 to 3. A value of -1 decreases sensitivity by 1 degree, and a value of 0 increases sensitivity by 1 degree.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public int? Mode { get; set; }

        /// <summary>
        /// <para>Scope of effect: cluster or edge zone</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster</para>
        /// </summary>
        [NameInMap("range")]
        [Validation(Required=false)]
        public string Range { get; set; }

        /// <summary>
        /// <para>UUID corresponding to the anomalous activity</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03de78af-f49f-433d-b5b1-0f6a70c493ba</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
