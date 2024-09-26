// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetProjectDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the workspace.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetProjectDetailResponseBodyData Data { get; set; }
        public class GetProjectDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The identifier of the shared resource group for Data Integration on which nodes are run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group_280749521****</para>
            /// </summary>
            [NameInMap("DefaultDiResourceGroupIdentifier")]
            [Validation(Required=false)]
            public string DefaultDiResourceGroupIdentifier { get; set; }

            /// <summary>
            /// <para>The development type of the workspace. The value is fixed to 4.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("DevelopmentType")]
            [Validation(Required=false)]
            public int? DevelopmentType { get; set; }

            /// <summary>
            /// <para>Indicates whether the Develop role is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b> (default)</description></item>
            /// <item><description><b>true</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisableDevelopment")]
            [Validation(Required=false)]
            public bool? DisableDevelopment { get; set; }

            /// <summary>
            /// <para>The environments of workspaces in different modes. Workspaces in basic mode provide only the production environment. Workspaces in standard mode provide both the development environment and the production environment.</para>
            /// </summary>
            [NameInMap("EnvTypes")]
            [Validation(Required=false)]
            public List<string> EnvTypes { get; set; }

            /// <summary>
            /// <para>The time when the workspace was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Oct 10, 2019 3:42:53 PM</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the workspace was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dec 3, 2019 9:12:20 PM</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Indicates whether the download operation is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsAllowDownload")]
            [Validation(Required=false)]
            public int? IsAllowDownload { get; set; }

            /// <summary>
            /// <para>Indicates whether the workspace is a default workspace. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: The workspace is a default workspace.</description></item>
            /// <item><description>0: The workspace is not a default workspace.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public int? IsDefault { get; set; }

            /// <summary>
            /// <para>The description of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("ProjectDescription")]
            [Validation(Required=false)]
            public string ProjectDescription { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public int? ProjectId { get; set; }

            /// <summary>
            /// <para>The unique identifier of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("ProjectIdentifier")]
            [Validation(Required=false)]
            public string ProjectIdentifier { get; set; }

            /// <summary>
            /// <para>The mode of the workspace. The value 2 indicates that the workspace is in basic mode. The value 3 indicates that the workspace is in standard mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProjectMode")]
            [Validation(Required=false)]
            public int? ProjectMode { get; set; }

            /// <summary>
            /// <para>The display name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account used by the workspace owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18229311****</para>
            /// </summary>
            [NameInMap("ProjectOwnerBaseId")]
            [Validation(Required=false)]
            public string ProjectOwnerBaseId { get; set; }

            /// <summary>
            /// <para>Indicates whether the workspace protection feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProtectedMode")]
            [Validation(Required=false)]
            public int? ProtectedMode { get; set; }

            /// <summary>
            /// <para>The type of the workspace. Valid values: private and swap.</para>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("ResidentArea")]
            [Validation(Required=false)]
            public string ResidentArea { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzbn7pti3zfa</para>
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// <para>The default maximum number of automatic reruns that are allowed after an error occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SchedulerMaxRetryTimes")]
            [Validation(Required=false)]
            public int? SchedulerMaxRetryTimes { get; set; }

            /// <summary>
            /// <para>The interval between automatic reruns after an error occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120000</para>
            /// </summary>
            [NameInMap("SchedulerRetryInterval")]
            [Validation(Required=false)]
            public int? SchedulerRetryInterval { get; set; }

            /// <summary>
            /// <para>The status of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Indicates whether the MaxCompute tables in the workspace are visible to the users within a tenant. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The MaxCompute tables in the workspace are not visible to the users within a tenant.</description></item>
            /// <item><description>1: The MaxCompute tables in the workspace are visible to the users within a tenant.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TablePrivacyMode")]
            [Validation(Required=false)]
            public int? TablePrivacyMode { get; set; }

            /// <summary>
            /// <para>The tag information.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetProjectDetailResponseBodyDataTags> Tags { get; set; }
            public class GetProjectDetailResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>280749521950784</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>Indicates whether a proxy account is used to access the MaxCompute compute engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseProxyOdpsAccount")]
            [Validation(Required=false)]
            public bool? UseProxyOdpsAccount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937635973****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
