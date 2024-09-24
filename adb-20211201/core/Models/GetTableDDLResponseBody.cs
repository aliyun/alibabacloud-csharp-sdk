// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetTableDDLResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>863D51B7-5321-41D8-A0B6-A088B0******</para>
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
