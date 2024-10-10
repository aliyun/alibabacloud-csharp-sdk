// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class PublishWebApplicationRevisionInput : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Containers")]
        [Validation(Required=false)]
        public List<Container> Containers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test version</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnableArmsMetrics")]
        [Validation(Required=false)]
        public bool? EnableArmsMetrics { get; set; }

        [NameInMap("TakeEffect")]
        [Validation(Required=false)]
        public bool? TakeEffect { get; set; }

    }

}
