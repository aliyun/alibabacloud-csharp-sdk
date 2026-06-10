// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListDSEntityResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of entities.</para>
        /// </summary>
        [NameInMap("Entities")]
        [Validation(Required=false)]
        public List<ListDSEntityResponseBodyEntities> Entities { get; set; }
        public class ListDSEntityResponseBodyEntities : TeaModel {
            /// <summary>
            /// <para>The creation time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-12T16:00:01Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123231</para>
            /// </summary>
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }

            /// <summary>
            /// <para>The name of the user who created the entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <para>The ID of the entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234564567445</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public long? EntityId { get; set; }

            /// <summary>
            /// <para>The entity name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>书实体</para>
            /// </summary>
            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            /// <summary>
            /// <para>The entity type. Valid values: <c>synonyms</c>, <c>regex</c>, and <c>system</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>synonyms</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <para>The update time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-12T16:00:01Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who last modified the entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123231</para>
            /// </summary>
            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public string ModifyUserId { get; set; }

            /// <summary>
            /// <para>The name of the user who last modified the entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

            /// <summary>
            /// <para>The code for the system entity, such as <c>sys_date</c>. This parameter is blank for custom entities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sys_date</para>
            /// </summary>
            [NameInMap("SysEntityCode")]
            [Validation(Required=false)]
            public string SysEntityCode { get; set; }

        }

        /// <summary>
        /// <para>The current page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga4h345defgwet2sdf223</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of matching entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
