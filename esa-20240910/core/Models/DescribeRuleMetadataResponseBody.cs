// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeRuleMetadataResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of metadata.</para>
        /// </summary>
        [NameInMap("Datas")]
        [Validation(Required=false)]
        public List<DescribeRuleMetadataResponseBodyDatas> Datas { get; set; }
        public class DescribeRuleMetadataResponseBodyDatas : TeaModel {
            /// <summary>
            /// <para>The subset of metadata.</para>
            /// </summary>
            [NameInMap("Children")]
            [Validation(Required=false)]
            public List<DescribeRuleMetadataResponseBodyDatasChildren> Children { get; set; }
            public class DescribeRuleMetadataResponseBodyDatasChildren : TeaModel {
                /// <summary>
                /// <para>The human-readable content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京市</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN-BJ</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The human-readable content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中国</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6947DF8-7AC0-50D0-BADA-177646ABB85A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
