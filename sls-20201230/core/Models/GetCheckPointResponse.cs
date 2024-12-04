// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCheckPointResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<GetCheckPointResponseBody> Body { get; set; }
        public class GetCheckPointResponseBody : TeaModel {
            /// <summary>
            /// <para>The shard ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("shard")]
            [Validation(Required=false)]
            public int? Shard { get; set; }

            /// <summary>
            /// <para>The value of the checkpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MTUyNDE1NTM3OTM3MzkwODQ5Ng==</para>
            /// </summary>
            [NameInMap("checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

            /// <summary>
            /// <para>The time when the checkpoint was last updated. The value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1524224984800922</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The consumer at the checkpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>consumer_1</para>
            /// </summary>
            [NameInMap("consumer")]
            [Validation(Required=false)]
            public string Consumer { get; set; }

        }

    }

}
