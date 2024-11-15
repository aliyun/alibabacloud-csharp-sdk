// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListAccountFactoryBaselinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The baselines.</para>
        /// </summary>
        [NameInMap("Baselines")]
        [Validation(Required=false)]
        public List<ListAccountFactoryBaselinesResponseBodyBaselines> Baselines { get; set; }
        public class ListAccountFactoryBaselinesResponseBodyBaselines : TeaModel {
            /// <summary>
            /// <para>The baseline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>afb-bp1durvn3lgqe28v****</para>
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public string BaselineId { get; set; }

            /// <summary>
            /// <para>The name of the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("BaselineName")]
            [Validation(Required=false)]
            public string BaselineName { get; set; }

            /// <summary>
            /// <para>The time at which the baseline was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-30T09:09:28Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default baseline</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the baseline. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>System: default baseline.</description></item>
            /// <item><description>Custom: custom baseline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the baseline was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-29T07:08:40Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAALHWGpGoYCcYMxiFfmlhvh62Xr2DzYbz/SAfc*****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3245E413-7CDD-5287-8988-6A94DE8A8369</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
