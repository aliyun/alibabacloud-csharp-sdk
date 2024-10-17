// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetUrlUploadInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The job IDs or upload URLs that do not exist.</para>
        /// </summary>
        [NameInMap("NonExists")]
        [Validation(Required=false)]
        public List<string> NonExists { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details about URL-based upload jobs.</para>
        /// </summary>
        [NameInMap("URLUploadInfoList")]
        [Validation(Required=false)]
        public List<GetUrlUploadInfosResponseBodyURLUploadInfoList> URLUploadInfoList { get; set; }
        public class GetUrlUploadInfosResponseBodyURLUploadInfoList : TeaModel {
            /// <summary>
            /// <para>The time when the upload job was complete. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-26 21:47:37</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the upload job was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-07T10:03:37Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The error code returned if the upload job failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned if the upload job failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The file size. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64610</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            /// <summary>
            /// <para>The ID of the upload job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3829500c0fef429fa4ec1680b122d***</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The ID of the uploaded media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5014ca70f08171ecbf940764a0fd6***</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The status of the upload job. For more information about the valid values of the parameter, see the &quot;Status: the status of a URL-based upload job&quot; section of the <a href="https://help.aliyun.com/document_detail/52839.html">Basic data types</a> topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The upload URL of the source file.</para>
            /// <remarks>
            /// <para> A maximum of 100 URLs can be returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>http://****.mp4</para>
            /// </summary>
            [NameInMap("UploadURL")]
            [Validation(Required=false)]
            public string UploadURL { get; set; }

            /// <summary>
            /// <para>The user data. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;MessageCallback&quot;:&quot;{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D">http://example.aliyundoc.com&quot;}</a>&quot;, &quot;Extend&quot;:&quot;{&quot;localId&quot;:&quot;***&quot;, &quot;test&quot;:&quot;www&quot;}&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

    }

}
