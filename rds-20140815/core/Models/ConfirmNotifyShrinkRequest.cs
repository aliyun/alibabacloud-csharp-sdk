// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ConfirmNotifyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is used to confirm the notification. You can set this parameter to <b>0</b>, which indicates that the notification is confirmed by the system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Confirmor")]
        [Validation(Required=false)]
        public long? Confirmor { get; set; }

        /// <summary>
        /// <para>The notification IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("NotifyIdList")]
        [Validation(Required=false)]
        public string NotifyIdListShrink { get; set; }

    }

}
