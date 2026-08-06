// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetKgEntityResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The entity record details.</para>
        /// </summary>
        [NameInMap("EntityInfo")]
        [Validation(Required=false)]
        public GetKgEntityResponseBodyEntityInfo EntityInfo { get; set; }
        public class GetKgEntityResponseBodyEntityInfo : TeaModel {
            /// <summary>
            /// <para>The entity record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc-xxx</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The entity type code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Company</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <para>The list of entity record properties.</para>
            /// </summary>
            [NameInMap("PropertyList")]
            [Validation(Required=false)]
            public List<GetKgEntityResponseBodyEntityInfoPropertyList> PropertyList { get; set; }
            public class GetKgEntityResponseBodyEntityInfoPropertyList : TeaModel {
                /// <summary>
                /// <para>The property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>company_name</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property data type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>STRING: string</description></item>
                /// <item><description>INTEGER: integer</description></item>
                /// <item><description>FLOAT: floating-point number</description></item>
                /// <item><description>BOOLEAN: Boolean</description></item>
                /// <item><description>DATE: date</description></item>
                /// <item><description>LIST: list</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The property value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
