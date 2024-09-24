// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppWebUiAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkAppWebUiAddressResponseBodyData Data { get; set; }
        public class GetSparkAppWebUiAddressResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Spark application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202205201533hz1209892000****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The database ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-clusterxxx</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The expiration time. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655801973000</para>
            /// </summary>
            [NameInMap("ExpirationTimeInMillis")]
            [Validation(Required=false)]
            public long? ExpirationTimeInMillis { get; set; }

            /// <summary>
            /// <para>The URL of the web UI for the Spark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://adbsparkui-cn-hangzhou.aliyuncs.com/?token=">https://adbsparkui-cn-hangzhou.aliyuncs.com/?token=</a>****</para>
            /// </summary>
            [NameInMap("WebUiAddress")]
            [Validation(Required=false)]
            public string WebUiAddress { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65A809F-34CE-4550-9BC1-0ED21ETG380</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
