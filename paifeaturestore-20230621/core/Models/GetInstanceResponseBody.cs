// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetInstanceResponseBody : TeaModel {
        [NameInMap("FeatureDBInfo")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyFeatureDBInfo FeatureDBInfo { get; set; }
        public class GetInstanceResponseBodyFeatureDBInfo : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        [NameInMap("FeatureDBInstanceInfo")]
        [Validation(Required=false)]
        [Obsolete]
        public GetInstanceResponseBodyFeatureDBInstanceInfo FeatureDBInstanceInfo { get; set; }
        public class GetInstanceResponseBodyFeatureDBInstanceInfo : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-07-04T11:26:09.036+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-07-04T11:26:09.036+08:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public double? Progress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1C5B1511-8A5B-59C3-90AF-513F9210E882</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
