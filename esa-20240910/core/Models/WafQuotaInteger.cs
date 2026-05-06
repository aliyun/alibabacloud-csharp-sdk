// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafQuotaInteger : TeaModel {
        /// <summary>
        /// <para>Is equal to</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Equal")]
        [Validation(Required=false)]
        public int? Equal { get; set; }

        /// <summary>
        /// <para>Is greater than</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GreaterThan")]
        [Validation(Required=false)]
        public int? GreaterThan { get; set; }

        /// <summary>
        /// <para>Is greater than or equal to</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GreaterThanOrEqual")]
        [Validation(Required=false)]
        public int? GreaterThanOrEqual { get; set; }

        /// <summary>
        /// <para>Is less than</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LessThan")]
        [Validation(Required=false)]
        public int? LessThan { get; set; }

        /// <summary>
        /// <para>Is less than or equal to</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LessThanOrEqual")]
        [Validation(Required=false)]
        public int? LessThanOrEqual { get; set; }

    }

}
