// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRepoCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>An array consisting of the filter conditions that are supported by the image repository.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeImageRepoCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeImageRepoCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the search condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>instanceId</b>: the ID of the image instance.</description></item>
            /// <item><description><b>repoName</b>: the name of the image repository.</description></item>
            /// <item><description><b>repoId</b>: the ID of the image repository.</description></item>
            /// <item><description><b>repoNamespace</b>: the namespace of the image repository.</description></item>
            /// <item><description><b>regionId</b>: the region in which the image resides.</description></item>
            /// <item><description><b>vulStatus</b>: indicates whether vulnerabilities exist.</description></item>
            /// <item><description><b>alarmStatus</b>: indicates whether security alerts exist.</description></item>
            /// <item><description><b>hcStatus</b>: indicates whether baseline risks exist.</description></item>
            /// <item><description><b>riskStatus</b>: indicates whether risks exist.</description></item>
            /// <item><description><b>registryType</b>: the type of the image repository.</description></item>
            /// <item><description><b>ImageId</b>: the image ID.</description></item>
            /// <item><description><b>tag</b>: the image tag.</description></item>
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
            /// <para>select</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The values of the search condition. This parameter is returned only if the value of <b>Type</b> is set to <b>select</b>.</para>
            /// <remarks>
            /// <para>If the value of <b>Type</b> is set to <b>input</b>, the return value of this parameter is empty.</para>
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
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F35F45B0-5D6B-4238-BE02-A62D0760E840</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
