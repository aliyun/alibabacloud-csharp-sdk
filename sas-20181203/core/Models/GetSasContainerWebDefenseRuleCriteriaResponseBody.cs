// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSasContainerWebDefenseRuleCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of query criteria.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<GetSasContainerWebDefenseRuleCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class GetSasContainerWebDefenseRuleCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the query criterion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the query criterion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>input</b>: Input type. You must manually enter the query content when using this query criterion.</description></item>
            /// <item><description><b>select</b>: Selection type. You must select a value from the options list (the <b>Values</b> field) when using this query criterion.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>select</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The available options when <b>Type</b> (the type of the query criterion) is set to <b>select</b> (selection type).</para>
            /// <remarks>
            /// <para>When <b>Type</b> (the type of the query criterion) is set to <b>input</b> (input type), this parameter returns an empty value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>athor_bid</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
