// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetImageResponseBodyData Data { get; set; }
        public class GetImageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The full version number of the current instance image. The parameter is in the X.X.X.X format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.5.5.0</para>
            /// </summary>
            [NameInMap("CurrentVersionFullShowName")]
            [Validation(Required=false)]
            public string CurrentVersionFullShowName { get; set; }

            /// <summary>
            /// <para>The URL of the changelog for the maximum version to which the current version can be upgraded.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxxx">https://xxxxx</a></para>
            /// </summary>
            [NameInMap("MaxVersionChangelogUrl")]
            [Validation(Required=false)]
            public string MaxVersionChangelogUrl { get; set; }

            /// <summary>
            /// <para>The code of the maximum version to which the current version can be upgraded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZooKeeper_3_6_3</para>
            /// </summary>
            [NameInMap("MaxVersionCode")]
            [Validation(Required=false)]
            public string MaxVersionCode { get; set; }

            /// <summary>
            /// <para>The full number of the maximum version to which the current version can be upgraded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.6.3.0</para>
            /// </summary>
            [NameInMap("MaxVersionFullShowName")]
            [Validation(Required=false)]
            public string MaxVersionFullShowName { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request is successfully processed.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25EA0A83-9007-4E87-808C-637BE1A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
