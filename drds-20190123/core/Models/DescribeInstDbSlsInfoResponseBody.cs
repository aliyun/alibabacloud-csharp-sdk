// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstDbSlsInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the SQL audit.</para>
        /// </summary>
        [NameInMap("AuditInfo")]
        [Validation(Required=false)]
        public DescribeInstDbSlsInfoResponseBodyAuditInfo AuditInfo { get; set; }
        public class DescribeInstDbSlsInfoResponseBodyAuditInfo : TeaModel {
            /// <summary>
            /// <para>The name of the LogStore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// <para>The name of the Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC3ABA3E-0F8A-4596-9104-F5155C******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
