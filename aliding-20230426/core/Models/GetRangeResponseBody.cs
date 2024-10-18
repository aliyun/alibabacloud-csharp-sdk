// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetRangeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("backgroundColors")]
        [Validation(Required=false)]
        public List<List<GetRangeResponseBodyBackgroundColors>> BackgroundColors { get; set; }
        public class GetRangeResponseBodyBackgroundColors : TeaModel {
            /// <summary>
            /// <para>red</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Red")]
            [Validation(Required=false)]
            public int? Red { get; set; }

            /// <summary>
            /// <para>green</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Green")]
            [Validation(Required=false)]
            public int? Green { get; set; }

            /// <summary>
            /// <para>blue</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Blue")]
            [Validation(Required=false)]
            public int? Blue { get; set; }

            /// <summary>
            /// <para>hexString</para>
            /// 
            /// <b>Example:</b>
            /// <para>#000000</para>
            /// </summary>
            [NameInMap("HexString")]
            [Validation(Required=false)]
            public string HexString { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("displayValues")]
        [Validation(Required=false)]
        public List<List<string>> DisplayValues { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("formulas")]
        [Validation(Required=false)]
        public List<List<string>> Formulas { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public List<List<object>> Values { get; set; }

    }

}
