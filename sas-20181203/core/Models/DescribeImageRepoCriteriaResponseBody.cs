// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRepoCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of supported search criteria for image repositories.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeImageRepoCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeImageRepoCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the search criterion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>instanceId</b>: image instance ID.</description></item>
            /// <item><description><b>repoName</b>: repository name.</description></item>
            /// <item><description><b>repoId</b>: repository ID.</description></item>
            /// <item><description><b>repoNamespace</b>: repository namespace.</description></item>
            /// <item><description><b>regionId</b>: image region.</description></item>
            /// <item><description><b>vulStatus</b>: whether vulnerabilities exist.</description></item>
            /// <item><description><b>alarmStatus</b>: whether security alerts exist.</description></item>
            /// <item><description><b>hcStatus</b>: whether baseline risks exist.</description></item>
            /// <item><description><b>riskStatus</b>: whether risks exist.</description></item>
            /// <item><description><b>registryType</b>: repository type.</description></item>
            /// <item><description><b>imageId</b>: image ID.</description></item>
            /// <item><description><b>tag</b>: image tag.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vulStatus</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the search criterion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>input</b>: requires manual input of the search field.</description></item>
            /// <item><description><b>select</b>: requires selecting a subtype from a drop-down list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>select</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The available options when <b>Type</b> (the type of the search criterion) is <b>select</b> (selection type).</para>
            /// <remarks>
            /// <para>When <b>Type</b> (the type of the search criterion) is <b>input</b> (input type), this parameter returns an empty value.</para>
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
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F35F45B0-5D6B-4238-BE02-A62D0760E840</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
