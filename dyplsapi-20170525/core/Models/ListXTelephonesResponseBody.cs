// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class ListXTelephonesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>返回状态码 0000表示成功 其他表示失败</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListXTelephonesResponseBodyData Data { get; set; }
        public class ListXTelephonesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>数据集合</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListXTelephonesResponseBodyDataList> List { get; set; }
            public class ListXTelephonesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>绑定失败原因</para>
                /// 
                /// <b>Example:</b>
                /// <para>绑定失败用户身份证黑名单</para>
                /// </summary>
                [NameInMap("AuthMsg")]
                [Validation(Required=false)]
                public string AuthMsg { get; set; }

                /// <summary>
                /// <para>绑定时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-29 17:23:58</para>
                /// </summary>
                [NameInMap("BindTime")]
                [Validation(Required=false)]
                public string BindTime { get; set; }

                /// <summary>
                /// <para>购买时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-29 17:23:58</para>
                /// </summary>
                [NameInMap("BuyTime")]
                [Validation(Required=false)]
                public string BuyTime { get; set; }

                /// <summary>
                /// <para>客户号码池key</para>
                /// 
                /// <b>Example:</b>
                /// <para>FC533e6eeb81f4400c87ef3745a21a1a</para>
                /// </summary>
                [NameInMap("CustomerPoolKey")]
                [Validation(Required=false)]
                public string CustomerPoolKey { get; set; }

                /// <summary>
                /// <para>号码池名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试号码池</para>
                /// </summary>
                [NameInMap("CustomerPoolName")]
                [Validation(Required=false)]
                public string CustomerPoolName { get; set; }

                /// <summary>
                /// <para>释放时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-29 17:23:58</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                /// <summary>
                /// <para>短信开通状态：0 未开通 1已开通</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SmsStatus")]
                [Validation(Required=false)]
                public string SmsStatus { get; set; }

                /// <summary>
                /// <para>X号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>17816876546</para>
                /// </summary>
                [NameInMap("Telephone")]
                [Validation(Required=false)]
                public string Telephone { get; set; }

                /// <summary>
                /// <para>号码状态：0 空闲中 1 调拨完成待购买 2购买完成待认证  3 实名认证中  4 实名认证成功  5 认证失败  6 解绑中 7 解绑失败 8已释放 99 超时释放</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TelephoneStatus")]
                [Validation(Required=false)]
                public string TelephoneStatus { get; set; }

                /// <summary>
                /// <para>解绑时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-29 17:23:58</para>
                /// </summary>
                [NameInMap("UnbindTime")]
                [Validation(Required=false)]
                public string UnbindTime { get; set; }

            }

            /// <summary>
            /// <para>页码</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>每页条数</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>符合查询条件的总数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>返回信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>返回是否成功 true  表示成功 false表示失败</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
