// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataCenter.FileTooLarge</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned for the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddFileResponseBodyData Data { get; set; }
        public class AddFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the file. Save this ID for use in subsequent API calls involving this file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file_9a65732555b54d5ea10796ca5742ba22_xxxxxxxx</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The parser that was used for the file. A possible value is:</para>
            /// <list type="bullet">
            /// <item><description><c>DASHSCOPE_DOCMIND</c>: Alibaba Cloud Document Intelligence</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DASHSCOPE_DOCMIND</para>
            /// </summary>
            [NameInMap("Parser")]
            [Validation(Required=false)]
            public string Parser { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User not authorized to operate on the specified resource.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>778C0B3B-xxxx-5FC1-A947-36EDD13606AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
