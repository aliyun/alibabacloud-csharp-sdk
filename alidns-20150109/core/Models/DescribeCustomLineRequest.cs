// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCustomLineRequest : TeaModel {
        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The unique ID of the custom line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>597</para>
        /// </summary>
        [NameInMap("LineId")]
        [Validation(Required=false)]
        public long? LineId { get; set; }

    }

}
