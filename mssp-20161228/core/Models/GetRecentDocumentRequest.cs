// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetRecentDocumentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DateType")]
        [Validation(Required=false)]
        public string DateType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        [NameInMap("SuspEventSource")]
        [Validation(Required=false)]
        public string SuspEventSource { get; set; }

    }

}
