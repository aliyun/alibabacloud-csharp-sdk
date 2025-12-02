// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetServiceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceConfigResponseBodyData Data { get; set; }
        public class GetServiceConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Custom service details</para>
            /// </summary>
            [NameInMap("CustomServiceConf")]
            [Validation(Required=false)]
            public GetServiceConfigResponseBodyDataCustomServiceConf CustomServiceConf { get; set; }
            public class GetServiceConfigResponseBodyDataCustomServiceConf : TeaModel {
                /// <summary>
                /// <para>Ignore word libraries.</para>
                /// </summary>
                [NameInMap("KeywordFilterLibs")]
                [Validation(Required=false)]
                public List<string> KeywordFilterLibs { get; set; }

                /// <summary>
                /// <para>Hit word libraries.</para>
                /// </summary>
                [NameInMap("KeywordHitLibs")]
                [Validation(Required=false)]
                public List<string> KeywordHitLibs { get; set; }

                /// <summary>
                /// <para>Human-machine review configuration.</para>
                /// </summary>
                [NameInMap("ManualMachineConfig")]
                [Validation(Required=false)]
                public GetServiceConfigResponseBodyDataCustomServiceConfManualMachineConfig ManualMachineConfig { get; set; }
                public class GetServiceConfigResponseBodyDataCustomServiceConfManualMachineConfig : TeaModel {
                    /// <summary>
                    /// <para>Risk levels.</para>
                    /// </summary>
                    [NameInMap("AuditRiskLevels")]
                    [Validation(Required=false)]
                    public List<string> AuditRiskLevels { get; set; }

                    /// <summary>
                    /// <para>Callback notification ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("CallbackId")]
                    [Validation(Required=false)]
                    public long? CallbackId { get; set; }

                    /// <summary>
                    /// <para>Whether to enable. Values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Enabled</description></item>
                    /// <item><description><b>false</b>: Disabled</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>Manual review service</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>imageManualCheck</para>
                    /// </summary>
                    [NameInMap("ManualService")]
                    [Validation(Required=false)]
                    public string ManualService { get; set; }

                }

                /// <summary>
                /// <para>Hit similar text libraries.</para>
                /// </summary>
                [NameInMap("SimilarTextHitLibs")]
                [Validation(Required=false)]
                public List<string> SimilarTextHitLibs { get; set; }

            }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-06 03:07:44</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>Service code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nickname_detection</para>
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            /// <summary>
            /// <para>UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>165379****31937</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>Further description of the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Success indicator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
