// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UpdatePropertyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the property that you want to modify. You can call the <a href="https://help.aliyun.com/document_detail/410890.html">ListProperty</a> operation to query the property ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>390</para>
        /// </summary>
        [NameInMap("PropertyId")]
        [Validation(Required=false)]
        public long? PropertyId { get; set; }

        /// <summary>
        /// <para>The new property name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testkey</para>
        /// </summary>
        [NameInMap("PropertyKey")]
        [Validation(Required=false)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// <para>The values of property.</para>
        /// </summary>
        [NameInMap("PropertyValues")]
        [Validation(Required=false)]
        public List<UpdatePropertyRequestPropertyValues> PropertyValues { get; set; }
        public class UpdatePropertyRequestPropertyValues : TeaModel {
            /// <summary>
            /// <para>The new property value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testvalue</para>
            /// </summary>
            [NameInMap("PropertyValue")]
            [Validation(Required=false)]
            public string PropertyValue { get; set; }

            /// <summary>
            /// <para>The ID of property value that you want to modify. You can call the <a href="https://help.aliyun.com/document_detail/410890.html">ListProperty</a> operation to query the property value ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>978</para>
            /// </summary>
            [NameInMap("PropertyValueId")]
            [Validation(Required=false)]
            public long? PropertyValueId { get; set; }

        }

    }

}
