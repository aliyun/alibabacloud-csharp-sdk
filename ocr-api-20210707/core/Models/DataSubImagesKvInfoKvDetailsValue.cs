// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class DataSubImagesKvInfoKvDetailsValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;address&quot;</para>
        /// </summary>
        [NameInMap("KeyName")]
        [Validation(Required=false)]
        public string KeyName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("KeyConfidence")]
        [Validation(Required=false)]
        public int? KeyConfidence { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>98</para>
        /// </summary>
        [NameInMap("ValueConfidence")]
        [Validation(Required=false)]
        public int? ValueConfidence { get; set; }

        [NameInMap("ValuePoints")]
        [Validation(Required=false)]
        public List<DataSubImagesKvInfoKvDetailsValueValuePoints> ValuePoints { get; set; }
        public class DataSubImagesKvInfoKvDetailsValueValuePoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public int? X { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public int? Y { get; set; }

        }

        [NameInMap("ValueRect")]
        [Validation(Required=false)]
        public DataSubImagesKvInfoKvDetailsValueValueRect ValueRect { get; set; }
        public class DataSubImagesKvInfoKvDetailsValueValueRect : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CenterX")]
            [Validation(Required=false)]
            public int? CenterX { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("CenterY")]
            [Validation(Required=false)]
            public int? CenterY { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ValueAngle")]
        [Validation(Required=false)]
        public int? ValueAngle { get; set; }

    }

}
