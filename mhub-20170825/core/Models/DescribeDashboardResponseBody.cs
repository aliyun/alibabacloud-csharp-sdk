// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mhub20170825.Models
{
    public class DescribeDashboardResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;success&quot;:true,
        ///     &quot;model&quot;:{
        ///         &quot;perfMonthCount&quot;:0,
        ///         &quot;compatibilityMonthCount&quot;:0,
        ///         &quot;perfLastMonthCount&quot;:0,
        ///         &quot;compatibilityLastMonthCount&quot;:0,
        ///         &quot;automationMonthCount&quot;:0,
        ///         &quot;automationLastMonthCount&quot;:0
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4CC30A8F-787C-55CA-87A6-7D1BED56067E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
