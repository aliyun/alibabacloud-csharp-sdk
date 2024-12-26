// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetCreateTableSQLResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>109462AF-B5FA-3D5A-9377-B27E5B******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create table (
        ///  id varchar(32)
        /// );</para>
        /// </summary>
        [NameInMap("SQL")]
        [Validation(Required=false)]
        public string SQL { get; set; }

    }

}
