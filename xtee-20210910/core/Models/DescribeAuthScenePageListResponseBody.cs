// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAuthScenePageListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeAuthScenePageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeAuthScenePageListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The number of General Policy policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("commonRuleCount")]
            [Validation(Required=false)]
            public long? CommonRuleCount { get; set; }

            /// <summary>
            /// <para>The number of custom policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("customRuleCount")]
            [Validation(Required=false)]
            public long? CustomRuleCount { get; set; }

            /// <summary>
            /// <para>The event code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>de_avypfd8253</para>
            /// </summary>
            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            /// <summary>
            /// <para>The scenario name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>注册风险识别服务</para>
            /// </summary>
            [NameInMap("sceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>account_abuse</para>
            /// </summary>
            [NameInMap("serverName")]
            [Validation(Required=false)]
            public string ServerName { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public long? TotalItem { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
