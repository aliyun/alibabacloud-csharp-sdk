// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetAlertStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code:  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates successful authorization;  </description></item>
        /// <item><description>Other status codes indicate failed authorization. When authorization fails, view the <c>message</c> field to obtain detailed error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAlertStrategyResponseBodyData Data { get; set; }
        public class GetAlertStrategyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Creation Time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751520976660</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>Indicates whether the alert policy is enabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Alert policy ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>k8s label</para>
            /// </summary>
            [NameInMap("k8sLabel")]
            [Validation(Required=false)]
            public bool? K8sLabel { get; set; }

            /// <summary>
            /// <para>Policy Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>strategy1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Details of the alert policy</para>
            /// </summary>
            [NameInMap("strategy")]
            [Validation(Required=false)]
            public GetAlertStrategyResponseBodyDataStrategy Strategy { get; set; }
            public class GetAlertStrategyResponseBodyDataStrategy : TeaModel {
                /// <summary>
                /// <para>Set of clusters that accept alerts</para>
                /// </summary>
                [NameInMap("clusters")]
                [Validation(Required=false)]
                public List<string> Clusters { get; set; }

                [NameInMap("destinations")]
                [Validation(Required=false)]
                public object Destinations { get; set; }

                /// <summary>
                /// <para>List of abnormal items that accept alerts</para>
                /// 
                /// <b>Example:</b>
                /// <para>节点CPU使用率检测</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public object Items { get; set; }

            }

            /// <summary>
            /// <para>User ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1222933234714935</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>Update Time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751254826285</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>Error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty;  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
