// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDeploymentPackageFilesResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDeploymentPackageFilesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDeploymentPackageFilesResponseBodyPagingInfo : TeaModel {
            [NameInMap("DeploymentPackageFiles")]
            [Validation(Required=false)]
            public List<ListDeploymentPackageFilesResponseBodyPagingInfoDeploymentPackageFiles> DeploymentPackageFiles { get; set; }
            public class ListDeploymentPackageFilesResponseBodyPagingInfoDeploymentPackageFiles : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public int? ChangeType { get; set; }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-04-10 15:55:47</para>
                /// </summary>
                [NameInMap("CommitTime")]
                [Validation(Required=false)]
                public string CommitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>446***</para>
                /// </summary>
                [NameInMap("CommitUser")]
                [Validation(Required=false)]
                public string CommitUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user***</para>
                /// </summary>
                [NameInMap("CommitUserName")]
                [Validation(Required=false)]
                public string CommitUserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>520246913</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bak_part_basc_person_relation_all_da</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public int? FileType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("FileVersion")]
                [Validation(Required=false)]
                public long? FileVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>650433503</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsSameAsProductionVersion")]
                [Validation(Required=false)]
                public bool? IsSameAsProductionVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;tagList&quot;: [],
                ///     &quot;fileId&quot;: -1,
                ///     &quot;taskRerunTime&quot;: 0,
                ///     &quot;taskRerunInterval&quot;: 0,
                ///     &quot;reRunAble&quot;: 1,
                ///     &quot;nodeId&quot;: 125803000,
                ///     &quot;nodeName&quot;: &quot;new&quot;,
                ///     &quot;nodeType&quot;: 0,
                ///     &quot;isStop&quot;: 0,
                ///     &quot;paraValue&quot;: &quot;&quot;,
                ///     &quot;startEffectDate&quot;: &quot;1970-01-01 00:00:00&quot;,
                ///     &quot;endEffectDate&quot;: &quot;9999-01-01 00:00:00&quot;,
                ///     &quot;cronExpress&quot;: &quot;00 26 00 * * ?&quot;,
                ///     &quot;owner&quot;: &quot;1107550004250000&quot;,
                ///     &quot;resgroupId&quot;: 6300000,
                ///     &quot;cu&quot;: &quot;0.25&quot;,
                ///     &quot;appId&quot;: 170000,
                ///     &quot;tenantId&quot;: 524257424560000,
                ///     &quot;createTime&quot;: &quot;2025-04-10 15:55:01&quot;,
                ///     &quot;createUser&quot;: &quot;1107550004250000&quot;,
                ///     &quot;lastModifyTime&quot;: &quot;2025-04-10 15:55:41&quot;,
                ///     &quot;cycleType&quot;: 0,
                ///     &quot;dependentType&quot;: 0,
                ///     &quot;dependentTypeList&quot;: [0],
                ///     &quot;lastModifyUser&quot;: &quot;1107550004250000&quot;,
                ///     &quot;dependentDataNode&quot;: &quot;&quot;,
                ///     &quot;input&quot;: &quot;[{\&quot;regionId\&quot;:\&quot;cn-hangzhou\&quot;,\&quot;str\&quot;:\&quot;root_input\&quot;,\&quot;parseType\&quot;:1}]&quot;,
                ///     &quot;output&quot;: &quot;[{\&quot;str\&quot;:\&quot;project_root.526586287_out\&quot;,\&quot;parseType\&quot;:2},{\&quot;str\&quot;:\&quot;project_root.new\&quot;,\&quot;parseType\&quot;:1}]&quot;,
                ///     &quot;inputList&quot;: [{
                ///         &quot;regionId&quot;: &quot;cn-hangzhou&quot;,
                ///         &quot;str&quot;: &quot;root_input&quot;,
                ///         &quot;parseType&quot;: 1
                ///     }],
                ///     &quot;outputList&quot;: [{
                ///         &quot;str&quot;: &quot;project_root.526586287_out&quot;,
                ///         &quot;parseType&quot;: 2
                ///     }, {
                ///         &quot;str&quot;: &quot;project_root.new&quot;,
                ///         &quot;parseType&quot;: 1
                ///     }],
                ///     &quot;isAutoParse&quot;: 1,
                ///     &quot;startRightNow&quot;: false,
                ///     &quot;extConfig&quot;: &quot;{\&quot;openCustomCron\&quot;:false,\&quot;formCron\&quot;:\&quot;\&quot;}&quot;,
                ///     &quot;inputContextList&quot;: [],
                ///     &quot;outputContextList&quot;: []
                /// }</para>
                /// </summary>
                [NameInMap("NodeConfiguration")]
                [Validation(Required=false)]
                public string NodeConfiguration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>700005008419</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>27595</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("SmokeTestStatus")]
                [Validation(Required=false)]
                public string SmokeTestStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>639415964191360</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
