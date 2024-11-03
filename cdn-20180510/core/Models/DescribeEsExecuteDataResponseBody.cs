// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeEsExecuteDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the script.</para>
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<DescribeEsExecuteDataResponseBodyContents> Contents { get; set; }
        public class DescribeEsExecuteDataResponseBodyContents : TeaModel {
            /// <summary>
            /// <para>The time and column names in the table that shows the status of the script.</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<string> Columns { get; set; }

            /// <summary>
            /// <para>The name of the table that shows the status of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Exception</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of timestamps and values in the corresponding columns of the table that shows the status of the script.</para>
            /// </summary>
            [NameInMap("Points")]
            [Validation(Required=false)]
            public List<string> Points { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99D61AB3-6164-4CF2-A0DE-129C9B07618B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
