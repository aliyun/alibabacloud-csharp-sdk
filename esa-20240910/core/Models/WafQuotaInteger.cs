// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafQuotaInteger : TeaModel {
        /// <summary>
        /// <para>等于。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Equal")]
        [Validation(Required=false)]
        public int? Equal { get; set; }

        /// <summary>
        /// <para>大于。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GreaterThan")]
        [Validation(Required=false)]
        public int? GreaterThan { get; set; }

        /// <summary>
        /// <para>大于等于。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GreaterThanOrEqual")]
        [Validation(Required=false)]
        public int? GreaterThanOrEqual { get; set; }

        /// <summary>
        /// <para>小于。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LessThan")]
        [Validation(Required=false)]
        public int? LessThan { get; set; }

        /// <summary>
        /// <para>小于等于。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LessThanOrEqual")]
        [Validation(Required=false)]
        public int? LessThanOrEqual { get; set; }

    }

}
