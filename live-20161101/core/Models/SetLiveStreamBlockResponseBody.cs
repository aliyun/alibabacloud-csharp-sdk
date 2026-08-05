// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveStreamBlockResponseBody : TeaModel {
        /// <summary>
        /// <para>The result description.</para>
        /// <list type="bullet">
        /// <item><description>Success: ok.</description></item>
        /// <item><description>Failure: failure details.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3be7ade8-d907-483c-b24a-0dad4595beaf</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ok: succeeded.</description></item>
        /// <item><description>fail: failed.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The task is considered failed if any single subtask fails to be created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
