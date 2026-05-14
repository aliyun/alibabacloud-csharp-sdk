// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkListClientsResponseBody : TeaModel {
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
        public ClinkListClientsResponseBodyData Data { get; set; }
        public class ClinkListClientsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>座席对象列表</para>
            /// </summary>
            [NameInMap("Clients")]
            [Validation(Required=false)]
            public List<ClinkListClientsResponseBodyDataClients> Clients { get; set; }
            public class ClinkListClientsResponseBodyDataClients : TeaModel {
                /// <summary>
                /// <para>是否激活，0: 否；1: 是</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public long? Active { get; set; }

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
                /// <para>座席绑定电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("BindTel")]
                [Validation(Required=false)]
                public string BindTel { get; set; }

                /// <summary>
                /// <para>座席号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>创建时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>座席crm id</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CrmId")]
                [Validation(Required=false)]
                public string CrmId { get; set; }

                /// <summary>
                /// <para>号码隐藏类型，0: 不隐藏；1: 隐藏规则与全局设置保持一致</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HiddenTel")]
                [Validation(Required=false)]
                public long? HiddenTel { get; set; }

                /// <summary>
                /// <para>座席 Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>2222</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>座席所属队列的队列号数组</para>
                /// </summary>
                [NameInMap("Qnos")]
                [Validation(Required=false)]
                public List<string> Qnos { get; set; }

                /// <summary>
                /// <para>座席角色，0: 普通座席；1: 班长座席</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public long? Role { get; set; }

                /// <summary>
                /// <para>座席状态，0: 离线；1: 在线</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <para>座席类型，1：全渠道、2：呼叫中心、3：在线客服</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public long? Type { get; set; }

                /// <summary>
                /// <para>修改时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

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
