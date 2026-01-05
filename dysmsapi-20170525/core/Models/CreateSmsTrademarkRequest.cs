// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateSmsTrademarkRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>申请人名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("TrademarkApplicantName")]
        [Validation(Required=false)]
        public string TrademarkApplicantName { get; set; }

        /// <summary>
        /// <para>专用权生失效日期</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2010-12-14~2030-12-13</para>
        /// </summary>
        [NameInMap("TrademarkEffExpDate")]
        [Validation(Required=false)]
        public string TrademarkEffExpDate { get; set; }

        /// <summary>
        /// <para>商标名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("TrademarkName")]
        [Validation(Required=false)]
        public string TrademarkName { get; set; }

        /// <summary>
        /// <para>商标详情截图osskey</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/test1719383196031.jpg</para>
        /// </summary>
        [NameInMap("TrademarkPic")]
        [Validation(Required=false)]
        public string TrademarkPic { get; set; }

        /// <summary>
        /// <para>商标注册号</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>766905</para>
        /// </summary>
        [NameInMap("TrademarkRegistrationNumber")]
        [Validation(Required=false)]
        public string TrademarkRegistrationNumber { get; set; }

    }

}
