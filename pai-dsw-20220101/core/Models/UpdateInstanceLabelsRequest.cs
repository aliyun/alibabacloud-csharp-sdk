// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class UpdateInstanceLabelsRequest : TeaModel {
        /// <summary>
        /// <para>The tags that you want to update.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<UpdateInstanceLabelsRequestLabels> Labels { get; set; }
        public class UpdateInstanceLabelsRequestLabels : TeaModel {
            /// <summary>
            /// <para>The key of the custom tag.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customLabelKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the custom tag.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>labelValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
