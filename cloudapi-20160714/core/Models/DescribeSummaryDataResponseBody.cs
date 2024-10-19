// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeSummaryDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of subscription dedicated instances that expire in 14 days or less.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExpireInstanceNum")]
        [Validation(Required=false)]
        public int? ExpireInstanceNum { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ004</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of APIs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UsageApiNum")]
        [Validation(Required=false)]
        public int? UsageApiNum { get; set; }

        /// <summary>
        /// <para>The number of API groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsageGroupNum")]
        [Validation(Required=false)]
        public int? UsageGroupNum { get; set; }

        /// <summary>
        /// <para>The number of running dedicated instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsageInstanceNum")]
        [Validation(Required=false)]
        public int? UsageInstanceNum { get; set; }

    }

}
