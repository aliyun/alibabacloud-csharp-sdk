// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListSupportResourceTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the next query is required.</para>
        /// <list type="bullet">
        /// <item><description>If the value of this parameter is empty, all results are returned, and the next query is not required.</description></item>
        /// <item><description>If the value of this parameter is not empty, the next query is required, and the value is the token used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAYws9fJ0Ur4MGm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABC71772-F3A1-59CA-B811-4A5B0E0B72F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The supported resource types.</para>
        /// </summary>
        [NameInMap("SupportResourceTypes")]
        [Validation(Required=false)]
        public List<ListSupportResourceTypesResponseBodySupportResourceTypes> SupportResourceTypes { get; set; }
        public class ListSupportResourceTypesResponseBodySupportResourceTypes : TeaModel {
            [NameInMap("ArnTemplate")]
            [Validation(Required=false)]
            public string ArnTemplate { get; set; }

            /// <summary>
            /// <para>The service code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The supported tag-related capability items.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the <c>ShowItems</c> parameter is set to <c>true</c>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("SupportItems")]
            [Validation(Required=false)]
            public List<ListSupportResourceTypesResponseBodySupportResourceTypesSupportItems> SupportItems { get; set; }
            public class ListSupportResourceTypesResponseBodySupportResourceTypesSupportItems : TeaModel {
                /// <summary>
                /// <para>Indicates whether the tag-related capability item is supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Support")]
                [Validation(Required=false)]
                public bool? Support { get; set; }

                /// <summary>
                /// <para>The code of the tag-related capability item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TAG_CONSOLE_SUPPORT</para>
                /// </summary>
                [NameInMap("SupportCode")]
                [Validation(Required=false)]
                public string SupportCode { get; set; }

                /// <summary>
                /// <para>The details of the support for the tag-related capability item.</para>
                /// </summary>
                [NameInMap("SupportDetails")]
                [Validation(Required=false)]
                public List<Dictionary<string, string>> SupportDetails { get; set; }

            }

        }

    }

}
