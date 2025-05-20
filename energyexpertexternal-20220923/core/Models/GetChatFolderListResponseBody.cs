// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetChatFolderListResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ChatFolderItem> Data { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8AEC6D9-A359-5169-BD1A-BD848BA60D65</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
