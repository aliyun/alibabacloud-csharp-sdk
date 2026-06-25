// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The call is successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The call is redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A request error occurred.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The version information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAppVersionsResponseBodyData> Data { get; set; }
        public class ListAppVersionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The download URL of the code package. If you uploaded the package using SAE, note the following:</para>
            /// <list type="bullet">
            /// <item><description><para>This URL is not a direct download link. You must call the GetPackageVersionAccessableUrl operation to obtain a downloadable URL that is valid for 10 minutes.</para>
            /// </description></item>
            /// <item><description><para>SAE stores the package for a maximum of 90 days. After this period, the URL is not returned and the package cannot be downloaded.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("BuildPackageUrl")]
            [Validation(Required=false)]
            public string BuildPackageUrl { get; set; }

            /// <summary>
            /// <para>The time when the version was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590124643553</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a0ce266c-d354-423a-9bd6-4083405a****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The application type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>image</b>: The application is deployed using an image.</para>
            /// </description></item>
            /// <item><description><para><b>url</b>: The application is deployed using a code package.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>image</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The URL of the WAR package.</para>
            /// </summary>
            [NameInMap("WarUrl")]
            [Validation(Required=false)]
            public string WarUrl { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>This parameter is returned if the request fails. For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Additional information about the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01CF26C7-00A3-4AA6-BA76-7E95F2A3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the historical versions of the application were successfully queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The query was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The query failed.</para>
        /// </description></item>
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
