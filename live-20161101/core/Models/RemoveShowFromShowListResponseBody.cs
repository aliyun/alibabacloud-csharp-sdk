// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class RemoveShowFromShowListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
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
        /// <para>The IDs of episodes that failed to be removed and the relevant failure information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>failedList[Show1, Show2...]</para>
        /// </summary>
        [NameInMap("failedList")]
        [Validation(Required=false)]
        public string FailedList { get; set; }

        /// <summary>
        /// <para>The IDs of episodes that were removed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1933f16-5467-4308-b3a9-e8d451a90999</para>
        /// </summary>
        [NameInMap("successfulShowIds")]
        [Validation(Required=false)]
        public string SuccessfulShowIds { get; set; }

    }

}
