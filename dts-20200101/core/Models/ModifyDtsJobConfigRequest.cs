// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDtsJobConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>lxsn87r328d****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;module\&quot;:\&quot;07\&quot;,\&quot;name\&quot;:\&quot;sink.connection.idle.second\&quot;,\&quot;value\&quot;:60},{\&quot;module\&quot;:\&quot;07\&quot;,\&quot;name\&quot;:\&quot;sink.batch.size.maximum\&quot;,\&quot;value\&quot;:64}]</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
