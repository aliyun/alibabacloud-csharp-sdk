// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckStructureResponseBody : TeaModel {
        /// <summary>
        /// <para>The structure information about check items provided by the configuration assessment feature.</para>
        /// </summary>
        [NameInMap("CheckStructureResponse")]
        [Validation(Required=false)]
        public List<GetCheckStructureResponseBodyCheckStructureResponse> CheckStructureResponse { get; set; }
        public class GetCheckStructureResponseBodyCheckStructureResponse : TeaModel {
            /// <summary>
            /// <para>The type of the check item.</para>
            /// <list type="bullet">
            /// <item><description>RISK: security risk.</description></item>
            /// <item><description>IDENTITY_PERMISSION: Cloud Infrastructure Entitlement Management (CIEM).</description></item>
            /// <item><description>COMPLIANCE: security compliance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RISK</para>
            /// </summary>
            [NameInMap("StandardType")]
            [Validation(Required=false)]
            public string StandardType { get; set; }

            /// <summary>
            /// <para>The structure information about the check items of the business type.</para>
            /// </summary>
            [NameInMap("Standards")]
            [Validation(Required=false)]
            public List<GetCheckStructureResponseBodyCheckStructureResponseStandards> Standards { get; set; }
            public class GetCheckStructureResponseBodyCheckStructureResponseStandards : TeaModel {
                /// <summary>
                /// <para>The standard ID of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The standards of the check items.</para>
                /// </summary>
                [NameInMap("Requirements")]
                [Validation(Required=false)]
                public List<GetCheckStructureResponseBodyCheckStructureResponseStandardsRequirements> Requirements { get; set; }
                public class GetCheckStructureResponseBodyCheckStructureResponseStandardsRequirements : TeaModel {
                    /// <summary>
                    /// <para>The ID of the requirement item for the check item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>46</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The information about the sections of check items.</para>
                    /// </summary>
                    [NameInMap("Sections")]
                    [Validation(Required=false)]
                    public List<GetCheckStructureResponseBodyCheckStructureResponseStandardsRequirementsSections> Sections { get; set; }
                    public class GetCheckStructureResponseBodyCheckStructureResponseStandardsRequirementsSections : TeaModel {
                        /// <summary>
                        /// <para>The ID of the section for the check item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>177</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <para>The display name of the section for the check item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Access Control</para>
                        /// </summary>
                        [NameInMap("ShowName")]
                        [Validation(Required=false)]
                        public string ShowName { get; set; }

                    }

                    /// <summary>
                    /// <para>The display name of the requirement item for the check item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Networking</para>
                    /// </summary>
                    [NameInMap("ShowName")]
                    [Validation(Required=false)]
                    public string ShowName { get; set; }

                    /// <summary>
                    /// <para>The total number of check items for the requirement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>36</para>
                    /// </summary>
                    [NameInMap("TotalCheckCount")]
                    [Validation(Required=false)]
                    public int? TotalCheckCount { get; set; }

                }

                /// <summary>
                /// <para>The display name of the standard for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud best security practices</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The standard type of the check item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RISK: security risk.</description></item>
                /// <item><description>IDENTITY_PERMISSION: CIEM.</description></item>
                /// <item><description>COMPLIANCE: security compliance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IDENTITY_PERMISSION</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>379a9b8f-107b-4630-9e95-2299a1ea****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
