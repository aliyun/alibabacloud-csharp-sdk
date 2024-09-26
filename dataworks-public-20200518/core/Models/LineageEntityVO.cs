// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class LineageEntityVO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>attribute map</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://domain.test.url/entity">http://domain.test.url/entity</a></para>
        /// </summary>
        [NameInMap("DetailUrl")]
        [Validation(Required=false)]
        public string DetailUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>maxcompute-table</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tableName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>owner</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dbName</para>
        /// </summary>
        [NameInMap("ParentName")]
        [Validation(Required=false)]
        public string ParentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>maxcompute-table.projectName.tablename</para>
        /// </summary>
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

    }

}
