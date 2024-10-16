// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetModelFeatureFGFeatureResponseBody : TeaModel {
        [NameInMap("LookupFeatures")]
        [Validation(Required=false)]
        public List<GetModelFeatureFGFeatureResponseBodyLookupFeatures> LookupFeatures { get; set; }
        public class GetModelFeatureFGFeatureResponseBodyLookupFeatures : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>-1024</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Item</para>
            /// </summary>
            [NameInMap("KeyFeatureDomain")]
            [Validation(Required=false)]
            public string KeyFeatureDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("KeyFeatureName")]
            [Validation(Required=false)]
            public string KeyFeatureName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("MapFeatureDomain")]
            [Validation(Required=false)]
            public string MapFeatureDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("MapFeatureName")]
            [Validation(Required=false)]
            public string MapFeatureName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        [NameInMap("RawFeatures")]
        [Validation(Required=false)]
        public List<GetModelFeatureFGFeatureResponseBodyRawFeatures> RawFeatures { get; set; }
        public class GetModelFeatureFGFeatureResponseBodyRawFeatures : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>-1024</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("FeatureDomain")]
            [Validation(Required=false)]
            public string FeatureDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IdFeature</para>
            /// </summary>
            [NameInMap("FeatureType")]
            [Validation(Required=false)]
            public string FeatureType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("InputFeatureName")]
            [Validation(Required=false)]
            public string InputFeatureName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E23EFF09-58AA-5420-934F-8453AE01548D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Reserves")]
        [Validation(Required=false)]
        public List<string> Reserves { get; set; }

        [NameInMap("SequenceFeatures")]
        [Validation(Required=false)]
        public List<GetModelFeatureFGFeatureResponseBodySequenceFeatures> SequenceFeatures { get; set; }
        public class GetModelFeatureFGFeatureResponseBodySequenceFeatures : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <h1></h1>
            /// </summary>
            [NameInMap("AttributeDelim")]
            [Validation(Required=false)]
            public string AttributeDelim { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>item_id</para>
            /// </summary>
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>;</para>
            /// </summary>
            [NameInMap("SequenceDelim")]
            [Validation(Required=false)]
            public string SequenceDelim { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("SequenceLength")]
            [Validation(Required=false)]
            public long? SequenceLength { get; set; }

            [NameInMap("SubFeatures")]
            [Validation(Required=false)]
            public List<GetModelFeatureFGFeatureResponseBodySequenceFeaturesSubFeatures> SubFeatures { get; set; }
            public class GetModelFeatureFGFeatureResponseBodySequenceFeaturesSubFeatures : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>-1024</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>User</para>
                /// </summary>
                [NameInMap("FeatureDomain")]
                [Validation(Required=false)]
                public string FeatureDomain { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>item_id</para>
                /// </summary>
                [NameInMap("FeatureName")]
                [Validation(Required=false)]
                public string FeatureName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IdFeature</para>
                /// </summary>
                [NameInMap("FeatureType")]
                [Validation(Required=false)]
                public string FeatureType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>item_id</para>
                /// </summary>
                [NameInMap("InputFeatureName")]
                [Validation(Required=false)]
                public string InputFeatureName { get; set; }

                /// <summary>
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
