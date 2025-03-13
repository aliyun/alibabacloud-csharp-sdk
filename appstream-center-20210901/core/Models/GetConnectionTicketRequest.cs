// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetConnectionTicketRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <remarks>
        /// <para> This parameter is required for the first call to this operation and optional for subsequent calls to the operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ca-e4s0puhmwi7v****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The delivery groups.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you configure this parameter, the system assigns application instances only among the specified authorized delivery groups. </description></item>
        /// <item><description>This parameter is required if you configure <c>AppInstanceId</c> or <c>AppInstancePersistentId</c>.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("AppInstanceGroupIdList")]
        [Validation(Required=false)]
        public List<string> AppInstanceGroupIdList { get; set; }

        /// <summary>
        /// <para>The ID of the application instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you configure this parameter, the system attempts to assign only the specified application instance.</description></item>
        /// <item><description>If you configure this parameter, you must also configure <c>AppInstanceGroupIdList</c> and the number of delivery groups specified by <c>AppInstanceGroupIdList</c> must be 1.</description></item>
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
        /// <para>The ID of the persistent session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-0bxls9m3cl7s****</para>
        /// </summary>
        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

        /// <summary>
        /// <para>The parameters that are configured to start the application. For information about how to obtain these parameters, see <a href="https://help.aliyun.com/document_detail/426045.html">Obtain parameters configured to install and start an application</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/q /n</para>
        /// </summary>
        [NameInMap("AppStartParam")]
        [Validation(Required=false)]
        public string AppStartParam { get; set; }

        /// <summary>
        /// <para>The application version. If you configure this parameter, only an application of the specified version is started. If you do not configure this parameter, an application of a random authorized version is started.</para>
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
        /// <para> If you configure this parameter, the system assigns application instances only among the delivery groups that reside in the specified region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the convenience account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: App Streaming</description></item>
        /// <item><description>AndroidCloud: Cloud Phone</description></item>
        /// </list>
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
        /// <para> This parameter is required for calls other than the first call to this operation. You can use this parameter to query the task status and connection credential.</para>
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
