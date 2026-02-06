// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetURLUploadInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The job IDs or upload URLs that do not exist.</para>
        /// </summary>
        [NameInMap("NonExists")]
        [Validation(Required=false)]
        public List<string> NonExists { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about URL-based upload jobs. For more information, see the &quot;URLUploadInfo: the information about a URL-based upload job&quot; section of the <a href="https://help.aliyun.com/document_detail/52839.html">Basic structures</a> topic.</para>
        /// </summary>
        [NameInMap("URLUploadInfoList")]
        [Validation(Required=false)]
        public List<GetURLUploadInfosResponseBodyURLUploadInfoList> URLUploadInfoList { get; set; }
        public class GetURLUploadInfosResponseBodyURLUploadInfoList : TeaModel {
            /// <summary>
            /// <para>The time when the upload job was complete. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-01T01:11:01Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the upload job was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-01T01:01:01Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The error code returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error_message</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The size of the uploaded media file. Unit: byte.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            /// <summary>
            /// <para>The ID of the upload job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86c1925fba0****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The ID of the uploaded media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93ab850b4f6f54b6e91d24d81d4****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>93ab850b4f654b6e91d24d81d44****</para>
            /// </summary>
            [NameInMap("RegisteredMediaId")]
            [Validation(Required=false)]
            public string RegisteredMediaId { get; set; }

            /// <summary>
            /// <para>The status of the URL-based upload job. For more information about the valid values and value description of the parameter, see the &quot;Status: the status of a video&quot; section of the <a href="https://help.aliyun.com/document_detail/52839.html">Basic structures</a> topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The upload URL of the source file.</para>
            /// <remarks>
            /// <para>A maximum of 100 URLs can be returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>http://****.mp4</para>
            /// </summary>
            [NameInMap("UploadURL")]
            [Validation(Required=false)]
            public string UploadURL { get; set; }

            /// <summary>
            /// <para>The custom configurations. The value is a JSON string. For more information, see the &quot;UserData: specifies the custom configurations for media upload&quot; section of the <a href="https://help.aliyun.com/document_detail/86952.html">Request parameters</a> topic.</para>
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
