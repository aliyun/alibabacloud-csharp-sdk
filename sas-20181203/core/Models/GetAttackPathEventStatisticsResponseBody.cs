// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAttackPathEventStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. The China Chinese Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89AD16CC-97EE-50F3-9B12-9E28E5C8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of attack paths that require immediate handling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SeriousPathRiskNum")]
        [Validation(Required=false)]
        public long? SeriousPathRiskNum { get; set; }

        /// <summary>
        /// <para>The number of risky assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalAssetRiskNum")]
        [Validation(Required=false)]
        public long? TotalAssetRiskNum { get; set; }

        /// <summary>
        /// <para>The number of risky paths.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPathRiskNum")]
        [Validation(Required=false)]
        public long? TotalPathRiskNum { get; set; }

    }

}
