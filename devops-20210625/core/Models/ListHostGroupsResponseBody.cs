// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListHostGroupsResponseBody : TeaModel {
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

        [NameInMap("hostGroups")]
        [Validation(Required=false)]
        public List<ListHostGroupsResponseBodyHostGroups> HostGroups { get; set; }
        public class ListHostGroupsResponseBodyHostGroups : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
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
            /// <para>2222222222222</para>
            /// </summary>
            [NameInMap("creatorAccountId")]
            [Validation(Required=false)]
            public string CreatorAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>主机组</para>
            /// </summary>
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
            /// <para>value</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("hostNum")]
            [Validation(Required=false)]
            public long? HostNum { get; set; }

            /// <summary>
            /// <para>323232</para>
            /// 
            /// <b>Example:</b>
            /// <para>部署组Id</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>211111111</para>
            /// </summary>
            [NameInMap("modifierAccountId")]
            [Validation(Required=false)]
            public string ModifierAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>部署组</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1212122</para>
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
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>asassasassa</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
