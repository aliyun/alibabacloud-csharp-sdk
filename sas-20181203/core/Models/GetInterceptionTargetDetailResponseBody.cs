// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInterceptionTargetDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65AADFC-1D20-5A6A-8F6A-9FA53C0DC1F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the network object.</para>
        /// </summary>
        [NameInMap("RuleTarget")]
        [Validation(Required=false)]
        public GetInterceptionTargetDetailResponseBodyRuleTarget RuleTarget { get; set; }
        public class GetInterceptionTargetDetailResponseBodyRuleTarget : TeaModel {
            /// <summary>
            /// <para>The name of the application to which the network object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>netperf-client</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The ID of the container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca6e6594def8d4be8b2795fd12c32****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-test-cnnf</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>An array that consists of the images of the network object.</para>
            /// </summary>
            [NameInMap("ImageList")]
            [Validation(Required=false)]
            public List<string> ImageList { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>secondary</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>An array that consists of the labels specified for the network object.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<string> TagList { get; set; }

            /// <summary>
            /// <para>The ID of the network object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400723</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public long? TargetId { get; set; }

            /// <summary>
            /// <para>The name of the network object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>destination-test-obj-Na3cF</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The type of the network object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IMAGE</b>: image</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

    }

}
