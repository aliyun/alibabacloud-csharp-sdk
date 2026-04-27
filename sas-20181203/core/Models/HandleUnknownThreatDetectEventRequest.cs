// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleUnknownThreatDetectEventRequest : TeaModel {
        [NameInMap("EventIdList")]
        [Validation(Required=false)]
        public List<string> EventIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
