// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInvadeEventStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of open high-risk vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HighOpenEventCnt")]
        [Validation(Required=false)]
        public int? HighOpenEventCnt { get; set; }

        /// <summary>
        /// <para>The number of open low-risk vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LowOpenEventCnt")]
        [Validation(Required=false)]
        public int? LowOpenEventCnt { get; set; }

        /// <summary>
        /// <para>The number of open medium-risk vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MiddleOpenEventCnt")]
        [Validation(Required=false)]
        public int? MiddleOpenEventCnt { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1530A01A-6901-5B72-AB88-28B6E96B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of open vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalOpenEventCnt")]
        [Validation(Required=false)]
        public int? TotalOpenEventCnt { get; set; }

    }

}
