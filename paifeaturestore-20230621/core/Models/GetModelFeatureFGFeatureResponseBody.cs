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
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            [NameInMap("KeyFeatureDomain")]
            [Validation(Required=false)]
            public string KeyFeatureDomain { get; set; }

            [NameInMap("KeyFeatureName")]
            [Validation(Required=false)]
            public string KeyFeatureName { get; set; }

            [NameInMap("MapFeatureDomain")]
            [Validation(Required=false)]
            public string MapFeatureDomain { get; set; }

            [NameInMap("MapFeatureName")]
            [Validation(Required=false)]
            public string MapFeatureName { get; set; }

            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        [NameInMap("RawFeatures")]
        [Validation(Required=false)]
        public List<GetModelFeatureFGFeatureResponseBodyRawFeatures> RawFeatures { get; set; }
        public class GetModelFeatureFGFeatureResponseBodyRawFeatures : TeaModel {
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("FeatureDomain")]
            [Validation(Required=false)]
            public string FeatureDomain { get; set; }

            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            [NameInMap("FeatureType")]
            [Validation(Required=false)]
            public string FeatureType { get; set; }

            [NameInMap("InputFeatureName")]
            [Validation(Required=false)]
            public string InputFeatureName { get; set; }

            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

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
            [NameInMap("AttributeDelim")]
            [Validation(Required=false)]
            public string AttributeDelim { get; set; }

            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            [NameInMap("SequenceDelim")]
            [Validation(Required=false)]
            public string SequenceDelim { get; set; }

            [NameInMap("SequenceLength")]
            [Validation(Required=false)]
            public long? SequenceLength { get; set; }

            [NameInMap("SubFeatures")]
            [Validation(Required=false)]
            public List<GetModelFeatureFGFeatureResponseBodySequenceFeaturesSubFeatures> SubFeatures { get; set; }
            public class GetModelFeatureFGFeatureResponseBodySequenceFeaturesSubFeatures : TeaModel {
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("FeatureDomain")]
                [Validation(Required=false)]
                public string FeatureDomain { get; set; }

                [NameInMap("FeatureName")]
                [Validation(Required=false)]
                public string FeatureName { get; set; }

                [NameInMap("FeatureType")]
                [Validation(Required=false)]
                public string FeatureType { get; set; }

                [NameInMap("InputFeatureName")]
                [Validation(Required=false)]
                public string InputFeatureName { get; set; }

                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

        }

    }

}
