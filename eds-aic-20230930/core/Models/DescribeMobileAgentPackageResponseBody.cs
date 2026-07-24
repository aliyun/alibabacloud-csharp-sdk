// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeMobileAgentPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of package information.</para>
        /// </summary>
        [NameInMap("PackageList")]
        [Validation(Required=false)]
        public List<DescribeMobileAgentPackageResponseBodyPackageList> PackageList { get; set; }
        public class DescribeMobileAgentPackageResponseBodyPackageList : TeaModel {
            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-30 00:00:00</para>
            /// </summary>
            [NameInMap("ExpiredAt")]
            [Validation(Required=false)]
            public string ExpiredAt { get; set; }

            /// <summary>
            /// <para>The list of node instance IDs.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>The credit quota of the package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8000</para>
            /// </summary>
            [NameInMap("PackageCredit")]
            [Validation(Required=false)]
            public string PackageCredit { get; set; }

            /// <summary>
            /// <para>The package ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmag-bp19i1yxu60r7twy****</para>
            /// </summary>
            [NameInMap("PackageId")]
            [Validation(Required=false)]
            public string PackageId { get; set; }

            /// <summary>
            /// <para>The package specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>advanced</para>
            /// </summary>
            [NameInMap("PackageSpec")]
            [Validation(Required=false)]
            public string PackageSpec { get; set; }

            [NameInMap("PackageSpecName")]
            [Validation(Required=false)]
            public string PackageSpecName { get; set; }

            /// <summary>
            /// <para>The package status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("PackageStatus")]
            [Validation(Required=false)]
            public string PackageStatus { get; set; }

            [NameInMap("PeriodEndTime")]
            [Validation(Required=false)]
            public string PeriodEndTime { get; set; }

            [NameInMap("PeriodStartTime")]
            [Validation(Required=false)]
            public string PeriodStartTime { get; set; }

            /// <summary>
            /// <para>The number of credits that have been used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("UsedCredit")]
            [Validation(Required=false)]
            public string UsedCredit { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
