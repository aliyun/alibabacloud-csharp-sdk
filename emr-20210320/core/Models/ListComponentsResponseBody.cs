// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListComponentsResponseBody : TeaModel {
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<ListComponentsResponseBodyComponents> Components { get; set; }
        public class ListComponentsResponseBodyComponents : TeaModel {
            /// <summary>
            /// <para>应用名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>KNOX</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>属性列表。</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<Attribute> Attributes { get; set; }

            /// <summary>
            /// <para>组件名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>KNOX</para>
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// <para>命名空间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>安装该组件的机器总数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

        }

        /// <summary>
        /// <para>本次请求所返回的最大记录条数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>返回读取到的数据位置，空代表数据已经读取完毕。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFAC608A-5DC3-174F-93C6-9F88CA6D5875</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>本次请求条件下的数据总量。</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
