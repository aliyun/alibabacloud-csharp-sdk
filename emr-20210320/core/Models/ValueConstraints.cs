// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ValueConstraints : TeaModel {
        /// <summary>
        /// <para>默认值。</para>
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public int? DefaultValue { get; set; }

        /// <summary>
        /// <para>结束值。</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public int? End { get; set; }

        /// <summary>
        /// <para>起始值。</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

        /// <summary>
        /// <para>步长。</para>
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public int? Step { get; set; }

        /// <summary>
        /// <para>值限制类型。</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>枚举值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<int?> Values { get; set; }

    }

}
