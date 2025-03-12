// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether a restart is required for changes to the parameter to take effect. Valid values:   </para>
        /// <list type="bullet">
        /// <item><description>true: A restart is required.   </description></item>
        /// <item><description>false: A restart is not required.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeParametersResponseBodyParameters> Parameters { get; set; }
        public class DescribeParametersResponseBodyParameters : TeaModel {
            /// <summary>
            /// <para>DescribeParameters</para>
            /// </summary>
            [NameInMap("AcceptableValue")]
            [Validation(Required=false)]
            public List<string> AcceptableValue { get; set; }

            /// <summary>
            /// <para>The ID of the OceanBase cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("CurrentValue")]
            [Validation(Required=false)]
            public string CurrentValue { get; set; }

            /// <summary>
            /// <pre><c>http(s)://[Endpoint]/?Action=DescribeParameters
            /// &amp;InstanceId=ob317v4uif****
            /// &amp;Dimension=TENANT
            /// &amp;DimensionValue=ob2mr3oae0****
            /// &amp;Common request parameters
            /// </c></pre>
            /// 
            /// <b>Example:</b>
            /// <para>600s</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>The description of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The operation that you want to perform.<br>Set the value to <b>DescribeParameters</b>.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connect_timeout</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedReboot")]
            [Validation(Required=false)]
            public bool? NeedReboot { get; set; }

            /// <summary>
            /// <para>参数是否只读</para>
            /// </summary>
            [NameInMap("Readonly")]
            [Validation(Required=false)]
            public bool? Readonly { get; set; }

            /// <summary>
            /// <para>{
            ///     &quot;RequestId&quot;: &quot;EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C&quot;,
            ///     &quot;Parameters&quot;: [
            ///         {
            ///             &quot;Description&quot;: &quot;The maximum delay allowed in weak-consistency reads.&quot;,
            ///             &quot;ValueType&quot;: &quot;CAPACITY&quot;,
            ///             &quot;CurrentValue&quot;: &quot;600&quot;,
            ///             &quot;NeedReboot&quot;: false,
            ///             &quot;Name&quot;: &quot;connect_timeout&quot;,
            ///             &quot;DefaultValue&quot;: &quot;600s&quot;,
            ///             &quot;RejectedValue&quot;: [
            ///                 &quot;1s&quot;
            ///             ],
            ///             &quot;AcceptableValue&quot;: [
            ///                 &quot;1s&quot;
            ///             ]
            ///         }
            ///     ]
            /// }</para>
            /// </summary>
            [NameInMap("RejectedValue")]
            [Validation(Required=false)]
            public List<string> RejectedValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>s</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// <para>The invalid value range of the parameter.<br>It is an array with two string elements, which represents a range. The first element represents the minimum value and the second element represents the maximum value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAPACITY</para>
            /// </summary>
            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        /// <summary>
        /// <para>The return result of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
