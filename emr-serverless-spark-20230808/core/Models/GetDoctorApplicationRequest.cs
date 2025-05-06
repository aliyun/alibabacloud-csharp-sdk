// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetDoctorApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The language of diagnostic information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

        /// <summary>
        /// <para>The query time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01</para>
        /// </summary>
        [NameInMap("queryTime")]
        [Validation(Required=false)]
        public string QueryTime { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
