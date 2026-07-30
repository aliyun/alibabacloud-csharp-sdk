// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealApplyApproveRequest : TeaModel {
        /// <summary>
        /// <para>The approval time.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Time zone: UTC+8.</description></item>
        /// <item><description>Format: yyyy-MM-dd HH:mm:ss.</description></item>
        /// <item><description>Default value: the time when the API call succeeds.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-12 16:12:53</para>
        /// </summary>
        [NameInMap("operate_time")]
        [Validation(Required=false)]
        public string OperateTime { get; set; }

        /// <summary>
        /// <para>The approval remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>同意</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The status of the application form.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The ID of the third-party approval form.</para>
        /// <remarks>
        /// <para>Use a unique identifier. It is displayed in the application forms, orders, and bills in Alibaba Business Travel.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("third_part_apply_id")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// <para>The employee ID of the approver.</para>
        /// <remarks>
        /// <para>Enter the user_id of the business travel employee.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62141</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
