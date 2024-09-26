// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableChangeLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaTableChangeLogResponseBodyData Data { get; set; }
        public class GetMetaTableChangeLogResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of instances.</para>
            /// </summary>
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<GetMetaTableChangeLogResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class GetMetaTableChangeLogResponseBodyDataDataEntityList : TeaModel {
                /// <summary>
                /// <para>The content of the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;[{\&quot;action\&quot;:\&quot;ADD_COLUMN\&quot;,\&quot;value\&quot;:[{\&quot;originName\&quot;:\&quot;\&quot;,\&quot;originType\&quot;:\&quot;\&quot;,\&quot;originComment\&quot;:\&quot;\&quot;,\&quot;name\&quot;:\&quot;id\&quot;,\&quot;type\&quot;:\&quot;struct<a href="name:string">name:string</a>\&quot;,\&quot;comment\&quot;:\&quot;\&quot;}]}]&quot;,</para>
                /// </summary>
                [NameInMap("ChangeContent")]
                [Validation(Required=false)]
                public string ChangeContent { get; set; }

                /// <summary>
                /// <para>The type of the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE_TABLE</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public string ChangeType { get; set; }

                /// <summary>
                /// <para>The time when the metatable was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590722845000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the metatable was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590722845000</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public long? ModifiedTime { get; set; }

                /// <summary>
                /// <para>The entity on which the change was made. Valid values: TABLE and PARTITION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TABLE</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>The name of the operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of metatables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1ec92159376</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
