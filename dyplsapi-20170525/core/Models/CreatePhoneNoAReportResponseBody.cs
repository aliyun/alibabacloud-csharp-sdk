// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePhoneNoAReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>请求状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A号码报备结果结构体</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreatePhoneNoAReportResponseBodyData Data { get; set; }
        public class CreatePhoneNoAReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>创建结果</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CreateResult")]
            [Validation(Required=false)]
            public bool? CreateResult { get; set; }

            /// <summary>
            /// <para>创建类型枚举，1为成功，负数为创建失败</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailType")]
            [Validation(Required=false)]
            public long? FailType { get; set; }

        }

        /// <summary>
        /// <para>失败错误提示</para>
        /// 
        /// <b>Example:</b>
        /// <para>手机号码***已存在</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>返回id</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D73E648-0978-18A5-B089-3BB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>请求是否成功</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
