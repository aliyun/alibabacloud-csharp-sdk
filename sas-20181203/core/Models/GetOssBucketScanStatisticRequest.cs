// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOssBucketScanStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The list of bucket names.</para>
        /// </summary>
        [NameInMap("BucketNameList")]
        [Validation(Required=false)]
        public List<string> BucketNameList { get; set; }

        /// <summary>
        /// <para>The data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>API</b>: API-based scan.</description></item>
        /// <item><description><b>OSS</b>: OSS-based scan.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
