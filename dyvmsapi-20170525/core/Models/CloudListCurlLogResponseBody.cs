// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudListCurlLogResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloudListCurlLogResponseBodyData Data { get; set; }
        public class CloudListCurlLogResponseBodyData : TeaModel {
            /// <summary>
            /// <para>返回数据JSON格式</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudListCurlLogResponseBodyDataList> List { get; set; }
            public class CloudListCurlLogResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>文本类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public long? ContentType { get; set; }

                /// <summary>
                /// <para>创建时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774822134415</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>当月</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("CurrentMonth")]
                [Validation(Required=false)]
                public string CurrentMonth { get; set; }

                /// <summary>
                /// <para>延迟推送时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public long? Delay { get; set; }

                /// <summary>
                /// <para>推送结束时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774822137959</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>企业id</para>
                /// 
                /// <b>Example:</b>
                /// <para>7122600</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public string EnterpriseId { get; set; }

                /// <summary>
                /// <para>请求头</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public string Headers { get; set; }

                /// <summary>
                /// <para>日志id</para>
                /// 
                /// <b>Example:</b>
                /// <para>12715</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>推送登记</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public long? Level { get; set; }

                /// <summary>
                /// <para>推送方法</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>推送参数</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("Params")]
                [Validation(Required=false)]
                public string Params { get; set; }

                /// <summary>
                /// <para>推送位置</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                /// <summary>
                /// <para>推送时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774822137191</para>
                /// </summary>
                [NameInMap("RequestTime")]
                [Validation(Required=false)]
                public string RequestTime { get; set; }

                /// <summary>
                /// <para>推送状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>返回文本</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("ResultText")]
                [Validation(Required=false)]
                public string ResultText { get; set; }

                /// <summary>
                /// <para>重试次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Retry")]
                [Validation(Required=false)]
                public long? Retry { get; set; }

                /// <summary>
                /// <para>推送开始时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774822134132</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>状态码</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <para>超时时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public string Timeout { get; set; }

                /// <summary>
                /// <para>推送类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public long? Type { get; set; }

                /// <summary>
                /// <para>推送类型字符串</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("TypeStr")]
                [Validation(Required=false)]
                public string TypeStr { get; set; }

                /// <summary>
                /// <para>唯一标示</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

                /// <summary>
                /// <para>推送url</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.aaa.com/index.htm">https://www.aaa.com/index.htm</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6086693B-2250-17CE-A41F-06259AB6DB1B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
