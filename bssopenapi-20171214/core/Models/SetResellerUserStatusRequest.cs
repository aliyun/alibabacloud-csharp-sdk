// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetResellerUserStatusRequest : TeaModel {
        /// <summary>
        /// <para>The type of the business. Valid values: FREEZE: the frozen business of the account. TRUSTEESHIP: the hosted business of the account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FREEZE</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The account status that you want to set. Valid values: Freeze: The account is frozen. Thaw: The account is unfrozen. Trusteeship: The account is hosted. TrusteeshipCancel: The account is not hosted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Freeze</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>停机模式
        /// 取值：
        ///     0：普通停机
        ///     1：立即停机</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StopMode")]
        [Validation(Required=false)]
        public string StopMode { get; set; }

    }

}
