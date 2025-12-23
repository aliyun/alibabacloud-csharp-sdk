// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateIpcOrderRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>understand</para>
        /// </summary>
        [NameInMap("Capability")]
        [Validation(Required=false)]
        public string Capability { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d123</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

    }

}
