// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInstanceRiskNumResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the risks in the instance.</para>
        /// </summary>
        [NameInMap("InstanceRiskNum")]
        [Validation(Required=false)]
        public List<ListInstanceRiskNumResponseBodyInstanceRiskNum> InstanceRiskNum { get; set; }
        public class ListInstanceRiskNumResponseBodyInstanceRiskNum : TeaModel {
            /// <summary>
            /// <para>The information about the instance.</para>
            /// </summary>
            [NameInMap("InstanceItem")]
            [Validation(Required=false)]
            public ListInstanceRiskNumResponseBodyInstanceRiskNumInstanceItem InstanceItem { get; set; }
            public class ListInstanceRiskNumResponseBodyInstanceRiskNumInstanceItem : TeaModel {
                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-wz9fdluqx20mp2x7****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The UUID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f2d6e901-1004-4ca8-9dae-53ec04a9****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <para>The statistics about the risks.</para>
            /// </summary>
            [NameInMap("RiskNumEntity")]
            [Validation(Required=false)]
            public ListInstanceRiskNumResponseBodyInstanceRiskNumRiskNumEntity RiskNumEntity { get; set; }
            public class ListInstanceRiskNumResponseBodyInstanceRiskNumRiskNumEntity : TeaModel {
                /// <summary>
                /// <para>The number of high-risk alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("SuspiciousHighCount")]
                [Validation(Required=false)]
                public int? SuspiciousHighCount { get; set; }

                /// <summary>
                /// <para>The number of low-risk alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("SuspiciousLowCount")]
                [Validation(Required=false)]
                public int? SuspiciousLowCount { get; set; }

                /// <summary>
                /// <para>The number of medium-risk alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("SuspiciousMediumCount")]
                [Validation(Required=false)]
                public int? SuspiciousMediumCount { get; set; }

                /// <summary>
                /// <para>The number of high-risk vulnerabilities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("VulHighCount")]
                [Validation(Required=false)]
                public int? VulHighCount { get; set; }

                /// <summary>
                /// <para>The number of low-risk vulnerabilities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("VulLowCount")]
                [Validation(Required=false)]
                public int? VulLowCount { get; set; }

                /// <summary>
                /// <para>The number of medium-risk vulnerabilities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("VulMediumCount")]
                [Validation(Required=false)]
                public int? VulMediumCount { get; set; }

                /// <summary>
                /// <para>The number of weak passwords exposed on the Internet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("WeakPassWordCount")]
                [Validation(Required=false)]
                public int? WeakPassWordCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>291B49F9-1685-4005-9D34-606B6F78****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
