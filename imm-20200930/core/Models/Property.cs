// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Property : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>float</para>
        /// </summary>
        [NameInMap("ItemsType")]
        [Validation(Required=false)]
        public string ItemsType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>channels</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[40, 80, 160, 320]</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>array</para>
        /// </summary>
        [NameInMap("ValueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

    }

}
