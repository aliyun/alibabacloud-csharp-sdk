// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetViewDDLResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>421794A3-72A5-5D27-9E8B-A75A4C503E17</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE VIEW <c>test</c>.<c>test_view</c> AS SELECT
        ///   <c>id</c>
        /// , <c>name</c>
        /// FROM
        ///   <c>test_tbl_adb</c></para>
        /// </summary>
        [NameInMap("SQL")]
        [Validation(Required=false)]
        public string SQL { get; set; }

    }

}
