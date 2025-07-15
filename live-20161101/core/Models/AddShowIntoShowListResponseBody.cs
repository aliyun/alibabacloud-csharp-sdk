// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddShowIntoShowListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>987DA143-A39C-5B5D-AF5B-3B07944A0036</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the episode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("ShowId")]
        [Validation(Required=false)]
        public string ShowId { get; set; }

        /// <summary>
        /// <para>The list of resources that failed to be added and the reason for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>failedList[Show1, Show2...]</para>
        /// </summary>
        [NameInMap("failedList")]
        [Validation(Required=false)]
        public string FailedList { get; set; }

        /// <summary>
        /// <para>The IDs of the episodes that were added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1933f16-5467-4308-b3a9-e8d451a90999,547436b8-c839-4469-a2c0-704c1ce5ce00</para>
        /// </summary>
        [NameInMap("successfulShowIds")]
        [Validation(Required=false)]
        public string SuccessfulShowIds { get; set; }

    }

}
