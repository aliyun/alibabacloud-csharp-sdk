// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ListPropertyResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that is used for the next query. If this parameter is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The information about the properties.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public List<ListPropertyResponseBodyProperties> Properties { get; set; }
        public class ListPropertyResponseBodyProperties : TeaModel {
            /// <summary>
            /// <para>The ID of the property.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PropertyId")]
            [Validation(Required=false)]
            public long? PropertyId { get; set; }

            /// <summary>
            /// <para>The name of the property.</para>
            /// 
            /// <b>Example:</b>
            /// <para>department</para>
            /// </summary>
            [NameInMap("PropertyKey")]
            [Validation(Required=false)]
            public string PropertyKey { get; set; }

            /// <summary>
            /// <para>Details about the property values.</para>
            /// </summary>
            [NameInMap("PropertyValues")]
            [Validation(Required=false)]
            public List<ListPropertyResponseBodyPropertiesPropertyValues> PropertyValues { get; set; }
            public class ListPropertyResponseBodyPropertiesPropertyValues : TeaModel {
                /// <summary>
                /// <para>The value of the property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("PropertyValue")]
                [Validation(Required=false)]
                public string PropertyValue { get; set; }

                /// <summary>
                /// <para>The ID of the property value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("PropertyValueId")]
                [Validation(Required=false)]
                public long? PropertyValueId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
