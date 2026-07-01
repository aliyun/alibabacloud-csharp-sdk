// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetDatabasesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database. If you do not specify this parameter, information about all databases in the catalog is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>paimon-ods</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

    }

}
