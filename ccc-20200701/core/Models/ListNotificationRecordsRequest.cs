// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListNotificationRecordsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;job-468a63a2-<b><b>-</b></b>-<b><b>-b1ecf726d4be&quot;,&quot;job-532a63a2-</b></b>-<b><b>-</b></b>-bcccc26d4cc&quot;]</para>
        /// </summary>
        [NameInMap("NotificationKeys")]
        [Validation(Required=false)]
        public string NotificationKeys { get; set; }

    }

}
