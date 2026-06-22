// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFixUsedCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1CE824-7F80-546D-8AF8-4A5209F9B698</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of vulnerability fixes used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UsedCount")]
        [Validation(Required=false)]
        public int? UsedCount { get; set; }

        /// <summary>
        /// <para>The number of vulnerability fixes used in regions in the Chinese mainland.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("UsedCountCn")]
        [Validation(Required=false)]
        public int? UsedCountCn { get; set; }

        /// <summary>
        /// <para>The number of vulnerability fixes used in regions outside the Chinese mainland.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("UsedCountSg")]
        [Validation(Required=false)]
        public int? UsedCountSg { get; set; }

    }

}
