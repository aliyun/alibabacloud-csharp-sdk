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

        /// <summary>
        /// <para>Log information list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVpnSslServerLogsResponseBodyData Data { get; set; }
        public class DescribeVpnSslServerLogsResponseBodyData : TeaModel {
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<string> Logs { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the log is accurate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: accurate</description></item>
        /// <item><description><b>false</b>: inaccurate</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsCompleted")]
        [Validation(Required=false)]
        public bool? IsCompleted { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEDAC5B1-9292-5BF7-BDDF-61BA58CFB2FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
