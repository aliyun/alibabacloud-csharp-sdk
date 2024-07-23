// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UpdateAccessPageStateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>a-06xnr5lyp77e7****</para>
        /// </summary>
        [NameInMap("AccessPageId")]
        [Validation(Required=false)]
        public string AccessPageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AccessPageState")]
        [Validation(Required=false)]
        public int? AccessPageState { get; set; }

    }

}
