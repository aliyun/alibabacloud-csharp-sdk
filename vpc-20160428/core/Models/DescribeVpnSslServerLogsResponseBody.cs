// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnSslServerLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of log entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVpnSslServerLogsResponseBodyData Data { get; set; }
        public class DescribeVpnSslServerLogsResponseBodyData : TeaModel {
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<string> Logs { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the queried logs are accurate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Accurate.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Not accurate.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsCompleted")]
        [Validation(Required=false)]
        public bool? IsCompleted { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEDAC5B1-9292-5BF7-BDDF-61BA58CFB2FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
