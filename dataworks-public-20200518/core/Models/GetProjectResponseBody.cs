// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the workspace.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetProjectResponseBodyData Data { get; set; }
        public class GetProjectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Appkey")]
            [Validation(Required=false)]
            public string Appkey { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BaseProject")]
            [Validation(Required=false)]
            public bool? BaseProject { get; set; }

            /// <summary>
            /// <para>The ID of the resource group that was allocated by default when you purchased an exclusive resource group for MaxCompute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group_280749521****</para>
            /// </summary>
            [NameInMap("DefaultDiResourceGroupIdentifier")]
            [Validation(Required=false)]
            public string DefaultDiResourceGroupIdentifier { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Destination")]
            [Validation(Required=false)]
            public int? Destination { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DevStorageQuota")]
            [Validation(Required=false)]
            public string DevStorageQuota { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
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
            /// <para>The environment information of the workspace.</para>
            /// </summary>
            [NameInMap("EnvTypes")]
            [Validation(Required=false)]
            public List<string> EnvTypes { get; set; }

            /// <summary>
            /// <para>The time when the workspace was created. Example: <c>Dec 3, 2019 9:12:20 PM</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Oct 10, 2019 3:42:53 PM</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the workspace was last modified. Example: <c>Dec 3, 2019 9:12:20 PM</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dec 3, 2019 9:12:20 PM</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Indicates whether you are allowed to download the query result from DataStudio. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: You are allowed to download the query result from DataStudio.</description></item>
            /// <item><description><b>0</b>: You are not allowed to download the query result from DataStudio.</description></item>
            /// </list>
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
            /// <item><description><b>1</b>: The workspace is a default workspace.</description></item>
            /// <item><description><b>0</b>: The workspace is not a default workspace.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public int? IsDefault { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxFlowNode")]
            [Validation(Required=false)]
            public int? MaxFlowNode { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProdStorageQuota")]
            [Validation(Required=false)]
            public string ProdStorageQuota { get; set; }

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
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public int? ProjectId { get; set; }

            /// <summary>
            /// <para>The name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("ProjectIdentifier")]
            [Validation(Required=false)]
            public string ProjectIdentifier { get; set; }

            /// <summary>
            /// <para>The mode of the workspace. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: The workspace is in basic mode.</description></item>
            /// <item><description><b>3</b>: The workspace is in standard mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
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
            /// <para>Indicates whether the workspace protection feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled</description></item>
            /// <item><description><b>0</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProtectedMode")]
            [Validation(Required=false)]
            public int? ProtectedMode { get; set; }

            /// <summary>
            /// <para>The type of the workspace. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>private</b></description></item>
            /// <item><description><b>swap</b></description></item>
            /// </list>
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
            /// <para>The default interval between automatic reruns after an error occurs. Unit: milliseconds. The maximum interval is 30 minutes. You must pay attention to the conversion between units.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120000</para>
            /// </summary>
            [NameInMap("SchedulerRetryInterval")]
            [Validation(Required=false)]
            public int? SchedulerRetryInterval { get; set; }

            /// <summary>
            /// <para>The status of the workspace. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: AVAILABLE, which indicates that the workspace runs as expected.</description></item>
            /// <item><description><b>1</b>: DELETED, which indicates that the workspace is deleted.</description></item>
            /// <item><description><b>2</b>: INITIALIZING, which indicates that the workspace is being initialized.</description></item>
            /// <item><description><b>3</b>: INIT_FAILED, which indicates that the workspace fails to be initialized.</description></item>
            /// <item><description><b>4</b>: FORBIDDEN, which indicates that the workspace is manually disabled.</description></item>
            /// <item><description><b>5</b>: DELETING, which indicates that the workspace is being deleted.</description></item>
            /// <item><description><b>6</b>: DEL_FAILED, which indicates that the workspace fails to be deleted.</description></item>
            /// <item><description><b>7</b>: FROZEN, which indicates that the workspace is frozen due to overdue payments.</description></item>
            /// <item><description><b>8</b>: UPDATING, which indicates that the workspace is being updated. The workspace enters this state after you associate a new compute engine with the workspace and the compute engine is initialized.</description></item>
            /// <item><description><b>9</b>: UPDATE_FAILED, which indicates that the workspace fails to be updated.</description></item>
            /// </list>
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
            /// <item><description><b>0</b>: invisible</description></item>
            /// <item><description><b>1</b>: visible</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TablePrivacyMode")]
            [Validation(Required=false)]
            public int? TablePrivacyMode { get; set; }

            /// <summary>
            /// <para>The tags added to the workspace.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetProjectResponseBodyDataTags> Tags { get; set; }
            public class GetProjectResponseBodyDataTags : TeaModel {
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
            /// <para>280749521</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>Indicates whether a proxy account is used to access the MaxCompute compute engine associated with the workspace.</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
