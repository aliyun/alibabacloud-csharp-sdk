// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetModelFeatureFGFeatureResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the lookup features.</para>
        /// </summary>
        [NameInMap("LookupFeatures")]
        [Validation(Required=false)]
        public List<GetModelFeatureFGFeatureResponseBodyLookupFeatures> LookupFeatures { get; set; }
        public class GetModelFeatureFGFeatureResponseBodyLookupFeatures : TeaModel {
            /// <summary>
            /// <para>The default value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1024</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>The name of the generated feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            /// <summary>
            /// <para>The domain of the key feature.</para>
            /// <list type="bullet">
            /// <item><description><para>User: The user side.</para>
            /// </description></item>
            /// <item><description><para>Item: The item side.</para>
            /// </description></item>
            /// <item><description><para>Context: The context.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Item</para>
            /// </summary>
            [NameInMap("KeyFeatureDomain")]
            [Validation(Required=false)]
            public string KeyFeatureDomain { get; set; }

            /// <summary>
            /// <para>The name of the key feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("KeyFeatureName")]
            [Validation(Required=false)]
            public string KeyFeatureName { get; set; }

            /// <summary>
            /// <para>The domain of the map feature.</para>
            /// <list type="bullet">
            /// <item><description><para>User: The user side.</para>
            /// </description></item>
            /// <item><description><para>Item: The item side.</para>
            /// </description></item>
            /// <item><description><para>Context: The context.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("MapFeatureDomain")]
            [Validation(Required=false)]
            public string MapFeatureDomain { get; set; }

            /// <summary>
            /// <para>The name of the map feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("MapFeatureName")]
            [Validation(Required=false)]
            public string MapFeatureName { get; set; }

            /// <summary>
            /// <para>The value type of the feature.</para>
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
            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        /// <summary>
        /// <para>The information about the raw features.</para>
        /// </summary>
        [NameInMap("RawFeatures")]
        [Validation(Required=false)]
        public List<GetModelFeatureFGFeatureResponseBodyRawFeatures> RawFeatures { get; set; }
        public class GetModelFeatureFGFeatureResponseBodyRawFeatures : TeaModel {
            /// <summary>
            /// <para>The default value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1024</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>The domain of the original feature.</para>
            /// <list type="bullet">
            /// <item><description><para>User: The user side.</para>
            /// </description></item>
            /// <item><description><para>Item: The item side.</para>
            /// </description></item>
            /// <item><description><para>Context: The context.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("FeatureDomain")]
            [Validation(Required=false)]
            public string FeatureDomain { get; set; }

            /// <summary>
            /// <para>The name of the generated feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            /// <summary>
            /// <para>The type of the raw FG feature.</para>
            /// <list type="bullet">
            /// <item><description><para>IdFeature: The primary key.</para>
            /// </description></item>
            /// <item><description><para>RawFeature: The raw feature.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IdFeature</para>
            /// </summary>
            [NameInMap("FeatureType")]
            [Validation(Required=false)]
            public string FeatureType { get; set; }

            /// <summary>
            /// <para>The name of the original feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("InputFeatureName")]
            [Validation(Required=false)]
            public string InputFeatureName { get; set; }

            /// <summary>
            /// <para>The value type of the feature.</para>
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
            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E23EFF09-58AA-5420-934F-8453AE01548D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The reserved fields.</para>
        /// </summary>
        [NameInMap("Reserves")]
        [Validation(Required=false)]
        public List<string> Reserves { get; set; }

        /// <summary>
        /// <para>The information about the sequence features.</para>
        /// </summary>
        [NameInMap("SequenceFeatures")]
        [Validation(Required=false)]
        public List<GetModelFeatureFGFeatureResponseBodySequenceFeatures> SequenceFeatures { get; set; }
        public class GetModelFeatureFGFeatureResponseBodySequenceFeatures : TeaModel {
            /// <summary>
            /// <para>The separator for feature attributes.</para>
            /// 
            /// <b>Example:</b>
            /// <h1></h1>
            /// </summary>
            [NameInMap("AttributeDelim")]
            [Validation(Required=false)]
            public string AttributeDelim { get; set; }

            /// <summary>
            /// <para>The name of the sequence feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            /// <summary>
            /// <para>The separator for the sequence feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>;</para>
            /// </summary>
            [NameInMap("SequenceDelim")]
            [Validation(Required=false)]
            public string SequenceDelim { get; set; }

            /// <summary>
            /// <para>The maximum length of the sequence feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("SequenceLength")]
            [Validation(Required=false)]
            public long? SequenceLength { get; set; }

            /// <summary>
            /// <para>A list of sub-features for the sequence feature.</para>
            /// </summary>
            [NameInMap("SubFeatures")]
            [Validation(Required=false)]
            public List<GetModelFeatureFGFeatureResponseBodySequenceFeaturesSubFeatures> SubFeatures { get; set; }
            public class GetModelFeatureFGFeatureResponseBodySequenceFeaturesSubFeatures : TeaModel {
                /// <summary>
                /// <para>The default value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1024</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The domain of the original feature.</para>
                /// <list type="bullet">
                /// <item><description><para>User: The user side.</para>
                /// </description></item>
                /// <item><description><para>Item: The item side.</para>
                /// </description></item>
                /// <item><description><para>Context: The context.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>User</para>
                /// </summary>
                [NameInMap("FeatureDomain")]
                [Validation(Required=false)]
                public string FeatureDomain { get; set; }

                /// <summary>
                /// <para>The name of the generated feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>item_id</para>
                /// </summary>
                [NameInMap("FeatureName")]
                [Validation(Required=false)]
                public string FeatureName { get; set; }

                /// <summary>
                /// <para>The type of the FG feature.</para>
                /// <list type="bullet">
                /// <item><description><para>IdFeature: The primary key.</para>
                /// </description></item>
                /// <item><description><para>RawFeature: The raw feature.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IdFeature</para>
                /// </summary>
                [NameInMap("FeatureType")]
                [Validation(Required=false)]
                public string FeatureType { get; set; }

                /// <summary>
                /// <para>The name of the original feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>item_id</para>
                /// </summary>
                [NameInMap("InputFeatureName")]
                [Validation(Required=false)]
                public string InputFeatureName { get; set; }

                /// <summary>
                /// <para>The value type of the feature.</para>
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
                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

        }

    }

}
