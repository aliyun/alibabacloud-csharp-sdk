// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class GetMultimodeCmsUrlResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hb-t4naqsay5gn******</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>htpp://***********</para>
        /// </summary>
        [NameInMap("MultimodCmsUrl")]
        [Validation(Required=false)]
        public string MultimodCmsUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>44183B05-852E-4716-B902-52977140190F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
