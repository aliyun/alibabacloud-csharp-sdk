// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PushApplicationDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The push results of data files.</para>
        /// </summary>
        [NameInMap("PushResults")]
        [Validation(Required=false)]
        public PushApplicationDataResponseBodyPushResults PushResults { get; set; }
        public class PushApplicationDataResponseBodyPushResults : TeaModel {
            [NameInMap("PushResult")]
            [Validation(Required=false)]
            public List<PushApplicationDataResponseBodyPushResultsPushResult> PushResult { get; set; }
            public class PushApplicationDataResponseBodyPushResultsPushResult : TeaModel {
                /// <summary>
                /// <para>The name of the data file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gcs-pre-websocket-eip-telecom</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The push result. The value is of the enumeration type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The push operation is successful.</description></item>
                /// <item><description>100: The push operation has been performed and the file is pushed.</description></item>
                /// <item><description>200: The push operation has been performed and the file is being pushed to specific file servers.</description></item>
                /// <item><description>300: The push operation failed. You must trigger the push operation again. The ResultDescrip parameter indicates the error description.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public int? ResultCode { get; set; }

                /// <summary>
                /// <para>The description of the push status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("ResultDescrip")]
                [Validation(Required=false)]
                public string ResultDescrip { get; set; }

                /// <summary>
                /// <para>The version number of the data file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
