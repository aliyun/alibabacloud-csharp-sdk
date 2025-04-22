// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySecretAPhoneNoToCustResponseBody : TeaModel {
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
        /// <para>A号码报备状态查询结构体</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySecretAPhoneNoToCustResponseBodyData Data { get; set; }
        public class QuerySecretAPhoneNoToCustResponseBodyData : TeaModel {
            /// <summary>
            /// <para>所属a号码组id</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("ANoWhiteGroupId")]
            [Validation(Required=false)]
            public string ANoWhiteGroupId { get; set; }

            /// <summary>
            /// <para>固话报备的经办人/法人电话</para>
            /// 
            /// <b>Example:</b>
            /// <para>130*****8888</para>
            /// </summary>
            [NameInMap("CustPhoneNo")]
            [Validation(Required=false)]
            public string CustPhoneNo { get; set; }

            /// <summary>
            /// <para>号码类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mobile</para>
            /// </summary>
            [NameInMap("NoType")]
            [Validation(Required=false)]
            public string NoType { get; set; }

            /// <summary>
            /// <para>A号码</para>
            /// 
            /// <b>Example:</b>
            /// <para>130*****1234</para>
            /// </summary>
            [NameInMap("PhoneNoA")]
            [Validation(Required=false)]
            public string PhoneNoA { get; set; }

            /// <summary>
            /// <para>备注（客户自己的业务备注，可编辑）</para>
            /// 
            /// <b>Example:</b>
            /// <para>***报备</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>报备失败原因</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;系统判断为不同人&quot;]</para>
            /// </summary>
            [NameInMap("ReportResult")]
            [Validation(Required=false)]
            public string ReportResult { get; set; }

            /// <summary>
            /// <para>报备结果</para>
            /// 
            /// <b>Example:</b>
            /// <para>REVIEWING</para>
            /// </summary>
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

        }

        /// <summary>
        /// <para>失败错误提示</para>
        /// 
        /// <b>Example:</b>
        /// <para>号码组不存在</para>
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
