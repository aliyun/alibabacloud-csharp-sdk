// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetConnectionTicketRequest : TeaModel {
        /// <summary>
        /// <para>The access type. If you do not specify this parameter, both types are displayed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INTERNET: Internet access.</description></item>
        /// <item><description>VPC: Express Connect access.</description></item>
        /// </list>
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
        /// <para>This parameter is required for the initial call and optional for subsequent calls.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ca-e4s0puhmwi7v****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The list of delivery groups.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, application instances are allocated only from the specified authorized delivery groups.</description></item>
        /// <item><description>If you specify the <c>AppInstanceId</c> or <c>AppInstancePersistentId</c> parameter, this parameter is required.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("AppInstanceGroupIdList")]
        [Validation(Required=false)]
        public List<string> AppInstanceGroupIdList { get; set; }

        /// <summary>
        /// <para>The application instance ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, only the specified application instance is allocated.</description></item>
        /// <item><description>If you specify this parameter, you must also specify the <c>AppInstanceGroupIdList</c> parameter, and the number of delivery group IDs in <c>AppInstanceGroupIdList</c> must be 1.</description></item>
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

        [NameInMap("AppPolicyId")]
        [Validation(Required=false)]
        public string AppPolicyId { get; set; }

        /// <summary>
        /// <para>The application startup parameter. For information about how to obtain startup parameters, see <a href="https://help.aliyun.com/document_detail/426045.html">How to obtain application installation and startup parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/q /n</para>
        /// </summary>
        [NameInMap("AppStartParam")]
        [Validation(Required=false)]
        public string AppStartParam { get; set; }

        /// <summary>
        /// <para>The application version. If you specify this parameter, only the specified version of the application is opened. If you do not specify this parameter, any authorized version of the application is opened.</para>
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
        /// <para>If you specify this parameter, application instances are allocated only from delivery groups in the specified region.</para>
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
        /// <para>The task ID.</para>
        /// <remarks>
        /// <para>This request parameter is required for non-initial invokes. Use this parameter to check the task status and connection credentials.</para>
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
