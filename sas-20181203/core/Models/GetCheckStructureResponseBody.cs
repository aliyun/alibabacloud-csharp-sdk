// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckStructureResponseBody : TeaModel {
        /// <summary>
        /// <para>The structure information of cloud platform configuration check items.</para>
        /// </summary>
        [NameInMap("CheckStructureResponse")]
        [Validation(Required=false)]
        public List<GetCheckStructureResponseBodyCheckStructureResponse> CheckStructureResponse { get; set; }
        public class GetCheckStructureResponseBodyCheckStructureResponse : TeaModel {
            /// <summary>
            /// <para>The business type of the cloud platform configuration check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>RISK: security risk</para>
            /// </description></item>
            /// <item><description><para>IDENTITY_PERMISSION: permission management CIEM</para>
            /// </description></item>
            /// <item><description><para>COMPLIANCE: security compliance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RISK</para>
            /// </summary>
            [NameInMap("StandardType")]
            [Validation(Required=false)]
            public string StandardType { get; set; }

            /// <summary>
            /// <para>The structure information of check items under the business type.</para>
            /// </summary>
            [NameInMap("Standards")]
            [Validation(Required=false)]
            public List<GetCheckStructureResponseBodyCheckStructureResponseStandards> Standards { get; set; }
            public class GetCheckStructureResponseBodyCheckStructureResponseStandards : TeaModel {
                /// <summary>
                /// <para>The ID of the cloud platform configuration check item standard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The standards of the cloud platform configuration check items.</para>
                /// </summary>
                [NameInMap("Requirements")]
                [Validation(Required=false)]
                public List<GetCheckStructureResponseBodyCheckStructureResponseStandardsRequirements> Requirements { get; set; }
                public class GetCheckStructureResponseBodyCheckStructureResponseStandardsRequirements : TeaModel {
                    /// <summary>
                    /// <para>The ID of the cloud platform configuration check item requirement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>46</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The sections of the check items.</para>
                    /// </summary>
                    [NameInMap("Sections")]
                    [Validation(Required=false)]
                    public List<GetCheckStructureResponseBodyCheckStructureResponseStandardsRequirementsSections> Sections { get; set; }
                    public class GetCheckStructureResponseBodyCheckStructureResponseStandardsRequirementsSections : TeaModel {
                        /// <summary>
                        /// <para>The ID of the check item section.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>177</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <para>The name of the check item section.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Access Control</para>
                        /// </summary>
                        [NameInMap("ShowName")]
                        [Validation(Required=false)]
                        public string ShowName { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the cloud platform configuration check item requirement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Networking</para>
                    /// </summary>
                    [NameInMap("ShowName")]
                    [Validation(Required=false)]
                    public string ShowName { get; set; }

                    /// <summary>
                    /// <para>The total number of check items under the requirement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>36</para>
                    /// </summary>
                    [NameInMap("TotalCheckCount")]
                    [Validation(Required=false)]
                    public int? TotalCheckCount { get; set; }

                }

                /// <summary>
                /// <para>The name of the cloud platform configuration check item standard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud best security practices</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The business type corresponding to the cloud platform configuration check item standard. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>RISK: security risk</para>
                /// </description></item>
                /// <item><description><para>IDENTITY_PERMISSION: permission management CIEM</para>
                /// </description></item>
                /// <item><description><para>COMPLIANCE: security compliance.</para>
                /// </description></item>
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
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>379a9b8f-107b-4630-9e95-2299a1ea****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
