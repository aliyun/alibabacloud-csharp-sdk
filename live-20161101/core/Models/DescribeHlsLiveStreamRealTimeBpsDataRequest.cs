// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeHlsLiveStreamRealTimeBpsDataRequest : TeaModel {
        /// <summary>
        /// <para>The domain names to query. Separate them with commas (,). A domain name cannot contain double-byte characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live.aiyun.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-08-08T00:00:00Z</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
