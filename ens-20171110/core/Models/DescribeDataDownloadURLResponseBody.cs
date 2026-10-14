// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataDownloadURLResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The list of download URLs for data files.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataDownloadURLResponseBodyData Data { get; set; }
        public class DescribeDataDownloadURLResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The expiration time of the download URL in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-10T03:36:27Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The list of file servers.</para>
            /// </summary>
            [NameInMap("ServerList")]
            [Validation(Required=false)]
            public List<DescribeDataDownloadURLResponseBodyDataServerList> ServerList { get; set; }
            public class DescribeDataDownloadURLResponseBodyDataServerList : TeaModel {
                /// <summary>
                /// <para>The host address of the file server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1:8080</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The ID of the ENS edge node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-chenzhou-5</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The download URL of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/file/1450088842124331/97a32f2a-aa2c-436a-b19c-05b20d258618/f0313053530fc727f81b7d03fad93cd2/e4c2e8edac362acab7123654b9e73432?ak=edgepaas-innerapi-daily&amp;ts=1611229454&amp;sign=Yycbax%2F4OsTgm6BLoxR6lPs5gKE%3D</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The response message. A value of success indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
