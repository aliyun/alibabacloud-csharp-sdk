// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class SampleBase : TeaModel {
        [NameInMap("FullSampleDeviceIds")]
        [Validation(Required=false)]
        public List<FullSampleItem> FullSampleDeviceIds { get; set; }

        [NameInMap("FullSampleUsers")]
        [Validation(Required=false)]
        public List<FullSampleItem> FullSampleUsers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>event</para>
        /// </summary>
        [NameInMap("SampleMethod")]
        [Validation(Required=false)]
        public string SampleMethod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public float? SampleRate { get; set; }

    }

}
