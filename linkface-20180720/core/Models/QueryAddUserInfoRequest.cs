// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkFace20180720.Models
{
    public class QueryAddUserInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>testdevice</para>
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mjgfPDJtjpPieDeK7HJn001015af00</para>
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testproduct</para>
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
