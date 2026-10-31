// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDirectoryTreeResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The directory tree information. The directory tree and all edge information are returned through a level-order traversal starting from the root node.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDirectoryTreeResponseBodyData> Data { get; set; }
        public class GetDirectoryTreeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The child nodes.</para>
            /// </summary>
            [NameInMap("Children")]
            [Validation(Required=false)]
            public GetDirectoryTreeResponseBodyDataChildren Children { get; set; }
            public class GetDirectoryTreeResponseBodyDataChildren : TeaModel {
                /// <summary>
                /// <para>The directory type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>codeManage</para>
                /// </summary>
                [NameInMap("CategoryType")]
                [Validation(Required=false)]
                public string CategoryType { get; set; }

                /// <summary>
                /// <para>The ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000907</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The data cell ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>41342</para>
                /// </summary>
                [NameInMap("DataCellId")]
                [Validation(Required=false)]
                public long? DataCellId { get; set; }

                /// <summary>
                /// <para>The directory path. This parameter is valid only for file or resource nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("DirName")]
                [Validation(Required=false)]
                public string DirName { get; set; }

                /// <summary>
                /// <para>The creation time. This parameter is empty for non-entity object nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-01 18:08:17</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time. This parameter is empty for non-entity object nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-01 18:08:17</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The directory ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ID of the last modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000907</para>
                /// </summary>
                [NameInMap("LastModifier")]
                [Validation(Required=false)]
                public string LastModifier { get; set; }

                /// <summary>
                /// <para>The name of the last modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
                /// </summary>
                [NameInMap("LastModifierName")]
                [Validation(Required=false)]
                public string LastModifierName { get; set; }

                /// <summary>
                /// <para>The display name of the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Code management</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7081229106458752</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The string ID of the directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("StringId")]
                [Validation(Required=false)]
                public string StringId { get; set; }

                /// <summary>
                /// <para>The object type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>codeManage</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The parent node.</para>
            /// </summary>
            [NameInMap("Parent")]
            [Validation(Required=false)]
            public GetDirectoryTreeResponseBodyDataParent Parent { get; set; }
            public class GetDirectoryTreeResponseBodyDataParent : TeaModel {
                /// <summary>
                /// <para>The directory type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>codeManage</para>
                /// </summary>
                [NameInMap("CategoryType")]
                [Validation(Required=false)]
                public string CategoryType { get; set; }

                /// <summary>
                /// <para>The ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000907</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The data cell ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3213</para>
                /// </summary>
                [NameInMap("DataCellId")]
                [Validation(Required=false)]
                public long? DataCellId { get; set; }

                /// <summary>
                /// <para>The directory path. This parameter is valid only for file or resource nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("DirName")]
                [Validation(Required=false)]
                public string DirName { get; set; }

                /// <summary>
                /// <para>The creation time. This parameter is empty for non-entity object nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-01 18:08:17</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time. This parameter is empty for non-entity object nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-01 18:08:17</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The directory ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ID of the last modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000907</para>
                /// </summary>
                [NameInMap("LastModifier")]
                [Validation(Required=false)]
                public string LastModifier { get; set; }

                /// <summary>
                /// <para>The name of the last modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
                /// </summary>
                [NameInMap("LastModifierName")]
                [Validation(Required=false)]
                public string LastModifierName { get; set; }

                /// <summary>
                /// <para>The display name of the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Code management</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7081229106458752</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The string ID of the directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("StringId")]
                [Validation(Required=false)]
                public string StringId { get; set; }

                /// <summary>
                /// <para>The object type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>codeManage</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
