// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetDatabasesRequest : TeaModel {
        /// <summary>
        /// <para>The database name. If this parameter is left empty, information about all databases is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>paimon-ods</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

    }

}
