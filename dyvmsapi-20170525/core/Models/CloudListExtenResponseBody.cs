// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudListExtenResponseBody : TeaModel {
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
        public CloudListExtenResponseBodyData Data { get; set; }
        public class CloudListExtenResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("EndRow")]
            [Validation(Required=false)]
            public string EndRow { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FirstPage")]
            [Validation(Required=false)]
            public string FirstPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasNextPage")]
            [Validation(Required=false)]
            public long? HasNextPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasPreviousPage")]
            [Validation(Required=false)]
            public long? HasPreviousPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFirstPage")]
            [Validation(Required=false)]
            public long? IsFirstPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsLastPage")]
            [Validation(Required=false)]
            public long? IsLastPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LastPage")]
            [Validation(Required=false)]
            public string LastPage { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudListExtenResponseBodyDataList> List { get; set; }
            public class CloudListExtenResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>允许的语音编码,支持格式: 1. g729 2. g729,alaw,ulaw 3. alaw,ulaw,g729 4. alaw,ulaw 5. myopus,alaw,ulaw 公网+远程话机支持配置1/2/3;专线+远程话机支持配置1/2;公网+软电话支持配置4;专线+软电话支持配置5;</para>
                /// 
                /// <b>Example:</b>
                /// <para>alaw,ulaw</para>
                /// </summary>
                [NameInMap("Allow")]
                [Validation(Required=false)]
                public string Allow { get; set; }

                /// <summary>
                /// <para>区号</para>
                /// 
                /// <b>Example:</b>
                /// <para>010</para>
                /// </summary>
                [NameInMap("AreaCode")]
                [Validation(Required=false)]
                public string AreaCode { get; set; }

                /// <summary>
                /// <para>呼叫权限，0：无限制，1：国内长途，2：国内本市，3：内部呼叫，默认无限制</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallPower")]
                [Validation(Required=false)]
                public string CallPower { get; set; }

                /// <summary>
                /// <para>创建时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-30 06:09:02</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>降噪开关 0:关闭 1:开启 默认关闭(该参数只有在类型为注册到webrtc才有效)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Denoise")]
                [Validation(Required=false)]
                public long? Denoise { get; set; }

                /// <summary>
                /// <para>企业编号</para>
                /// 
                /// <b>Example:</b>
                /// <para>7000002</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public string EnterpriseId { get; set; }

                /// <summary>
                /// <para>分机号,3-11位</para>
                /// 
                /// <b>Example:</b>
                /// <para>66749</para>
                /// </summary>
                [NameInMap("Exten")]
                [Validation(Required=false)]
                public string Exten { get; set; }

                /// <summary>
                /// <para>呼入是否录音，0：不录用，1：录音，默认录音</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IbRecord")]
                [Validation(Required=false)]
                public long? IbRecord { get; set; }

                /// <summary>
                /// <para>分机号id</para>
                /// 
                /// <b>Example:</b>
                /// <para>59</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>是否允许摘机外呼，0：不允许，1：可以，默认允许</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsDirect")]
                [Validation(Required=false)]
                public long? IsDirect { get; set; }

                /// <summary>
                /// <para>是否允许外呼，0：不允许，1：可以，默认允许</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsOb")]
                [Validation(Required=false)]
                public long? IsOb { get; set; }

                /// <summary>
                /// <para>网络防抖</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("JitterBuffer")]
                [Validation(Required=false)]
                public long? JitterBuffer { get; set; }

                /// <summary>
                /// <para>外呼是否录音，0：不录音，1：录音，默认录音</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObRecord")]
                [Validation(Required=false)]
                public long? ObRecord { get; set; }

                /// <summary>
                /// <para>密码</para>
                /// 
                /// <b>Example:</b>
                /// <para>Aa626670</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>类型，1. 注册到IAD分机 2.注册到webrtc 3.注册到远程话机</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public long? Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("NavigatePages")]
            [Validation(Required=false)]
            public string NavigatePages { get; set; }

            [NameInMap("NavigatepageNums")]
            [Validation(Required=false)]
            public List<string> NavigatepageNums { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public string NextPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>exten</para>
            /// </summary>
            [NameInMap("OrderBy")]
            [Validation(Required=false)]
            public string OrderBy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public string PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Pages")]
            [Validation(Required=false)]
            public string Pages { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PrePage")]
            [Validation(Required=false)]
            public string PrePage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StartRow")]
            [Validation(Required=false)]
            public string StartRow { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public string Total { get; set; }

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
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
