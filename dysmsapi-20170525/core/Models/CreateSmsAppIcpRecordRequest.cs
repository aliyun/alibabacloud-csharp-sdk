// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateSmsAppIcpRecordRequest : TeaModel {
        /// <summary>
        /// <para>审核通过日期，示例2025-09-01</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-22</para>
        /// </summary>
        [NameInMap("AppApprovalDate")]
        [Validation(Required=false)]
        public string AppApprovalDate { get; set; }

        /// <summary>
        /// <para>ICP备案/许可证号</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("AppIcpLicenseNumber")]
        [Validation(Required=false)]
        public string AppIcpLicenseNumber { get; set; }

        /// <summary>
        /// <para>app-icp备案详情截图osskey</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/test1719383196031.jpg</para>
        /// </summary>
        [NameInMap("AppIcpRecordPic")]
        [Validation(Required=false)]
        public string AppIcpRecordPic { get; set; }

        /// <summary>
        /// <para>主办单位名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("AppPrincipalUnitName")]
        [Validation(Required=false)]
        public string AppPrincipalUnitName { get; set; }

        /// <summary>
        /// <para>app服务名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("AppServiceName")]
        [Validation(Required=false)]
        public string AppServiceName { get; set; }

        /// <summary>
        /// <para>APP应用商店链接</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://alicom-ops.alibaba-inc.com/dyorder/audit-domain/rule_manage">https://alicom-ops.alibaba-inc.com/dyorder/audit-domain/rule_manage</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
