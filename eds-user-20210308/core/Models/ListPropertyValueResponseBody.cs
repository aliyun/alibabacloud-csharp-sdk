// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ListPropertyValueResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about property values.</para>
        /// </summary>
        [NameInMap("PropertyValueInfos")]
        [Validation(Required=false)]
        public List<ListPropertyValueResponseBodyPropertyValueInfos> PropertyValueInfos { get; set; }
        public class ListPropertyValueResponseBodyPropertyValueInfos : TeaModel {
            /// <summary>
            /// <para>The value of the property.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HR</para>
            /// </summary>
            [NameInMap("PropertyValue")]
            [Validation(Required=false)]
            public string PropertyValue { get; set; }

            /// <summary>
            /// <para>The ID of the property value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>978</para>
            /// </summary>
            [NameInMap("PropertyValueId")]
            [Validation(Required=false)]
            public long? PropertyValueId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C52013A5-3422-5D1F-B22C-A57110972AD9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
