// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ModifyDataSourceLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyDataSourceLogResponseBodyData Data { get; set; }
        public class ModifyDataSourceLogResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of modified logs. A value of 1 indicates success. A value of 0 or less indicates failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The ID of the log. The threat analysis feature generates this ID by calculating an MD5 hash of the parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>220ba97c9d1fdb0b9c7e8c7ca328d7ea</para>
            /// </summary>
            [NameInMap("LogInstanceId")]
            [Validation(Required=false)]
            public string LogInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
