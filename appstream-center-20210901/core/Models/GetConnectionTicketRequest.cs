// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetConnectionTicketRequest : TeaModel {
        /// <summary>
        /// <para>The access type.</para>
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
        /// <para>Required for the initial call and optional for subsequent calls.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ca-e4s0puhmwi7v****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The delivery group list.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If this parameter is specified, an application instance is assigned only from the specified and authorized delivery groups.</description></item>
        /// <item><description>If the AppInstanceId or AppInstancePersistentId parameter is specified, this parameter is required.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("AppInstanceGroupIdList")]
        [Validation(Required=false)]
        public List<string> AppInstanceGroupIdList { get; set; }

        /// <summary>
        /// <para>The ID of the delivery group set used to obtain connection credentials.</para>
        /// 
        /// <b>Example:</b>
        /// <para>set-3jm9d0abc00example</para>
        /// </summary>
        [NameInMap("AppInstanceGroupSetId")]
        [Validation(Required=false)]
        public string AppInstanceGroupSetId { get; set; }

        /// <summary>
        /// <para>The application instance ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If this parameter is specified, the system attempts to assign only the specified application instance.</description></item>
        /// <item><description>If this parameter is specified, the AppInstanceGroupIdList parameter must also be specified, and the number of delivery group IDs in AppInstanceGroupIdList must be 1.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ai-1rznfnrvsa99d****</para>
        /// </summary>
        [NameInMap("AppInstanceId")]
        [Validation(Required=false)]
        public string AppInstanceId { get; set; }

        /// <summary>
        /// <para>The persistent session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-0bxls9m3cl7s****</para>
        /// </summary>
        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

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
        /// <para>The application startup parameters. This parameter is optional. You can refer to the image creation documentation to fill in the startup parameters and manually verify them during the image creation process. This field is suitable for startup parameters with variable content, allowing API callers to configure them flexibly. For more information about how to obtain startup parameters, see <a href="https://help.aliyun.com/document_detail/426045.html">How to obtain application installation and startup parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/q /n</para>
        /// </summary>
        [NameInMap("AppStartParam")]
        [Validation(Required=false)]
        public string AppStartParam { get; set; }

        /// <summary>
        /// <para>The application version. If this parameter is specified, only the application of the specified version is started. If this parameter is not specified, an authorized application of any version is started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>If this parameter is specified, an application instance is assigned only from the delivery groups in the specified region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>{&quot;userConfigReenter&quot;:&quot;NATIVE&quot;}</para>
        /// </summary>
        [NameInMap("EnvironmentConfig")]
        [Validation(Required=false)]
        public string EnvironmentConfig { get; set; }

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
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para>Required for non-initial invocations. Use this parameter to invoke a parameter query for the node status and connection credentials.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>28778acb-a469-4bc0-8e0f****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
