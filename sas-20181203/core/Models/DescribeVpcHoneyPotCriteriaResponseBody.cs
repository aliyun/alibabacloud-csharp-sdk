// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVpcHoneyPotCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the search conditions.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeVpcHoneyPotCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeVpcHoneyPotCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the search condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpcRegionId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the search condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>input</b>: You must manually enter the search condition.</description></item>
            /// <item><description><b>select</b>: You must select a search condition from the <b>Values</b> drop-down list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>select</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The values of the search condition. This parameter is returned only if the value of <b>Type</b> is <b>select</b>.</para>
            /// <remarks>
            /// <para>If the value of <b>Type</b> is <b>input</b>, the value of this parameter is an empty string.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ap-southeast-2,eu-west-1</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FCE38ADB-7361-4212-AD87-A4514E4DF925</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
