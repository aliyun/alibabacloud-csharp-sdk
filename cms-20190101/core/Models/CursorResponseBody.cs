// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CursorResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Cursor is used as an input parameter for data export in the <a href="https://help.aliyun.com/document_detail/2329847.html">BatchExport</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2.5eyJiYXRjaGVzIjoxLCJidWNrZXRCeXRlcyI6IndBPT0iLCJidWNrZXRzIjo0LCJjdXJyZW50QnVja2V0IjotNjQsImN1cnJlbnRUYXJnZXRUaW1lU2xvdCI6MTY3ODc1MjAwMCwiZW5kVGltZSI6MTY3ODc4MjQxOTAwMCwiZXhwb3J0RW5kVGltZSI6MTY3ODc4MjQxOTAwMCwiZXhwb3J0U3RhcnRUaW1lIjoxNjc4NzgxODE5MDAwLCJleHByZXNzUmFuZ2UiOmZhbHNlLCJoYXNOZXh0Ijp0cnVlLCJpbmRleCI6MCwibGF0ZXN0TG9nVGltZSI6MCwibWF0Y2hlcnMiOnsiY2hhaW4iOlt7ImxhYmVsIjoidXNlcklkIiwib3BlcmF0b3IiOiJFUVVBTFMiLCJ2YWx1ZSI6IjEyNzA2NzY2Nzk1NDY3MDQifV0sImxvY2tlZCI6dHJ1ZX0sIm1ldHJpYyI6IlNwbGl0cndQcm94eU1heFJlc3BvbnNlU2l6ZSIsIm1ldHJpY1R5cGUiOiJNRVRSSUMiLCJuYW1lc3BhY2UiOiJhY3Nfa3ZzdG9yZV9leCIsIm5leHRQa0FkYXB0ZXIiOnsiZGltIjoiVjowXG5EOmB1c2VySWRgPTEyNzA2NzY2Nzk1NDY3MDQsYGluc3RhbmNlSWRgPXItcmo5ZjlzMTlsc3V1MXd1bnVyLGBub2RlSWRgPXItcmo5ZjlzMTlsc3V1MXd1bnVyLXByb3h5LTIsXG4iLCJtZXRhIjoiXG5WOjBcbk06YWNzX2t2c3RvcmVfZXgvU3BsaXRyd1Byb3h5TWF4UmVzcG9uc2VTaXplXG5XOjYwXG5COjRcbkk6LTFcblQ6MFxuQzpgQXZlcmFnZWAsYE1heGltdW1gLGBfX2NvdW50X19gLGBfX3RzX19gXG4iLCJyZCI6InN1YkFMU0RwWXY2K0t6aENQQUFBWkErNUFKMEpjbGErRGd2V0hFNWxDSHMvbGtqR2FXYTFJTkVwdFE9PSIsInRhZyI6IiJ9LCJvZmZzZXQiOjAsIm9mZnNldERpZ2l0Ijo0NTU0NTczNDQyMTc4NDIxMjIsInN0YXJ0VGltZSI6MTY3ODc4MTgxOTAwMCwic3RlcCI6LTEsInRhZ01hdGNoZXJzIjp7ImNoYWluIjpbXSwibG9ja2VkIjp0cnVlfSwidGFyZ2V0VGltZVNsb3RzIjpbMTY3ODY2NTYwMCwxNjc4NzUyMDAwXSwidXVpZCI6ImQwMmFhZmY1LWU3ZGQtNDUyYy0***********</para>
        /// </summary>
        [NameInMap("Cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>915C2D7A-E6A4-17C3-8E13-4DBDD61E7919</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
