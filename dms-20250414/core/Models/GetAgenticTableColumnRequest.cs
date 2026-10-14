// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetAgenticTableColumnRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the database to which the table belongs. You can obtain the UUID by calling the ListAgenticDatabase or SearchAgenticDatabase operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>md-HZ-fp9K7r***</para>
        /// </summary>
        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        /// <summary>
        /// <para>The fully qualified name of the table. You can obtain the name from the QualifiedName parameter returned by the ListAgenticTableBaseInfo operation. You must specify the complete name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>orders</para>
        /// </summary>
        [NameInMap("TableQualifiedName")]
        [Validation(Required=false)]
        public string TableQualifiedName { get; set; }

    }

}
