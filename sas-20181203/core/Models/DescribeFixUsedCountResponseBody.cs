// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFixUsedCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1CE824-7F80-546D-8AF8-4A5209F9B698</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of vulnerabilities that are fixed by the vulnerability fixing feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UsedCount")]
        [Validation(Required=false)]
        public int? UsedCount { get; set; }

        /// <summary>
        /// <para>The number of vulnerabilities that are fixed by the vulnerability fixing feature in China.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("UsedCountCn")]
        [Validation(Required=false)]
        public int? UsedCountCn { get; set; }

        /// <summary>
        /// <para>The number of vulnerabilities that are fixed by the vulnerability fixing feature outside China.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("UsedCountSg")]
        [Validation(Required=false)]
        public int? UsedCountSg { get; set; }

    }

}
