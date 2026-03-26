// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class LabelInfo : TeaModel {
        /// <summary>
        /// <para>Key of Label</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>Value of Label</para>
        /// 
        /// <b>Example:</b>
        /// <para>value</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
