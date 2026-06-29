// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class BatchAssignSeatsRequest : TeaModel {
        /// <summary>
        /// <para>The list of target member IDs.</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// <para>The language. Valid values: zh-CN and en-US.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

        /// <summary>
        /// <para>The seat type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard: standard seat</description></item>
        /// <item><description>pro: pro seat</description></item>
        /// <item><description>max: premium seat</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("SeatType")]
        [Validation(Required=false)]
        public string SeatType { get; set; }

    }

}
