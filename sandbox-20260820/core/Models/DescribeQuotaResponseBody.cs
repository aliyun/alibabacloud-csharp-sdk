// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class DescribeQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message. A value of success indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The quota configuration information.</para>
        /// </summary>
        [NameInMap("quota")]
        [Validation(Required=false)]
        public Quota Quota { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ADFF8D8-D4BA-5F79-AD49-DDABFEA59B6C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The current quota usage of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;cpuCores&quot;:1,&quot;memoryGB&quot;:1.5,&quot;instanceCount&quot;:1}</para>
        /// </summary>
        [NameInMap("usage")]
        [Validation(Required=false)]
        public QuotaUsage Usage { get; set; }

    }

}
