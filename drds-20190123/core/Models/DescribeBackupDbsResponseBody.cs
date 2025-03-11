// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupDbsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about a database.</para>
        /// </summary>
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public DescribeBackupDbsResponseBodyDbNames DbNames { get; set; }
        public class DescribeBackupDbsResponseBodyDbNames : TeaModel {
            [NameInMap("dbName")]
            [Validation(Required=false)]
            public List<string> DbName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>842DFA7F-B09B-42A2-B115-E684AE******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
