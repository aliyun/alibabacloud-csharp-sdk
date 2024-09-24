// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the search conditions.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeImageCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeImageCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the search condition.</para>
            /// <list type="bullet">
            /// <item><description><b>tag</b>: the tag of the image</description></item>
            /// <item><description><b>digest</b>: the digest of the image</description></item>
            /// <item><description><b>vulStatus</b>: the status of the vulnerability</description></item>
            /// <item><description><b>alarmStatus</b>: the status of the alert</description></item>
            /// <item><description><b>riskStatus</b>: the status of the risk</description></item>
            /// <item><description><b>registryType</b>: the type of the image repository</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vulStatus</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the search condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>input</b>: The search condition needs to be specified.</description></item>
            /// <item><description><b>select</b>: The search condition is an option that can be selected from the drop-down list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>input</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The values of the search condition. This parameter is returned only if the value of Type is select.</para>
            /// <remarks>
            /// <para>If the value of <b>Type</b> is <b>input</b>, the value of this parameter is an empty string.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>NO,YES</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
