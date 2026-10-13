// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeDSEntityResponseBody : TeaModel {
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
        /// <para>The ID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123231</para>
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// <para>The name of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// <para>The entity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// <para>The entity name. Only Chinese characters, uppercase and lowercase letters, digits, and underscores are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BookType</para>
        /// </summary>
        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// <para>The entity type. Valid values: synonyms (synonym) and regex (regular expression).</para>
        /// 
        /// <b>Example:</b>
        /// <para>synonyms</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The modification time in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-08-12T16:00:01Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The unique identifier of the modifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123231</para>
        /// </summary>
        [NameInMap("ModifyUserId")]
        [Validation(Required=false)]
        public string ModifyUserId { get; set; }

        /// <summary>
        /// <para>The name of the modifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad23234dsf234fga</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The system entity code, such as sys.date. This parameter is empty for user entities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sys.date</para>
        /// </summary>
        [NameInMap("SysEntityCode")]
        [Validation(Required=false)]
        public string SysEntityCode { get; set; }

    }

}
