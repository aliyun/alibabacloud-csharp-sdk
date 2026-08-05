// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainFrameRateAndBitRateDataRequest : TeaModel {
        /// <summary>
        /// <para>The ingest domain.</para>
        /// <remarks>
        /// <para>Make sure that the domain name added to ApsaraVideo Live and that you have the permissions to manage the domain name.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The time to query. The time is in UTC. Format: <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-21T08:00:00Z</para>
        /// </summary>
        [NameInMap("QueryTime")]
        [Validation(Required=false)]
        public string QueryTime { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
