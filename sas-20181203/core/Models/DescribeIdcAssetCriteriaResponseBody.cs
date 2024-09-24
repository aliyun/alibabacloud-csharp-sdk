// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcAssetCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the asset search conditions.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeIdcAssetCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeIdcAssetCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the search condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scannedIp</para>
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
            /// <para>select</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The attribute values of the assets that match the keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.*</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11C96623-E106-59C9-866D-A6C82911****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
