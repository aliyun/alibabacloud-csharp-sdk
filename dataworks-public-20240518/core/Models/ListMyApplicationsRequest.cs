// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMyApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>The resource type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("DefSchema")]
        [Validation(Required=false)]
        public string DefSchema { get; set; }

        /// <summary>
        /// <para>The end time of the application, specified as a Unix timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1779724799999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>A token that you can use in a subsequent request to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJpZCI6MTIzfQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search criteria for the resource.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ListMyApplicationsRequestResource Resource { get; set; }
        public class ListMyApplicationsRequestResource : TeaModel {
            /// <summary>
            /// <para>The name of the resource schema (<c>ResourceSchema.name</c>) required for resource parsing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("DefSchema")]
            [Validation(Required=false)]
            public string DefSchema { get; set; }

            /// <summary>
            /// <para>The version of the resource schema (<c>ResourceSchema.version</c>) required for resource parsing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.0.0</para>
            /// </summary>
            [NameInMap("DefVersion")]
            [Validation(Required=false)]
            public string DefVersion { get; set; }

            /// <summary>
            /// <para>The resource metadata. The content is constrained by the <c>ResourceSchema</c>.</para>
            /// </summary>
            [NameInMap("MetaData")]
            [Validation(Required=false)]
            public Dictionary<string, object> MetaData { get; set; }

        }

        /// <summary>
        /// <para>The name of the leaf node that specifies the resource type. You can specify multiple resource types. Note that different leaf node names can map to the same business logic.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public List<string> ResourceType { get; set; }

        /// <summary>
        /// <para>The start time of the application, specified as a Unix timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1771948800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The approval statuses for filtering. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>WaitApproval</c>: Pending approval</para>
        /// </description></item>
        /// <item><description><para><c>Confirmed</c>: Pending authorization</para>
        /// </description></item>
        /// <item><description><para><c>RejectApproval</c>: Approval rejected</para>
        /// </description></item>
        /// <item><description><para><c>AuthorizeSucceed</c>: Authorization succeeded</para>
        /// </description></item>
        /// <item><description><para><c>AuthorizeFailed</c>: Authorization failed</para>
        /// </description></item>
        /// <item><description><para><c>Deleted</c>: The application was deleted.</para>
        /// </description></item>
        /// <item><description><para><c>Canceled</c>: The application was canceled.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

    }

}
