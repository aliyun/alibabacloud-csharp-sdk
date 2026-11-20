// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ClientDTO : TeaModel {
        /// <summary>
        /// <para>The company address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The authorization management configuration in the format of {&quot;model_ids&quot;:[...],&quot;group_ids&quot;:[...]}. An empty value indicates that group authorization is not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;model_ids&quot;:[1,2],&quot;group_ids&quot;:[&quot;mg_xxx&quot;]}</para>
        /// </summary>
        [NameInMap("allowedModelGroupConfig")]
        [Validation(Required=false)]
        public string AllowedModelGroupConfig { get; set; }

        /// <summary>
        /// <para>The list of allowed model IDs, separated by commas. An empty value indicates all models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("allowedModels")]
        [Validation(Required=false)]
        public string AllowedModels { get; set; }

        /// <summary>
        /// <para>The customer UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>st-xxxx</para>
        /// </summary>
        [NameInMap("clientUuid")]
        [Validation(Required=false)]
        public string ClientUuid { get; set; }

        /// <summary>
        /// <para>The contact information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13800138000</para>
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public string Contact { get; set; }

        /// <summary>
        /// <para>The status. A value of 0 indicates enabled, and a non-zero value indicates disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("deleteTag")]
        [Validation(Required=false)]
        public int? DeleteTag { get; set; }

        /// <summary>
        /// <para>The discount factor. A value of 1.0 indicates no discount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("discount")]
        [Validation(Required=false)]
        public double? Discount { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The hierarchy level. Valid values: 1 to 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        /// <summary>
        /// <para>The account type. A value of 0 indicates a main account, and a value of 1 indicates a regular account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("main")]
        [Validation(Required=false)]
        public int? Main { get; set; }

        /// <summary>
        /// <para>The customer name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My customer</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The node type. Valid values: department: Department. user: User node, which is a leaf in the department tree.</para>
        /// 
        /// <b>Example:</b>
        /// <para>department</para>
        /// </summary>
        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The parent department ID. An empty value indicates the top level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Remarks</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The user ID. This field has a value only when the node type is user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
