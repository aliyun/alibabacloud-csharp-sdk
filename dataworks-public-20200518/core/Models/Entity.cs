// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class Entity : TeaModel {
        /// <summary>
        /// <para>The properties of the entity, including:</para>
        /// <list type="bullet">
        /// <item><description><b>entityType</b>: The type of the entity. Examples: maxcompute-table and emr-table.</description></item>
        /// <item><description><b>name</b>: the name of the entity.</description></item>
        /// <item><description><b>projectName</b>: the name of the MaxCompute project.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("EntityContent")]
        [Validation(Required=false)]
        public Dictionary<string, object> EntityContent { get; set; }

        /// <summary>
        /// <para>The unique identifier of the entity. Example: maxcompute-table.projectA.tableB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute_table.563f0357118d05ef145d6bddf2966cc23e86ca8f2f013f915e565afdf09f7a23</para>
        /// </summary>
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
