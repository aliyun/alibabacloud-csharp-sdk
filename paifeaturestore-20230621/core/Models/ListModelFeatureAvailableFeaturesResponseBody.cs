// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListModelFeatureAvailableFeaturesResponseBody : TeaModel {
        /// <summary>
        /// <para>List of available features.</para>
        /// </summary>
        [NameInMap("AvaliableFeatures")]
        [Validation(Required=false)]
        public List<ListModelFeatureAvailableFeaturesResponseBodyAvaliableFeatures> AvaliableFeatures { get; set; }
        public class ListModelFeatureAvailableFeaturesResponseBodyAvaliableFeatures : TeaModel {
            /// <summary>
            /// <para>Feature name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_fea</para>
            /// </summary>
            [NameInMap("SourceName")]
            [Validation(Required=false)]
            public string SourceName { get; set; }

            /// <summary>
            /// <para>Feature source.</para>
            /// <list type="bullet">
            /// <item><description><para>FeatureView</para>
            /// </description></item>
            /// <item><description><para>LabelTable</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FeatureView</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>Feature value type.</para>
            /// <list type="bullet">
            /// <item><description><para>INTEGER</para>
            /// </description></item>
            /// <item><description><para>DOUBLE</para>
            /// </description></item>
            /// <item><description><para>STRING</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Total number of features.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ED4DEA2F-F216-57F0-AE28-08D791233280</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
