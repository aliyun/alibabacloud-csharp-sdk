// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetMediaResourceIdResponseBody : TeaModel {
        /// <summary>
        /// <para>请求状态码。</para>
        /// <list type="bullet">
        /// <item><description>返回OK代表请求成功。</description></item>
        /// <item><description>其他错误码，请参见<a href="https://help.aliyun.com/document_detail/101346.html">错误码列表</a>。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>返回数据。</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMediaResourceIdResponseBodyData Data { get; set; }
        public class GetMediaResourceIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>资源下载地址。</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://test-example.com/download.jpg">http://test-example.com/download.jpg</a></para>
            /// </summary>
            [NameInMap("ResUrlDownload")]
            [Validation(Required=false)]
            public string ResUrlDownload { get; set; }

            /// <summary>
            /// <para>资源ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public long? ResourceId { get; set; }

        }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>F07CF237-F6E3-5F77-B91B-F9B7C5DE84AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>调用接口是否成功。取值：</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>：调用成功。</para>
        /// </description></item>
        /// <item><description><para><b>false</b>：调用失败。</para>
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
