// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SmartqQueryAbilityResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D787E1A3-A************2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public SmartqQueryAbilityResponseBodyResult Result { get; set; }
        public class SmartqQueryAbilityResponseBodyResult : TeaModel {
            [NameInMap("ChartType")]
            [Validation(Required=false)]
            public string ChartType { get; set; }

            [NameInMap("MetaType")]
            [Validation(Required=false)]
            public List<SmartqQueryAbilityResponseBodyResultMetaType> MetaType { get; set; }
            public class SmartqQueryAbilityResponseBodyResultMetaType : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Polar***STPS</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<SmartqQueryAbilityResponseBodyResultValues> Values { get; set; }
            public class SmartqQueryAbilityResponseBodyResultValues : TeaModel {
                [NameInMap("Row")]
                [Validation(Required=false)]
                public List<string> Row { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
