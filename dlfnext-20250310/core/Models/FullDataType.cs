// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class FullDataType : TeaModel {
        /// <summary>
        /// <para>The data type.</para>
        /// </summary>
        [NameInMap("element")]
        [Validation(Required=false)]
        public FullDataType Element { get; set; }

        /// <summary>
        /// <para>The list of field definitions. This parameter is required when <c>type</c> is <c>ROW</c>.</para>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<DataField> Fields { get; set; }

        /// <summary>
        /// <para>The data type of the key. This parameter is required when <c>type</c> is <c>MAP</c>.</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public FullDataType Key { get; set; }

        /// <summary>
        /// <para>The data type. This parameter is required when <c>type</c> is <c>ARRAY</c> or <c>MULTISET</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STRING</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The data type of the value. This parameter is required when <c>type</c> is <c>MAP</c>.</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public FullDataType Value { get; set; }

    }

}
