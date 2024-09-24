// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>The search conditions that are used to search for exposed assets.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeExposedInstanceCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeExposedInstanceCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the search condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instanceId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the search condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>input</b>: You must configure the search condition.</description></item>
            /// <item><description><b>select</b>: You must select a search condition from the <b>Values</b> list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>select</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The value of the search condition. This parameter is returned only when the value of the <b>Type</b> parameter is <b>select</b>.</para>
            /// <remarks>
            /// <para> If the value of the <b>Type</b> parameter is <b>input</b>, this parameter is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp19r0fdd39idxhf****</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D9CDB47-6191-4415-BE63-7E8B12CD4FBE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
