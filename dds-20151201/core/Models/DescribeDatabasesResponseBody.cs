// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDatabasesResponseBody : TeaModel {
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public DescribeDatabasesResponseBodyDatabases Databases { get; set; }
        public class DescribeDatabasesResponseBodyDatabases : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<string> Database { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>009D2572-6839-43C0-8D89-44DB46CBA2EA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
