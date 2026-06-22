// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleUnknownThreatDetectEventRequest : TeaModel {
        /// <summary>
        /// <para>The list of event IDs.</para>
        /// </summary>
        [NameInMap("EventIdList")]
        [Validation(Required=false)]
        public List<string> EventIdList { get; set; }

        /// <summary>
        /// <para>The event handling status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Unhandled.</description></item>
        /// <item><description><b>2</b>: Blocked.</description></item>
        /// <item><description><b>3</b>: Ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
