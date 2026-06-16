// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSceneEventPageListResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page in the response. Default value: 20. Minimum value: 1. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID. Each request has a unique ID for troubleshooting purposes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned array.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeSceneEventPageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeSceneEventPageListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The number of General Policy rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("commonRuleCount")]
            [Validation(Required=false)]
            public string CommonRuleCount { get; set; }

            /// <summary>
            /// <para>The number of custom policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("customRuleCount")]
            [Validation(Required=false)]
            public string CustomRuleCount { get; set; }

            /// <summary>
            /// <para>The event code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>de_aszbjb7236</para>
            /// </summary>
            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            /// <summary>
            /// <para>The event name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>注册风险</para>
            /// </summary>
            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The time when the event was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1565701886000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The user who last modified the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>公有云用户uid</para>
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The number of user-defined policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("normalRuleCount")]
            [Validation(Required=false)]
            public string NormalRuleCount { get; set; }

            /// <summary>
            /// <para>The service code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>device_risk</para>
            /// </summary>
            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// <para>The usage status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>使用/未使用</para>
            /// </summary>
            [NameInMap("useStatus")]
            [Validation(Required=false)]
            public string UseStatus { get; set; }

            /// <summary>
            /// <para>The number of whitebox implementation policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("whiteBoxRuleCount")]
            [Validation(Required=false)]
            public string WhiteBoxRuleCount { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
