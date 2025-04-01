// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the historical versions of the application were obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: indicates that the historical versions of the application were obtained.</description></item>
        /// <item><description><b>false</b>: indicates that the historical versions of the application could not be obtained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the versions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAppVersionsResponseBodyData> Data { get; set; }
        public class ListAppVersionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The URL of the code package. If you use the SAE console to upload the code package, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>You cannot download the URL. You must call the GetPackageVersionAccessableUrl operation to obtain the URL. The obtained URL is valid for 10 minutes.</description></item>
            /// <item><description>SAE can retain the package up to 90 days. After 90 days, the URL cannot be returned or downloaded.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("BuildPackageUrl")]
            [Validation(Required=false)]
            public string BuildPackageUrl { get; set; }

            /// <summary>
            /// <para>The download link of the WAR or JAR package. This parameter is returned when the <b>Type</b> parameter is set to <b>url</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590124643553</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// <list type="bullet">
            /// <item><description>The <b>ErrorCode</b> parameter is not returned when the request succeeds.</description></item>
            /// <item><description>The <b>ErrorCode</b> parameter is returned when the request fails. For more information, see <b>Error codes</b> in this topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>a0ce266c-d354-423a-9bd6-4083405a****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The deployment method of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>image</b>: indicates that the application is deployed by using an image.</description></item>
            /// <item><description><b>url</b>: indicates that the application is deployed by using a code package.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>image</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The URL of the image.</para>
            /// </summary>
            [NameInMap("WarUrl")]
            [Validation(Required=false)]
            public string WarUrl { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: indicates that the request was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the request was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the request was invalid.</description></item>
        /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The information about the versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01CF26C7-00A3-4AA6-BA76-7E95F2A3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
