// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetInventorySchemaResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that was used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gAAAAABfh8MVLQI9AuKGACLgjbsXbWs-Mna47IDM6tr6wK7TZ1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89117642-7167-4F4D-B7F1-876582279E3E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The detailed configurations of the configuration list.</para>
        /// </summary>
        [NameInMap("Schemas")]
        [Validation(Required=false)]
        public List<GetInventorySchemaResponseBodySchemas> Schemas { get; set; }
        public class GetInventorySchemaResponseBodySchemas : TeaModel {
            /// <summary>
            /// <para>The properties of the configuration list.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<GetInventorySchemaResponseBodySchemasAttributes> Attributes { get; set; }
            public class GetInventorySchemaResponseBodySchemasAttributes : TeaModel {
                /// <summary>
                /// <para>The data type of the property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The name of the property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApplicationType</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The name of the configuration list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS:Application</para>
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

            /// <summary>
            /// <para>The version of the configuration list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
