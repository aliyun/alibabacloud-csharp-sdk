// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSystemRuleAggregationTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the aggregation types.</para>
        /// </summary>
        [NameInMap("AggregationTypeList")]
        [Validation(Required=false)]
        public List<ListSystemRuleAggregationTypesResponseBodyAggregationTypeList> AggregationTypeList { get; set; }
        public class ListSystemRuleAggregationTypesResponseBodyAggregationTypeList : TeaModel {
            /// <summary>
            /// <para>The ID of the aggregation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The name of the aggregation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Remote control\<em>\</em>\<em>\</em></para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1427F3BE-8A7E-57F9-BD4E-590B00D2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
