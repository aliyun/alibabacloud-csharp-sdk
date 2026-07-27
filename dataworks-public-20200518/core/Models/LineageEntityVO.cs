// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class LineageEntityVO : TeaModel {
        /// <summary>
        /// <para>A map of additional key-value attributes for the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>attribute map</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// <para>A URL for more details about the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://domain.test.url/entity">http://domain.test.url/entity</a></para>
        /// </summary>
        [NameInMap("DetailUrl")]
        [Validation(Required=false)]
        public string DetailUrl { get; set; }

        /// <summary>
        /// <para>The type of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The human-readable name of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tableName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The owner of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>owner</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The name of the entity\&quot;s parent container, such as a database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbName</para>
        /// </summary>
        [NameInMap("ParentName")]
        [Validation(Required=false)]
        public string ParentName { get; set; }

        /// <summary>
        /// <para>The unique, fully qualified name of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table.projectName.tablename</para>
        /// </summary>
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

    }

}
