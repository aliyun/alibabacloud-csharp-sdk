// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetResellerUserStatusRequest : TeaModel {
        /// <summary>
        /// <para>The type of business operation. Valid values:
        /// FREEZE: Freeze operations.
        /// TRUSTEESHIP: Hosting operations.</para>
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
        /// <para>The status to set for the user account. Valid values:
        /// Freeze: The user account is frozen.
        /// Thaw: The user account is restored.
        /// Trusteeship: The user account is hosted.
        /// TrusteeshipCancel: The user account is not hosted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Freeze</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The stopping mode. Valid values:
        /// 0: Normal shutdown.
        /// 1: Immediate shutdown.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StopMode")]
        [Validation(Required=false)]
        public string StopMode { get; set; }

    }

}
