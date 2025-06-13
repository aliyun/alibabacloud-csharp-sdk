// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetServiceConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceConfigResponseBodyData Data { get; set; }
        public class GetServiceConfigResponseBodyData : TeaModel {
            [NameInMap("CustomServiceConf")]
            [Validation(Required=false)]
            public GetServiceConfigResponseBodyDataCustomServiceConf CustomServiceConf { get; set; }
            public class GetServiceConfigResponseBodyDataCustomServiceConf : TeaModel {
                [NameInMap("KeywordFilterLibs")]
                [Validation(Required=false)]
                public List<string> KeywordFilterLibs { get; set; }

                [NameInMap("KeywordHitLibs")]
                [Validation(Required=false)]
                public List<string> KeywordHitLibs { get; set; }

                [NameInMap("ManualMachineConfig")]
                [Validation(Required=false)]
                public GetServiceConfigResponseBodyDataCustomServiceConfManualMachineConfig ManualMachineConfig { get; set; }
                public class GetServiceConfigResponseBodyDataCustomServiceConfManualMachineConfig : TeaModel {
                    [NameInMap("AuditRiskLevels")]
                    [Validation(Required=false)]
                    public List<string> AuditRiskLevels { get; set; }

                    [NameInMap("CallbackId")]
                    [Validation(Required=false)]
                    public long? CallbackId { get; set; }

                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    [NameInMap("ManualService")]
                    [Validation(Required=false)]
                    public string ManualService { get; set; }

                }

                [NameInMap("SimilarTextHitLibs")]
                [Validation(Required=false)]
                public List<string> SimilarTextHitLibs { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-06 03:07:44</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nickname_detection</para>
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            /// <summary>
            /// <para>UID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>165379****31937</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
