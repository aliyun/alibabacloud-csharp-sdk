// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetHostGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("hostGroup")]
        [Validation(Required=false)]
        public GetHostGroupResponseBodyHostGroup HostGroup { get; set; }
        public class GetHostGroupResponseBodyHostGroup : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-bejing</para>
            /// </summary>
            [NameInMap("aliyunRegion")]
            [Validation(Required=false)]
            public string AliyunRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1586863220000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("creatorAccountId")]
            [Validation(Required=false)]
            public string CreatorAccountId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ecsLabelKey")]
            [Validation(Required=false)]
            public string EcsLabelKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ecsLabelValue")]
            [Validation(Required=false)]
            public string EcsLabelValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ECS_ALIYUN</para>
            /// </summary>
            [NameInMap("ecsType")]
            [Validation(Required=false)]
            public string EcsType { get; set; }

            [NameInMap("hostInfos")]
            [Validation(Required=false)]
            public List<GetHostGroupResponseBodyHostGroupHostInfos> HostInfos { get; set; }
            public class GetHostGroupResponseBodyHostGroupHostInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("aliyunRegionId")]
                [Validation(Required=false)]
                public string AliyunRegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1586863220000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11111</para>
                /// </summary>
                [NameInMap("creatorAccountId")]
                [Validation(Required=false)]
                public string CreatorAccountId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ceshi</para>
                /// </summary>
                [NameInMap("instanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1ssasa</para>
                /// </summary>
                [NameInMap("machineSn")]
                [Validation(Required=false)]
                public string MachineSn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11111111111</para>
                /// </summary>
                [NameInMap("modifierAccountId")]
                [Validation(Required=false)]
                public string ModifierAccountId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MachineInfo</para>
                /// </summary>
                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1586863220000</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("hostNum")]
            [Validation(Required=false)]
            public long? HostNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11111</para>
            /// </summary>
            [NameInMap("modifierAccountId")]
            [Validation(Required=false)]
            public string ModifierAccountId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("serviceConnectionId")]
            [Validation(Required=false)]
            public long? ServiceConnectionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1586863220000</para>
            /// </summary>
            [NameInMap("upateTIme")]
            [Validation(Required=false)]
            public long? UpateTIme { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
