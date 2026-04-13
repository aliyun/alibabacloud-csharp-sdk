// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAICopilot20250731.Models
{
    public class GetSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1557******4904</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ECB1F5******C1BF5223</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>se-j6p******dram6</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>27******94904</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
