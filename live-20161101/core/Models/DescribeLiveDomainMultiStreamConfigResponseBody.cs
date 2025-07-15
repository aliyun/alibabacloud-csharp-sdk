// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainMultiStreamConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F486A44F-6B35-5A96-BF2C-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the dual-stream disaster recovery feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled</description></item>
        /// <item><description><b>off</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Switch")]
        [Validation(Required=false)]
        public string Switch { get; set; }

    }

}
