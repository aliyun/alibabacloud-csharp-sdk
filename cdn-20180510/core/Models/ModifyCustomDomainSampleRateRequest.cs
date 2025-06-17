// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ModifyCustomDomainSampleRateRequest : TeaModel {
        [NameInMap("BaseConfigID")]
        [Validation(Required=false)]
        public string BaseConfigID { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public float? SampleRate { get; set; }

        [NameInMap("SinkID")]
        [Validation(Required=false)]
        public long? SinkID { get; set; }

    }

}
