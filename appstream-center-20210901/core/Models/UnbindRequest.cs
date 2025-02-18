// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UnbindRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery group. You can call the <a href="https://help.aliyun.com/zh/wuying-appstreaming/developer-reference/api-appstream-center-2021-09-01-getconnectionticket">GetConnectionTicket</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The session ID. You can call the <a href="https://help.aliyun.com/zh/wuying-appstreaming/developer-reference/api-appstream-center-2021-09-01-getconnectionticket">GetConnectionTicket</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-d297eyf83g5ni****</para>
        /// </summary>
        [NameInMap("AppInstanceId")]
        [Validation(Required=false)]
        public string AppInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the persistent session. You can call the <a href="https://help.aliyun.com/zh/wuying-appstreaming/developer-reference/api-appstream-center-2021-09-01-getconnectionticket">GetConnectionTicket</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-0bxls9m3cl7s****</para>
        /// </summary>
        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

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
        /// <para>The product type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: App Streaming</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
