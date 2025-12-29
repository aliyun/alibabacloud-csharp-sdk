// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListServiceInstanceForPageResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>状态码，OK表示响应成功</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>响应消息</para>
        /// 
        /// <b>Example:</b>
        /// <para>每页最大100条！</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public ListServiceInstanceForPageResponseBodyModel Model { get; set; }
        public class ListServiceInstanceForPageResponseBodyModel : TeaModel {
            /// <summary>
            /// <para>当前页码</para>
            /// 
            /// <b>Example:</b>
            /// <para>47</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>每页数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>59</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListServiceInstanceForPageResponseBodyModelRecords> Records { get; set; }
            public class ListServiceInstanceForPageResponseBodyModelRecords : TeaModel {
                /// <summary>
                /// <para>aliUid</para>
                /// 
                /// <b>Example:</b>
                /// <para>11******123</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// <para>服务实例号</para>
                /// 
                /// <b>Example:</b>
                /// <para>0571****1234</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>创建时间（时间戳）</para>
                /// 
                /// <b>Example:</b>
                /// <para>1759109856000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>实例状态（init：初始化；usable：可用；unusable：不可用；destory：注销）</para>
                /// 
                /// <b>Example:</b>
                /// <para>init</para>
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// <para>服务实例名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试数据</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>关联可用数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("RelationAvailableCount")]
                [Validation(Required=false)]
                public long? RelationAvailableCount { get; set; }

                /// <summary>
                /// <para>关联总数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("RelationTotalCount")]
                [Validation(Required=false)]
                public long? RelationTotalCount { get; set; }

                /// <summary>
                /// <para>场景ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>29</para>
                /// </summary>
                [NameInMap("SceneId")]
                [Validation(Required=false)]
                public long? SceneId { get; set; }

                /// <summary>
                /// <para>场景名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>系统通知</para>
                /// </summary>
                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                /// <summary>
                /// <para>绑定状态：绑定；未绑定</para>
                /// 
                /// <b>Example:</b>
                /// <para>绑定</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>用途ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>96</para>
                /// </summary>
                [NameInMap("UsageId")]
                [Validation(Required=false)]
                public long? UsageId { get; set; }

                /// <summary>
                /// <para>用途名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>语音通知</para>
                /// </summary>
                [NameInMap("UsageName")]
                [Validation(Required=false)]
                public string UsageName { get; set; }

            }

            /// <summary>
            /// <para>总数</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <para>总页数</para>
            /// 
            /// <b>Example:</b>
            /// <para>76</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

        /// <summary>
        /// <para>请求唯一id</para>
        /// 
        /// <b>Example:</b>
        /// <para>ED18A5AE-9BBC-5851-1111-8E5B8C23CEDE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>是否成功</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
