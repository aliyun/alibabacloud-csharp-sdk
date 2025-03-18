// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20210114.Models
{
    public class DescribeScreenEmerRiskResponseBody : TeaModel {
        [NameInMap("CloudHcRiskItems")]
        [Validation(Required=false)]
        public List<DescribeScreenEmerRiskResponseBodyCloudHcRiskItems> CloudHcRiskItems { get; set; }
        public class DescribeScreenEmerRiskResponseBodyCloudHcRiskItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AffectCount")]
            [Validation(Required=false)]
            public int? AffectCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ASAP</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("VulName")]
            [Validation(Required=false)]
            public string VulName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23AD0BD2-8771-5647-819E-6xxxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
