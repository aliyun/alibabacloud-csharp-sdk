// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class HyperParameterRange : TeaModel {
        /// <summary>
        /// <para>Hyperparameter enumeration list.</para>
        /// </summary>
        [NameInMap("Enum")]
        [Validation(Required=false)]
        public List<string> Enum { get; set; }

        /// <summary>
        /// <para>Whether the maximum value is exclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ExclusiveMaximum")]
        [Validation(Required=false)]
        public bool? ExclusiveMaximum { get; set; }

        /// <summary>
        /// <para>Whether the minimum value is exclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ExclusiveMinimum")]
        [Validation(Required=false)]
        public bool? ExclusiveMinimum { get; set; }

        /// <summary>
        /// <para>Maximum length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxLength")]
        [Validation(Required=false)]
        public long? MaxLength { get; set; }

        /// <summary>
        /// <para>Maximum value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Maximum")]
        [Validation(Required=false)]
        public string Maximum { get; set; }

        /// <summary>
        /// <para>Minimum length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinLength")]
        [Validation(Required=false)]
        public long? MinLength { get; set; }

        /// <summary>
        /// <para>Minimum value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Minimum")]
        [Validation(Required=false)]
        public string Minimum { get; set; }

        /// <summary>
        /// <para>Regular expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>^\+?[1-9][0-9]*$</para>
        /// </summary>
        [NameInMap("Pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

    }

}
