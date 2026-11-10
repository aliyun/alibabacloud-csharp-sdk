// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210903.Models
{
    public class GetConnectionTicketRequest : TeaModel {
        /// <summary>
        /// <para>The access type. If this parameter is not passed, both types are displayed. Valid values: INTERNET (Internet) and VPC (Express Connect circuit).</para>
        /// 
        /// <b>Example:</b>
        /// <para>INTERNET</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <remarks>
        /// <para>Required for the first call, and optional for subsequent calls.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ca-etn4zizga******</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The delivery group ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When this parameter is passed, an application instance is assigned only from the specified and authorized delivery groups.</description></item>
        /// <item><description>When the AppInstanceId parameter is passed, this parameter is required.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aig-bw1o1gcwv******</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The application instance ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When this parameter is passed, the system only attempts to assign the specified application instance.</description></item>
        /// <item><description>When this parameter is passed, the AppInstanceGroupId parameter must also be passed.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ai-ij4a6kd4bn2******</para>
        /// </summary>
        [NameInMap("AppInstanceId")]
        [Validation(Required=false)]
        public string AppInstanceId { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-0clfzcy0adpcf****</para>
        /// </summary>
        [NameInMap("AppPolicyId")]
        [Validation(Required=false)]
        public string AppPolicyId { get; set; }

        /// <summary>
        /// <para>The application version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.1</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically connect when the turn is reached.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoConnectInQueue")]
        [Validation(Required=false)]
        public bool? AutoConnectInQueue { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>When this parameter is passed, an application instance is assigned only from the delivery groups in the specified region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The client ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f2463208-ec89-4309-8e8c-8b1******</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The client IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22.21.<em>.</em></para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <para>The client operating system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>windows_&quot;Windows 10 Enterprise LTSC 2019&quot; 10.0 (Build 17763)</para>
        /// </summary>
        [NameInMap("ClientOS")]
        [Validation(Required=false)]
        public string ClientOS { get; set; }

        /// <summary>
        /// <para>The client type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>html5</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        /// <summary>
        /// <para>The client version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.1-D-20211008.101607</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>The connection properties in JSON format.
        /// The following parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description>authMode: the authorization mode, which is determined based on the authorization mode of the delivery group. Valid values: App (application authorization), AppInstanceGroup (delivery group authorization), and Session (persistent session authorization).</description></item>
        /// <item><description>appInstanceGroupScheduleTags: the delivery group scheduling tags. Multiple tag key-value pairs are supported for filtering. Multiple tag pairs have an AND relationship. The key must have a value, and the value can be empty. Format example: [{&quot;key&quot;:&quot;Resolution&quot;,&quot;value&quot;:&quot;720p&quot;},{&quot;key&quot;:&quot;Name&quot;}].</description></item>
        /// <item><description>appInstanceGroupIds: the list of specified delivery group IDs.</description></item>
        /// <item><description>appInstancePersistentId: the specified persistent session ID.</description></item>
        /// <item><description>avatarId: the user avatar ID. Default value: default. This parameter is used to support assigning multiple session instances to a single user.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Used when connecting to a cloud phone. Pass the fixed value <c>{&quot;authMode&quot;:&quot;Session&quot;}</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;authMode&quot;:&quot;Session&quot;}</para>
        /// </summary>
        [NameInMap("ConnectionProperties")]
        [Validation(Required=false)]
        public string ConnectionProperties { get; set; }

        /// <summary>
        /// <para>The username of the convenience account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The environment configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;screenWidth&quot;:2560,&quot;screenHeight&quot;:1564}</para>
        /// </summary>
        [NameInMap("EnvironmentConfig")]
        [Validation(Required=false)]
        public string EnvironmentConfig { get; set; }

        /// <summary>
        /// <para>The logon region ID. When a user logs on to a workspace, this parameter specifies the ID of the region to which the workspace belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("LoginRegionId")]
        [Validation(Required=false)]
        public string LoginRegionId { get; set; }

        /// <summary>
        /// <para>The logon token.
        /// Obtained by calling the GetLoginToken or GetStsToken API operation.
        /// The GetLoginToken and GetStsToken API operations belong to the client logon authentication APIs of the 2021-02-20 version of WUYING Cloud App (product code: appstream-center). These two API operations are not provided in the 2021-09-03 version. OpenAPI Explorer links: <a href="https://api.aliyun.com/api/appstream-center/2021-02-20/GetLoginToken">https://api.aliyun.com/api/appstream-center/2021-02-20/GetLoginToken</a> and <a href="https://api.aliyun.com/api/appstream-center/2021-02-20/GetStsToken">https://api.aliyun.com/api/appstream-center/2021-02-20/GetStsToken</a>.
        /// Note: This parameter is required. If it is not provided, the API returns InvalidParameter.loginToken(400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2c4e2ef03d62******</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <para>The application startup parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/q /n</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>Specifies whether UUID validation is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RequireUuidValidation")]
        [Validation(Required=false)]
        public bool? RequireUuidValidation { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <remarks>
        /// <para>Used when connecting to a cloud phone. Pass the persistent session ID that corresponds to the cloud phone instance.
        /// When connecting to a cloud browser, pass the cloud browser ID.
        /// When connecting to a cloud application, pass the application ID for the application authorization scenario, the delivery group ID for the delivery group authorization scenario, or the persistent session ID for the persistent session authorization scenario.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>p-0cdr5c9kl******</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The logon session ID. Obtained by calling the GetLoginToken or GetStsToken API operation. This parameter is used together with LoginToken.
        /// The GetLoginToken and GetStsToken API operations belong to the client logon authentication APIs of the 2021-02-20 version of WUYING Cloud App (product code: appstream-center). These two API operations are not provided in the 2021-09-03 version. OpenAPI Explorer links: <a href="https://api.aliyun.com/api/appstream-center/2021-02-20/GetLoginToken">https://api.aliyun.com/api/appstream-center/2021-02-20/GetLoginToken</a> and <a href="https://api.aliyun.com/api/appstream-center/2021-02-20/GetStsToken">https://api.aliyun.com/api/appstream-center/2021-02-20/GetStsToken</a>.
        /// Note: This parameter is required. If it is not provided, the API returns InvalidParameter.sessionId(400). This parameter must be used together with LoginToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09e2b2e6-3181******</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para>Required when you invoke the API not for the first time. Use this parameter query to check the node status and connection credentials.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6f41731b-7091-4******</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The tenant ID, which is the Alibaba Cloud account UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1126819517******</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the logon device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8B35215993FBF283F28D61******</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
