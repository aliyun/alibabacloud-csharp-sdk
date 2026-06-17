// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupDynamicRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The responses code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2170B94A-1576-4D65-900E-2093037CDAF3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public DescribeMonitorGroupDynamicRulesResponseBodyResource Resource { get; set; }
        public class DescribeMonitorGroupDynamicRulesResponseBodyResource : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeMonitorGroupDynamicRulesResponseBodyResourceResource> Resource { get; set; }
            public class DescribeMonitorGroupDynamicRulesResponseBodyResourceResource : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("FilterRelation")]
                [Validation(Required=false)]
                public string FilterRelation { get; set; }

                [NameInMap("Filters")]
                [Validation(Required=false)]
                public DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFilters Filters { get; set; }
                public class DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFilters : TeaModel {
                    [NameInMap("Filter")]
                    [Validation(Required=false)]
                    public List<DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFiltersFilter> Filter { get; set; }
                    public class DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFiltersFilter : TeaModel {
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public string Function { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
