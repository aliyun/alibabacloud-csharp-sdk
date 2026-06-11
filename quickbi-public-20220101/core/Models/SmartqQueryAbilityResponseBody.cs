// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SmartqQueryAbilityResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A************2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public SmartqQueryAbilityResponseBodyResult Result { get; set; }
        public class SmartqQueryAbilityResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The recommended chart type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NEW_TABLE</para>
            /// </summary>
            [NameInMap("ChartType")]
            [Validation(Required=false)]
            public string ChartType { get; set; }

            /// <summary>
            /// <para>The summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("ConclusionText")]
            [Validation(Required=false)]
            public string ConclusionText { get; set; }

            /// <summary>
            /// <para>The list of data that is returned only in multi-step scenarios. Each element corresponds to a set of chart data.</para>
            /// </summary>
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<string> DataList { get; set; }

            /// <summary>
            /// <para>The visual logical SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select * ****</para>
            /// </summary>
            [NameInMap("LogicSql")]
            [Validation(Required=false)]
            public string LogicSql { get; set; }

            /// <summary>
            /// <para>A list of column tuple types.</para>
            /// </summary>
            [NameInMap("MetaType")]
            [Validation(Required=false)]
            public List<SmartqQueryAbilityResponseBodyResultMetaType> MetaType { get; set; }
            public class SmartqQueryAbilityResponseBodyResultMetaType : TeaModel {
                /// <summary>
                /// <para>The name of the column tuple.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Polar***STPS</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The type of the metadata. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Dimension</para>
                /// </description></item>
                /// <item><description><para>Measure</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Dimension</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The type of the column tuple.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>An array of data value lists.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<SmartqQueryAbilityResponseBodyResultValues> Values { get; set; }
            public class SmartqQueryAbilityResponseBodyResultValues : TeaModel {
                /// <summary>
                /// <para>The data values in a row.</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("Row")]
                [Validation(Required=false)]
                public List<string> Row { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
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
